/*
 * rrLLVMModelDataSymbols.h
 *
 * Created on: Jun 28, 2013
 *
 * Author: Andy Somogyi,
 *     email decode: V1 = "."; V2 = "@"; V3 = V1;
 *     andy V1 somogyi V2 gmail V3 com
 */

#ifndef LLVMModelDataSymbolsH
#define LLVMModelDataSymbolsH

#include "rrModelData.h"
#include "rrExecutableModel.h"

#include <map>

namespace libsbml { class Model; }

namespace rr
{

enum ModelDataFields {
    Size = 0,                                 // 0
    Flags,                                    // 1
    Time,                                     // 2
    NumIndependentSpecies,                    // 3
    NumDependentSpecies,                      // 4
    DependentSpeciesConservedSums,            // 5
    NumGlobalParameters,                      // 6
    GlobalParameters,                         // 7
    NumReactions,                             // 8
    ReactionRates,                            // 9
    NumRateRules,                             // 10
    RateRules,                                // 11
    LocalParametersOffsets,                   // 12
    LocalParametersNum,                       // 13
    LocalParameters,                          // 14
    NumFloatingSpecies,                       // 15
    FloatingSpeciesConcentrations,            // 16
    FloatingSpeciesInitConcentrations,        // 17
    FloatingSpeciesAmountRates,               // 18
    FloatingSpeciesAmounts,                   // 19
    FloatingSpeciesCompartments,              // 20
    NumBoundarySpecies,                       // 21
    BoundarySpeciesConcentrations,            // 22
    BoundarySpeciesAmounts,                   // 23
    BoundarySpeciesCompartments,              // 24
    NumCompartments,                          // 25
    CompartmentVolumes,                       // 26
    Stoichiometry,                            // 27
    NumEvents,                                // 28
    EventTypeSize,                            // 29
    EventType,                                // 20
    EventPersistentTypeSize,                  // 31
    EventPersistentType,                      // 32
    EventTestsSize,                           // 33
    EventTests,                               // 34
    EventPrioritiesSize,                      // 35
    EventPriorities,                          // 36
    EventStatusArraySize,                     // 37
    EventStatusArray,                         // 38
    PreviousEventStatusArraySize,             // 39
    PreviousEventStatusArray,                 // 40
    WorkSize,                                 // 41
    Work,                                     // 42
    EventDelays,                              // 43
    EventAssignments,                         // 44
    ComputeEventAssignments,                  // 45
    PerformEventAssignments,                  // 46
    ModelName,                                // 47
    VariableTable,                            // 48
    BoundaryTable,                            // 49
    GlobalParameterTable,                     // 50
    SrSize,                                   // 51
    Sr                                        // 52
};

class LLVMModelDataSymbols
{
public:

    typedef std::map<std::string, int> StringIntMap;
    typedef std::pair<std::string, int> StringIntPair;

    LLVMModelDataSymbols();

    LLVMModelDataSymbols(libsbml::Model const* model,
            bool computeAndAssignConsevationLaws);

    virtual ~LLVMModelDataSymbols();



    int getCompartmentIndex(std::string const&) const;
    int getFloatingSpeciesIndex(std::string const&) const;
    int getBoundarySpeciesIndex(std::string const&) const;
    int getFloatingSpeciesCompartmentIndex(std::string const&) const;
    int getBoundarySpeciesCompartmentIndex(std::string const&) const;
    int getGlobalParameterIndex(std::string const&) const;

    int getReactionIndex(std::string const&) const;
    std::vector<std::string> getReactionIds() const;
    int getReactionSize() const;

    std::vector<std::string> getGlobalParameterIds() const;
    std::vector<std::string> getFloatingSpeciesIds() const;
    int getFloatingSpeciesSize() const;

    std::vector<std::string> getCompartmentIds() const;
    std::vector<std::string> getBoundarySpeciesIds() const;

    /**
     * get a list of all the non-zero entries in the
     * stoichiometry matrix.
     *
     * in the list of pairs, first is the row (species) index,
     * and second is teh column (reaction) index.
     */
    std::list<std::pair<int,int> > getStoichiometryIndx() const;


    void initAllocModelDataBuffers(ModelData& m) const;

    void print() const;


private:

    std::string modelName;
    StringIntMap floatingSpeciesMap;
    StringIntMap boundarySpeciesMap;
    StringIntMap compartmentsMap;
    StringIntMap globalParametersMap;

    /**
     * all reactions are named.
     */
    StringIntMap reactionsMap;

    /**
     * compartment that a floating species belongs to,
     * indexed by floating species index.
     */
    std::vector<int> floatingSpeciesCompartments;

    /**
     * compartment that a boundary species belongs to,
     * indexed by boundary species index.
     */
    std::vector<int> boundarySpeciesCompartments;

    /**
     * the stochiometry matrix is # reactions rows by # species columns.
     *
     * the species indices go here.
     */
    std::vector<int> stoichColIndx;

    /**
     * and the reaction indices go here.
     */
    std::vector<int> stoichRowIndx;


};

} /* namespace rr */
#endif /* RRLLVMMODELDATASYMBOLS_H_ */
