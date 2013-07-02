#include "tests.h"

#include "rrLLVMModelGeneratorContext.h"
#include "rrLLVMModelDataSymbols.h"
#include "rrException.h"
#include "rrUtils.h"

#include <sbml/SBMLDocument.h>
#include <sbml/Model.h>
#include <sbml/SBMLReader.h>

#include <utility>
#include <cstdlib>



using namespace std;

typedef pair<string,int> StrIntPair;

void getPairs(StrIntPair *&, int& npairs);



using namespace rr;



#include <iostream>
#include <fstream>

using namespace std;
using namespace rr;
using namespace llvm;

using namespace libsbml;

bool RunTest(const string& version, int caseNumber);


int main(int argc, char* argv[])
{
    cout << "hi\n";

    LLVMModelGeneratorContext c;

    StructType *s = LLVMModelDataValue::getStructType(c.getModule(), c.getExecutionEngine());

    StrIntPair *pairs;
    int npairs;
    getPairs(pairs, npairs);

    for (int i = 0; i < npairs; i++) {
        runModelDataAccessorTest(pairs[i].first, pairs[i].second);
    }


    return 0;
}


bool RunTest(const string& version, int caseNumber)
{
    bool result = false;
    try
    {
        string modelFileName = getModelFileName(version, caseNumber);

        SBMLDocument *doc = readSBMLFromFile(modelFileName.c_str());

        LLVMModelGeneratorContext c(doc, true);

        //StructType *s = LLVMModelDataValue::getStructType(c.getModule(), c.getExecutionEngine());

        LLVMModelDataSymbols symbols(doc->getModel(), true);

        symbols.print();




        delete doc;


    }
    catch(std::exception& ex)
    {
        string error = ex.what();
        cerr<<"Case "<<caseNumber<<": Exception: "<<error<<endl;
        return false;
    }


    return result;
}






StrIntPair testpairs[] = {
        {"l2v4", 1},
        {"l2v4", 2},
        {"l2v4", 3},
        {"l2v4", 4},
        {"l2v4", 5},
        {"l2v4", 6},
        {"l2v4", 7},
        {"l2v4", 8},
        {"l2v4", 9},
        {"l2v4", 10},
        {"l2v4", 11},
        {"l2v4", 12},
        {"l2v4", 13},
        {"l2v4", 14},
        {"l2v4", 15},
        {"l2v4", 16},
        {"l2v4", 17},
        {"l2v4", 18},
        {"l2v4", 19},
        {"l2v4", 20},
        {"l2v4", 21},
        {"l2v4", 22},
        {"l2v4", 23},
        {"l2v4", 24},
        {"l2v4", 25},
        {"l2v4", 26},
        {"l2v4", 27},
        {"l2v4", 28},
        {"l2v4", 29},
        {"l2v4", 30},
        {"l2v4", 31},
        {"l2v4", 32},
        {"l2v4", 33},

        {"l2v4", 34},
        {"l2v4", 35},
        {"l2v4", 36},
        {"l2v4", 37},
        {"l2v4", 38},
        //{"l2v4", 39},
        //{"l2v4", 40},
        {"l2v4", 41},
        {"l2v4", 42},
        {"l2v4", 43},
        {"l2v4", 44},
        {"l2v4", 45},
        {"l2v4", 46},
        {"l2v4", 47},
        {"l2v4", 48},
        {"l2v4", 49},
        {"l2v4", 50},
        {"l2v4", 51},
        {"l2v4", 52},
        {"l2v4", 53},
        {"l2v4", 54},
        {"l2v4", 55},
        {"l2v4", 56},
        {"l2v4", 57},
        {"l2v4", 58},
        {"l2v4", 59},
        {"l2v4", 60},
        {"l2v4", 61},
        {"l2v4", 62},
        {"l2v4", 63},
        {"l2v4", 64},
        {"l2v4", 65},
        {"l2v4", 66},
        {"l2v4", 67},
        {"l2v4", 68},
        {"l2v4", 69},
        {"l2v4", 70},
        {"l2v4", 71},
        {"l2v4", 72},
        {"l2v4", 73},
        {"l2v4", 74},
        {"l2v4", 75},
        {"l2v4", 76},
        {"l2v4", 77},
        {"l2v4", 78},
        {"l2v4", 79},
        {"l2v4", 80},
        {"l2v4", 81},
        {"l2v4", 82},
        {"l2v4", 83},
        {"l2v4", 84},
        {"l2v4", 85},
        {"l2v4", 86},
        {"l2v4", 87},
        {"l2v4", 88},
        {"l2v4", 89},
        {"l2v4", 90},
        {"l2v4", 91},
        {"l2v4", 92},
        {"l2v4", 93},
        {"l2v4", 94},
        {"l2v4", 95},
        {"l2v4", 96},
        {"l2v4", 97},
        {"l2v4", 98},
        {"l2v4", 99},
        {"l2v4", 100},
        {"l2v4", 101},
        {"l2v4", 102},
        {"l2v4", 103},
        {"l2v4", 104},
        {"l2v4", 105},
        {"l2v4", 106},
        {"l2v4", 107},
        {"l2v4", 108},
        {"l2v4", 109},
        {"l2v4", 110},
        {"l2v4", 111},
        {"l2v4", 112},
        {"l2v4", 113},
        {"l2v4", 114},
        {"l2v4", 115},
        {"l2v4", 116},
        {"l2v4", 117},
        {"l2v4", 118},
        {"l2v4", 119},
        {"l2v4", 120},
        {"l2v4", 121},
        {"l2v4", 122},
        {"l2v4", 123},
        {"l2v4", 124},
        {"l2v4", 125},
        {"l2v4", 126},
        {"l2v4", 127},
        {"l2v4", 128},
        {"l2v4", 129},
        {"l2v4", 130},
        {"l2v4", 131},
        {"l2v4", 132},
        {"l2v4", 133},
        {"l2v4", 134},
        {"l2v4", 135},
        {"l2v4", 136},
        {"l2v4", 137},
        {"l2v4", 138},
        {"l2v4", 139},
        {"l2v4", 140},
        {"l2v4", 141},
        {"l2v4", 142},
        {"l2v4", 143},
        {"l2v4", 144},
        {"l2v4", 145},
        {"l2v4", 146},
        {"l2v4", 147},
        {"l2v4", 148},
        {"l2v4", 149},
        {"l2v4", 150},
        {"l2v4", 151},
        {"l2v4", 152},
        {"l2v4", 153},
        {"l2v4", 154},
        {"l2v4", 155},
        {"l2v4", 156},
        {"l2v4", 157},
        {"l2v4", 158},
        {"l2v4", 159},
        {"l2v4", 160},
        {"l2v4", 161},
        {"l2v4", 162},
        {"l2v4", 163},
        {"l2v4", 164},
        {"l2v4", 165},
        {"l2v4", 166},
        {"l2v4", 167},
        {"l2v4", 168},
        {"l2v4", 169},
        {"l2v4", 170},
        {"l2v4", 171},
        {"l2v4", 172},
        {"l2v4", 173},
        {"l2v4", 174},
        {"l2v4", 175},
        {"l2v4", 176},
        {"l2v4", 177},
        {"l2v4", 178},
        {"l2v4", 179},
        {"l2v4", 180},
        {"l2v4", 181},
        //{"l2v4", 182},
        {"l2v4", 183},
        //{"l2v4", 184},
        {"l2v4", 185},
        {"l2v4", 186},
        {"l2v4", 187},
        {"l2v4", 188},
        {"l2v4", 189},
        {"l2v4", 190},
        {"l2v4", 191},
        {"l2v4", 192},
        {"l2v4", 193},
        {"l2v4", 194},
        {"l2v4", 195},
        {"l2v4", 196},
        {"l2v4", 197},
        {"l2v4", 198},
        {"l2v4", 199},
        {"l2v4", 200},
        {"l2v4", 201},
        {"l2v4", 202},
        {"l2v4", 203},
        {"l2v4", 204},
        {"l2v4", 205},
        {"l2v4", 206},
        {"l2v4", 207},
        {"l2v4", 208},
        {"l2v4", 209},
        {"l2v4", 210},
        {"l2v4", 211},
        {"l2v4", 212},
        {"l2v4", 213},
        {"l2v4", 214},
        {"l2v4", 215},
        {"l2v4", 216},
        {"l2v4", 217},
        {"l2v4", 218},
        {"l2v4", 219},
        {"l2v4", 220},
        {"l2v4", 221},
        {"l2v4", 222},
        {"l2v4", 223},
        {"l2v4", 224},
        {"l2v4", 225},
        {"l2v4", 226},
        {"l2v4", 227},
        {"l2v4", 228},
        {"l2v4", 229},
        {"l2v4", 230},
        {"l2v4", 231},
        {"l2v4", 232},
        {"l2v4", 233},
        {"l2v4", 234},
        {"l2v4", 235},
        {"l2v4", 236},
        {"l2v4", 237},
        {"l2v4", 238},
        {"l2v4", 239},
        {"l2v4", 240},
        {"l2v4", 241},
        {"l2v4", 242},
        {"l2v4", 243},
        {"l2v4", 244},
        {"l2v4", 245},
        {"l2v4", 246},
        {"l2v4", 247},
        {"l2v4", 248},
        {"l2v4", 249},
        {"l2v4", 250},
        {"l2v4", 251},
        {"l2v4", 252},
        {"l2v4", 253},
        {"l2v4", 254},
        {"l2v4", 255},
        {"l2v4", 256},
        {"l2v4", 257},
        {"l2v4", 258},
        {"l2v4", 259},
        {"l2v4", 260},
        {"l2v4", 261},
        {"l2v4", 262},
        {"l2v4", 263},
        {"l2v4", 264},
        {"l2v4", 265},
        {"l2v4", 266},
        {"l2v4", 267},
        {"l2v4", 268},
        {"l2v4", 269},
        {"l2v4", 270},
        {"l2v4", 271},
        {"l2v4", 272},
        {"l2v4", 273},
        {"l2v4", 274},
        {"l2v4", 275},
        {"l2v4", 276},
        {"l2v4", 277},
        {"l2v4", 278},
        {"l2v4", 279},
        {"l2v4", 280},
        {"l2v4", 281},
        {"l2v4", 282},
        {"l2v4", 283},
        {"l2v4", 284},
        {"l2v4", 285},
        {"l2v4", 286},
        {"l2v4", 287},
        {"l2v4", 288},
        {"l2v4", 289},
        {"l2v4", 290},
        {"l2v4", 291},
        {"l2v4", 292},
        {"l2v4", 293},
        {"l2v4", 294},
        {"l2v4", 295},
        {"l2v4", 296},
        {"l2v4", 297},
        {"l2v4", 298},
        {"l2v4", 299},
        {"l2v4", 300},
        {"l2v4", 301},
        {"l2v4", 302},
        {"l2v4", 303},
        {"l2v4", 304},
        {"l2v4", 305},
        {"l2v4", 306},
        {"l2v4", 307},
        {"l2v4", 308},
        {"l2v4", 309},
        {"l2v4", 310},
        {"l2v4", 311},
        {"l2v4", 312},
        {"l2v4", 313},
        {"l2v4", 314},
        {"l2v4", 315},
        {"l2v4", 316},
        {"l2v4", 317},
        {"l2v4", 318},
        {"l2v4", 319},
        {"l2v4", 320},
        {"l2v4", 321},
        {"l2v4", 322},
        {"l2v4", 323},
        {"l2v4", 324},
        {"l2v4", 325},
        {"l2v4", 326},
        {"l2v4", 327},
        {"l2v4", 328},
        {"l2v4", 329},
        {"l2v4", 330},
        {"l2v4", 331},
        {"l2v4", 332},
        {"l2v4", 333},
        {"l2v4", 334},
        {"l2v4", 335},
        {"l2v4", 336},
        {"l2v4", 337},
        {"l2v4", 338},
        {"l2v4", 339},
        {"l2v4", 340},
        {"l2v4", 341},
        {"l2v4", 342},
        {"l2v4", 343},
        {"l2v4", 344},
        {"l2v4", 345},
        {"l2v4", 346},
        {"l2v4", 347},
        {"l2v4", 348},
        {"l2v4", 349},
        {"l2v4", 350},
        {"l2v4", 351},
        {"l2v4", 352},
        {"l2v4", 353},
        {"l2v4", 354},
        {"l2v4", 355},
        {"l2v4", 356},
        {"l2v4", 357},
        {"l2v4", 358},
        {"l2v4", 359},
        {"l2v4", 360},
        {"l2v4", 361},
        {"l2v4", 362},
        {"l2v4", 363},
        {"l2v4", 364},
        {"l2v4", 365},
        {"l2v4", 366},
        {"l2v4", 367},
        {"l2v4", 368},
        {"l2v4", 369},
        {"l2v4", 370},
        {"l2v4", 371},
        {"l2v4", 372},
        {"l2v4", 373},
        {"l2v4", 374},
        {"l2v4", 375},
        {"l2v4", 376},
        {"l2v4", 377},
        {"l2v4", 378},
        {"l2v4", 379},
        {"l2v4", 380},
        {"l2v4", 381},
        {"l2v4", 382},
        {"l2v4", 383},
        {"l2v4", 384},
        {"l2v4", 385},
        {"l2v4", 386},
        {"l2v4", 387},
        {"l2v4", 388},
        {"l2v4", 389},
        {"l2v4", 390},
        {"l2v4", 391},
        {"l2v4", 392},
        {"l2v4", 393},
        {"l2v4", 394},
        {"l2v4", 395},
        {"l2v4", 396},
        {"l2v4", 397},
        {"l2v4", 398},
        {"l2v4", 399},
        {"l2v4", 400},
        {"l2v4", 401},
        {"l2v4", 402},
        {"l2v4", 403},
        {"l2v4", 404},
        {"l2v4", 405},
        {"l2v4", 406},
        {"l2v4", 407},
        {"l2v4", 408},
        {"l2v4", 409},
        {"l2v4", 410},
        {"l2v4", 411},
        {"l2v4", 412},
        {"l2v4", 413},
        {"l2v4", 414},
        {"l2v4", 415},
        {"l2v4", 416},
        {"l2v4", 417},
        {"l2v4", 418},
        {"l2v4", 419},
        {"l2v4", 420},
        {"l2v4", 421},
        {"l2v4", 422},
        {"l2v4", 423},
        {"l2v4", 424},
        {"l2v4", 425},
        {"l2v4", 426},
        {"l2v4", 427},
        {"l2v4", 428},
        {"l2v4", 429},
        {"l2v4", 430},
        {"l2v4", 431},
        {"l2v4", 432},
        {"l2v4", 433},
        {"l2v4", 434},
        {"l2v4", 435},
        {"l2v4", 436},
        {"l2v4", 437},
        {"l2v4", 438},
        {"l2v4", 439},
        {"l2v4", 440},
        {"l2v4", 441},
        {"l2v4", 442},
        {"l2v4", 443},
        {"l2v4", 444},
        {"l2v4", 445},
        {"l2v4", 446},
        {"l2v4", 447},
        {"l2v4", 448},
        {"l2v4", 449},
        {"l2v4", 450},
        {"l2v4", 451},
        {"l2v4", 452},
        {"l2v4", 453},
        {"l2v4", 454},
        {"l2v4", 455},
        {"l2v4", 456},
        {"l2v4", 457},
        {"l2v4", 458},
        {"l2v4", 459},
        {"l2v4", 460},
        {"l2v4", 461},
        {"l2v4", 462},
        {"l2v4", 463},
        {"l2v4", 464},
        {"l2v4", 465},
        {"l2v4", 466},
        {"l2v4", 467},
        {"l2v4", 468},
        {"l2v4", 469},
        {"l2v4", 470},
        {"l2v4", 471},
        {"l2v4", 472},
        {"l2v4", 473},
        {"l2v4", 474},
        {"l2v4", 475},
        {"l2v4", 476},
        {"l2v4", 477},
        {"l2v4", 478},
        {"l2v4", 479},
        {"l2v4", 480},
        {"l2v4", 481},
        {"l2v4", 482},
        {"l2v4", 483},
        {"l2v4", 484},
        {"l2v4", 485},
        {"l2v4", 486},
        {"l2v4", 487},
        {"l2v4", 488},
        {"l2v4", 489},
        {"l2v4", 490},
        {"l2v4", 491},
        {"l2v4", 492},
        {"l2v4", 493},
        {"l2v4", 494},
        {"l2v4", 495},
        {"l2v4", 496},
        {"l2v4", 497},
        {"l2v4", 498},
        {"l2v4", 499},
        {"l2v4", 500},
        {"l2v4", 501},
        {"l2v4", 502},
        {"l2v4", 503},
        {"l2v4", 504},
        {"l2v4", 505},
        {"l2v4", 506},
        {"l2v4", 507},
        {"l2v4", 508},
        {"l2v4", 509},
        {"l2v4", 510},
        {"l2v4", 511},
        {"l2v4", 512},
        {"l2v4", 513},
        {"l2v4", 514},
        {"l2v4", 515},
        {"l2v4", 516},
        {"l2v4", 517},
        {"l2v4", 518},
        {"l2v4", 519},
        {"l2v4", 520},
        {"l2v4", 521},
        {"l2v4", 522},
        {"l2v4", 523},
        {"l2v4", 524},
        {"l2v4", 525},
        {"l2v4", 526},
        {"l2v4", 527},
        {"l2v4", 528},
        {"l2v4", 529},
        {"l2v4", 530},
        //{"l2v4", 531},
        {"l2v4", 532},
        //{"l2v4", 533},
        //{"l2v4", 534},
        //{"l2v4", 535},
        //{"l2v4", 536},
        //{"l2v4", 537},
        //{"l2v4", 538},
        {"l2v4", 539},
        {"l2v4", 540},
        {"l2v4", 541},
        {"l2v4", 542},
        //{"l2v4", 543},
        {"l2v4", 544},
        {"l2v4", 545},
        //{"l2v4", 546},
        {"l2v4", 547},
        //{"l2v4", 548},
        //{"l2v4", 549},
        //{"l2v4", 550},
        //{"l2v4", 551},
        //{"l2v4", 552},
        //{"l2v4", 553},
        //{"l2v4", 554},
        //{"l2v4", 555},
        //{"l2v4", 556},
        //{"l2v4", 557},
        //{"l2v4", 558},
        //{"l2v4", 559},
        //{"l2v4", 560},
        //{"l2v4", 561},
        //{"l2v4", 562},
        //{"l2v4", 563},
        //{"l2v4", 564},
        //{"l2v4", 565},
        //{"l2v4", 566},
        //{"l2v4", 567},
        {"l2v4", 568},
        //{"l2v4", 569},
        //{"l2v4", 570},
        //{"l2v4", 571},
        {"l2v4", 572},
        //{"l2v4", 573},
        {"l2v4", 574},
        //{"l2v4", 575},
        //{"l2v4", 576},
        {"l2v4", 577},
        {"l2v4", 578},
        {"l2v4", 579},
        {"l2v4", 580},
        {"l2v4", 581},
        {"l2v4", 582},
        {"l2v4", 583},
        {"l2v4", 584},
        {"l2v4", 585},
        {"l2v4", 586},
        {"l2v4", 587},
        {"l2v4", 588},
        {"l2v4", 589},
        {"l2v4", 590},
        {"l2v4", 591},
        {"l2v4", 592},
        {"l2v4", 593},
        {"l2v4", 594},
        {"l2v4", 595},
        {"l2v4", 596},
        {"l2v4", 597},
        {"l2v4", 598},
        {"l2v4", 599},
        {"l2v4", 600},
        {"l2v4", 601},
        {"l2v4", 602},
        {"l2v4", 603},
        {"l2v4", 604},
        {"l2v4", 605},
        {"l2v4", 606},
        {"l2v4", 607},
        {"l2v4", 608},
        {"l2v4", 609},
        {"l2v4", 610},
        {"l2v4", 611},
        {"l2v4", 612},
        //{"l2v4", 613},
        //{"l2v4", 614},
        //{"l2v4", 615},
        {"l2v4", 616},
        {"l2v4", 617},
        {"l2v4", 618},
        {"l2v4", 619},
        {"l2v4", 620},
        {"l2v4", 621},
        {"l2v4", 622},
        {"l2v4", 623},
        {"l2v4", 624},
        {"l2v4", 625},
        {"l2v4", 626},
        {"l2v4", 627},
        //{"l2v4", 628},
        //{"l2v4", 629},
        //{"l2v4", 630},
        {"l2v4", 631},
        {"l2v4", 632},
        {"l2v4", 633},
        {"l2v4", 634},
        {"l2v4", 635},
        {"l2v4", 636},
        {"l2v4", 637},
        {"l2v4", 638},
        {"l2v4", 639},
        {"l2v4", 640},
        {"l2v4", 641},
        {"l2v4", 642},
        {"l2v4", 643},
        {"l2v4", 644},
        {"l2v4", 645},
        {"l2v4", 646},
        {"l2v4", 647},
        {"l2v4", 648},
        {"l2v4", 649},
        {"l2v4", 650},
        {"l2v4", 651},
        {"l2v4", 652},
        {"l2v4", 653},
        {"l2v4", 654},
        {"l2v4", 655},
        {"l2v4", 656},
        {"l2v4", 657},
        //{"l2v4", 658},
        //{"l2v4", 659},
        //{"l2v4", 660},
        //{"l2v4", 661},
        //{"l2v4", 662},
        //{"l2v4", 663},
        //{"l2v4", 664},
        //{"l2v4", 665},
        //{"l2v4", 666},
        {"l2v4", 667},
        {"l2v4", 668},
        {"l2v4", 669},
        {"l2v4", 670},
        {"l2v4", 671},
        {"l2v4", 672},
        //{"l2v4", 673},
        //{"l2v4", 674},
        //{"l2v4", 675},
        {"l2v4", 676},
        {"l2v4", 677},
        {"l2v4", 678},
        {"l2v4", 679},
        {"l2v4", 680},
        {"l2v4", 681},
        {"l2v4", 682},
        {"l2v4", 683},
        {"l2v4", 684},
        {"l2v4", 685},
        {"l2v4", 686},
        //{"l2v4", 687},
        {"l2v4", 688},
        {"l2v4", 689},
        {"l2v4", 690},
        {"l2v4", 691},
        {"l2v4", 692},
        {"l2v4", 693},
        {"l2v4", 694},
        //{"l2v4", 695},
        //{"l2v4", 696},
        {"l2v4", 697},
        {"l2v4", 698},
        {"l2v4", 699},
        {"l2v4", 700},
        {"l2v4", 701},
        {"l2v4", 702},
        {"l2v4", 703},
        {"l2v4", 704},
        //{"l2v4", 705},
        {"l2v4", 706},
        {"l2v4", 707},
        {"l2v4", 708},
        {"l2v4", 709},
        {"l2v4", 710},
        {"l2v4", 711},
        {"l2v4", 712},
        {"l2v4", 713},
        {"l2v4", 714},
        {"l2v4", 715},
        {"l2v4", 716},
        {"l2v4", 717},
        {"l2v4", 718},
        {"l2v4", 719},
        {"l2v4", 720},
        {"l2v4", 721},
        {"l2v4", 722},
        {"l2v4", 723},
        {"l2v4", 724},
        {"l2v4", 725},
        {"l2v4", 726},
        {"l2v4", 727},
        {"l2v4", 728},
        {"l2v4", 729},
        {"l2v4", 730},
        {"l2v4", 731},
        {"l2v4", 732},
        {"l2v4", 733},
        {"l2v4", 734},
        {"l2v4", 735},
        {"l2v4", 736},
        {"l2v4", 737},
        {"l2v4", 738},
        {"l2v4", 739},
        {"l2v4", 740},
        {"l2v4", 741},
        {"l2v4", 742},
        {"l2v4", 743},
        {"l2v4", 744},
        {"l2v4", 745},
        {"l2v4", 746},
        {"l2v4", 747},
#if !defined(_MSC_VER)
        {"l2v4", 748},
#endif
        {"l2v4", 749},
        {"l2v4", 750},
        {"l2v4", 751},
        {"l2v4", 752},
        {"l2v4", 753},
        {"l2v4", 754},
        {"l2v4", 755},
        {"l2v4", 756},
        {"l2v4", 757},
        {"l2v4", 758},
        {"l2v4", 759},
        //{"l2v4", 760},
        //{"l2v4", 761},
        //{"l2v4", 762},
        {"l2v4", 763},
        {"l2v4", 764},
        {"l2v4", 765},
        {"l2v4", 766},
        {"l2v4", 767},
        {"l2v4", 768},
        {"l2v4", 769},
        {"l2v4", 770},
        {"l2v4", 771},
        {"l2v4", 772},
        {"l2v4", 773},
        {"l2v4", 774},
        {"l2v4", 775},
        {"l2v4", 776},
        //{"l2v4", 777},
        //{"l2v4", 778},
        //{"l2v4", 779},
        //{"l2v4", 780},
        {"l2v4", 781},
        {"l2v4", 782},
        {"l2v4", 783},
        {"l2v4", 784},
        {"l2v4", 785},
        {"l2v4", 786},
        {"l2v4", 787},
        {"l2v4", 788},
        {"l2v4", 789},
        {"l2v4", 790},
        {"l2v4", 791},
        {"l2v4", 792},
        {"l2v4", 793},
        {"l2v4", 794},
        {"l2v4", 795},
        {"l2v4", 796},
        {"l2v4", 797},
        {"l2v4", 798},
        {"l2v4", 799},
        {"l2v4", 800},
        {"l2v4", 801},
        {"l2v4", 802},
        {"l2v4", 803},
        {"l2v4", 804},
        {"l2v4", 805},
        {"l2v4", 806},
        {"l2v4", 807},
        {"l2v4", 808},
        {"l2v4", 809},
        {"l2v4", 810},
        {"l2v4", 811},
        {"l2v4", 812},
        {"l2v4", 813},
        {"l2v4", 814},
        {"l2v4", 815},
        {"l2v4", 816},
        {"l2v4", 817},
        {"l2v4", 818},
        {"l2v4", 819},
        {"l2v4", 820},
        {"l2v4", 821},
        {"l2v4", 822},
        {"l2v4", 823},
        {"l2v4", 824},
        {"l2v4", 825},
        {"l2v4", 826},
        {"l2v4", 827},
        {"l2v4", 828},
        {"l2v4", 829},
        {"l2v4", 830},
        {"l2v4", 831},
        {"l2v4", 832},
        {"l2v4", 833},
        {"l2v4", 834},
        {"l2v4", 835},
        {"l2v4", 836},
        {"l2v4", 837},
        {"l2v4", 838},
        {"l2v4", 839},
        {"l2v4", 840},
        {"l2v4", 841},

        {"l2v4", 842},
        {"l2v4", 843},
        //{"l2v4", 844},
        {"l2v4", 845},
        {"l2v4", 846},
        {"l2v4", 847},
        {"l2v4", 848},
        {"l2v4", 849},
        {"l2v4", 850},
        {"l2v4", 851},
        {"l2v4", 852},
        {"l2v4", 853},
        {"l2v4", 854},
        {"l2v4", 855},
        {"l2v4", 856},
        {"l2v4", 857},
        {"l2v4", 858},
        {"l2v4", 859},
        {"l2v4", 860},
        {"l2v4", 861},
        {"l2v4", 862},
        {"l2v4", 863},
        {"l2v4", 864},
        {"l2v4", 865},
        {"l2v4", 866},
        {"l2v4", 867},
        {"l2v4", 868},
        {"l2v4", 869},
        //{"l2v4", 870},
        //{"l2v4", 871},
        //{"l2v4", 872},
        //{"l2v4", 873},
        //{"l2v4", 874},
        //{"l2v4", 875},
        //{"l2v4", 876},
        {"l2v4", 877},
        {"l2v4", 878},
        {"l2v4", 879},
        {"l2v4", 880},
        {"l2v4", 881},
        {"l2v4", 882},
        {"l2v4", 883},
        {"l2v4", 884},
        {"l2v4", 885},
        {"l2v4", 886},
        {"l2v4", 887},
        {"l2v4", 888},
        {"l2v4", 889},
        {"l2v4", 890},
        {"l2v4", 891},
        {"l2v4", 892},
        {"l2v4", 893},
        {"l2v4", 894},
        {"l2v4", 895},
        {"l2v4", 896},
        {"l2v4", 897},
        {"l2v4", 898},
        {"l2v4", 899},
        {"l2v4", 900},
        {"l2v4", 901},
        {"l2v4", 902},
        {"l2v4", 903},
        {"l2v4", 904},
        {"l2v4", 905},
        {"l2v4", 906},
        {"l2v4", 907},
        {"l2v4", 908},
        {"l2v4", 909},
        {"l2v4", 910},
        {"l2v4", 911},
        {"l2v4", 912},
        {"l2v4", 913},
        {"l2v4", 914},
        {"l2v4", 915},
        {"l2v4", 916},
        {"l2v4", 917},
        {"l2v4", 918},
        {"l2v4", 919},
        {"l2v4", 920},
        {"l2v4", 921},
        {"l2v4", 922},
        {"l2v4", 923},
        {"l2v4", 924},
        {"l2v4", 925},
        {"l2v4", 926},
        {"l2v4", 927},

        {"l3v1", 928},
        {"l3v1", 929},
        {"l3v1", 930},
        {"l3v1", 931},
        {"l3v1", 932},
        {"l3v1", 934},
        {"l3v1", 935},

        {"l2v4", 936},
        //{"l2v4", 937},
        //{"l2v4", 938},
        //{"l2v4", 939},
        //{"l2v4", 940},
        //{"l2v4", 941},
        //{"l2v4", 942},
        //{"l2v4", 943},
        {"l2v4", 944},
        {"l2v4", 945},
        {"l2v4", 946},
        {"l2v4", 947},
        {"l2v4", 948},
        {"l2v4", 949},
        //{"l2v4", 950},
        //{"l2v4", 951},

#if !defined(_MSC_VER)
        {"l3v1", 952},
#endif

        {"l3v1", 953},

        {"l2v4", 954},
        //{"l2v4", 955},
        {"l2v4", 956},
        //{"l2v4", 957},
        //{"l2v4", 958},
        //{"l2v4", 959},

        {"l3v1", 960},
        {"l3v1", 961},
        //{"l3v1", 962},

#if !defined(__CODEGEARC__)
        {"l3v1", 963},
        {"l3v1", 964},
#endif

#if !defined(_MSC_VER)
        //{"l3v1", 965},
#endif

        //{"l3v1", 966},
        {"l3v1", 967},



        {"l2v4", 968},
        {"l3v1", 969},
        {"l3v1", 970},
        {"l3v1", 971},
        {"l3v1", 972},
        {"l2v4", 973},

        {"l3v1", 974},
        {"l3v1", 975},
        {"l3v1", 976},
        {"l3v1", 977},
        //{"l3v1", 978},

        {"l2v4", 979},

        {"l3v1", 980 },

        //{"l3v1", 981  },
        //{"l3v1", 982  },
        //{"l3v1", 983  },
        //{"l3v1", 984  },
        //{"l3v1", 985  },
        //{"l3v1", 986  },
        //{"l3v1", 987  },
        //{"l3v1", 988  },
        {"l2v4", 989  },
        {"l2v4", 990  },
        {"l2v4", 991  },
        {"l2v4", 992  },
        //{"l2v4", 993  },
        {"l2v4", 994  },
        //{"l3v1", 995  },
        //{"l3v1", 996  },
        //{"l3v1", 997  },
        {"l3v1", 998  },
        {"l3v1", 999  },
        //{"l3v1", 1000 },
        {"l3v1", 1001 },
        {"l3v1", 1002 },
        {"l3v1", 1003 },
        {"l3v1", 1004 },
        {"l3v1", 1005 },
        {"l3v1", 1006 },
        {"l3v1", 1007 },
        {"l3v1", 1008 },
        {"l3v1", 1009 },
        {"l3v1", 1010 },
        {"l3v1", 1011 },
        {"l3v1", 1012 },
        {"l3v1", 1013 },
        {"l3v1", 1014 },
        {"l3v1", 1015 },
        {"l3v1", 1016 },
        {"l3v1", 1017 },
        {"l3v1", 1018 },
        {"l3v1", 1019 },
        {"l3v1", 1020 },
        {"l3v1", 1021 },
        {"l3v1", 1022 },
        {"l3v1", 1023 },
        {"l3v1", 1024 },
        {"l3v1", 1025 },
        {"l3v1", 1026 },
        {"l2v4", 1027 },
        {"l2v4", 1028 },
        {"l2v4", 1029 },
        {"l3v1", 1030 },
        {"l3v1", 1031 },
        {"l3v1", 1032 },
        {"l3v1", 1033 },
        {"l3v1", 1034 },
        {"l3v1", 1035 },
        {"l3v1", 1036 },
        {"l3v1", 1037 },
        {"l3v1", 1038 },
        {"l3v1", 1039 },
        {"l3v1", 1040 },
        {"l3v1", 1041 },
        {"l3v1", 1042 },
        {"l3v1", 1043 },
        //{"l3v1", 1044 },
        {"l3v1", 1045 },
        {"l3v1", 1046 },
        {"l3v1", 1047 },
        {"l3v1", 1048 },
        {"l3v1", 1049 },
        {"l3v1", 1050 },
        //{"l3v1", 1051 },
        //{"l3v1", 1052 },
        //{"l3v1", 1053 },
        //{"l3v1", 1054 },
        {"l3v1", 1055 },
        {"l3v1", 1056 },
        {"l3v1", 1057 },
        {"l3v1", 1058 },
        {"l3v1", 1059 },
        {"l3v1", 1060 },
        {"l3v1", 1061 },
        {"l3v1", 1062 },
        {"l3v1", 1063 },
        {"l3v1", 1064 },
        {"l3v1", 1065 },
        {"l3v1", 1066 },
        {"l3v1", 1067 },
        {"l3v1", 1068 },
        {"l3v1", 1069 },
        {"l3v1", 1070 },
        {"l3v1", 1071 },
        {"l3v1", 1072 },
        {"l3v1", 1073 },
        {"l3v1", 1074 },
        {"l3v1", 1075 },
        {"l3v1", 1076 },
        {"l3v1", 1077 },
        {"l3v1", 1078 },
        {"l3v1", 1079 },
        {"l3v1", 1080 },
        {"l3v1", 1081 },
        {"l3v1", 1082 },
        //{"l3v1", 1083 },
        //{"l3v1", 1084 },
        //{"l3v1", 1085 },
        //{"l3v1", 1086 },
        {"l3v1", 1087 },
        {"l3v1", 1088 },
        {"l3v1", 1089 },
        {"l3v1", 1090 },
        {"l3v1", 1091 },
        {"l3v1", 1092 },
        {"l3v1", 1093 },
        {"l3v1", 1094 },
        {"l3v1", 1095 },
        {"l3v1", 1096 },
        {"l3v1", 1097 },
        {"l3v1", 1098 },
        {"l3v1", 1099 },
        {"l3v1", 1100 },
        {"l3v1", 1101 },
        {"l3v1", 1102 },
        {"l3v1", 1103 },
        {"l3v1", 1104 },
        {"l3v1", 1105 },
        {"l3v1", 1106 },
        {"l3v1", 1107 },
        //{"l3v1", 1108 },
        {"l3v1", 1109 },
        {"l3v1", 1110 },
        {"l3v1", 1111 },
        //{"l3v1", 1112 },
        //{"l3v1", 1113 },
        //{"l3v1", 1114 },
        //{"l3v1", 1115 },
        {"l3v1", 1116 },
        {"l3v1", 1117 },
        //{"l3v1", 1118 },
        //{"l3v1", 1119 },
        //{"l3v1", 1120 },
        //{"l3v1", 1121 },
        //{"l3v1", 1122 },
        //{"l3v1", 1123 },
        {"l3v1", 1124 },
        {"l3v1", 1125 },
        //{"l3v1", 1126 },
        //{"l3v1", 1127 },
        //{"l3v1", 1128 },
        //{"l3v1", 1129 },
        //{"l3v1", 1130 },
        //{"l3v1", 1131 },
        //{"l3v1", 1132 },
        //{"l3v1", 1133 },
        //{"l3v1", 1134 },
        //{"l3v1", 1135 },
        //{"l3v1", 1136 },
        //{"l3v1", 1137 },
        //{"l3v1", 1138 },
        //{"l3v1", 1139 },
        //{"l3v1", 1140 },
        //{"l3v1", 1141 },
        //{"l3v1", 1142 },
        //{"l3v1", 1143 },
        //{"l3v1", 1144 },
        //{"l3v1", 1145 },
        //{"l3v1", 1146 },
        //{"l3v1", 1147 },
        //{"l3v1", 1148 },
        {"l3v1", 1149 },
        {"l3v1", 1150 },
        {"l3v1", 1151 },
        //{"l3v1", 1152 },
        //{"l3v1", 1153 },
        //{"l3v1", 1154 },
        //{"l3v1", 1155 },
        //{"l3v1", 1156 },
        //{"l3v1", 1157 },
        //{"l3v1", 1158 },
        //{"l3v1", 1159 },
        //{"l3v1", 1160 },
        //{"l3v1", 1161 },
        {"l3v1", 1162 },
        {"l3v1", 1163 },
        //{"l3v1", 1164 },
        //{"l3v1", 1165 },
        {"l3v1", 1166 },
        //{"l3v1", 1167 },
        //{"l3v1", 1168 },
        //{"l3v1", 1169 },
        //{"l3v1", 1170 },
        //{"l3v1", 1171 },
        //{"l3v1", 1172 },
        //{"l3v1", 1173 },
        //{"l3v1", 1174 },
        //{"l3v1", 1175 },
        //{"l3v1", 1176 },
        //{"l3v1", 1177 },
        //{"l3v1", 1178 },
        //{"l3v1", 1179 },
        //{"l3v1", 1180 },
        //{"l3v1", 1181 },
        //{"l3v1", 1182 },
        //{"l3v1", 1183 },
        {"l3v1", 1184 },
        {"l3v1", 1185 }

};


void getPairs(StrIntPair *&pairs, int& npairs) {
    pairs = testpairs;
    npairs = sizeof(testpairs) / sizeof(StrIntPair);

}





#if 0


/*
 * <test suite="SBML_l2v4" name="15" time="0.248"/>
<test suite="SBML_l2v4" name="16" time="0.239"/>
<test suite="SBML_l2v4" name="17" time="0.221"/>
<test suite="SBML_l2v4" name="18" time="0.246"/>
<test suite="SBML_l2v4" name="19" time="0.25"/>
<test suite="SBML_l2v4" name="20" time="0.257"/>
<test suite="SBML_l2v4" name="21" time="0.201"/>
<test suite="SBML_l2v4" name="22" time="0.243"/>
<test suite="SBML_l2v4" name="23" time="0.247"/>
<test suite="SBML_l2v4" name="24" time="0.249"/>
<test suite="SBML_l2v4" name="25" time="0.199"/>
<test suite="SBML_l2v4" name="26" time="0.258"/>
<test suite="SBML_l2v4" name="27" time="0.236"/>
<test suite="SBML_l2v4" name="28" time="0.231"/>
<test suite="SBML_l2v4" name="29" time="166.702"/>
<test suite="SBML_l2v4" name="30" time="108.012"/>
<test suite="SBML_l2v4" name="31" time="0.184"/>
<test suite="SBML_l2v4" name="889" time="0.245"/>
<test suite="SBML_l2v4" name="890" time="0.249"/>
<test suite="SBML_l2v4" name="891" time="0.229"/>
<test suite="SBML_l2v4" name="892" time="0.221"/>
<test suite="SBML_l2v4" name="893" time="0.232"/>
<test suite="SBML_l2v4" name="894" time="0.241"/>
<test suite="SBML_l2v4" name="895" time="0.262"/>
<test suite="SBML_l2v4" name="896" time="0.249"/>
 */

/**
 * The original test suite used for Valgrind testing
 */
SUITE(SBML_TEST_SUITE_VG1)
{
    {"l2v4", 15},
    {"l2v4", 16},
    {"l2v4", 17},
    {"l2v4", 18},
    {"l2v4", 19},
    {"l2v4", 20},
    {"l2v4", 21},
    {"l2v4", 22},
    {"l2v4", 23},
    {"l2v4", 24},
    {"l2v4", 25},
    {"l2v4", 26},
    {"l2v4", 27},
    {"l2v4", 29},
    {"l2v4", 30},
    {"l2v4", 31},
    {"l2v4", 889},
    {"l2v4", 890},
    {"l2v4", 891},
    {"l2v4", 892},
    {"l2v4", 893},
    {"l2v4", 894},
    {"l2v4", 895},
    {"l2v4", 896},
}

/**
 * another suite with more rate rules
 */
SUITE(SBML_TEST_SUITE_VG2)
{
    {"l2v4", 17},
    {"l2v4", 32},
    {"l2v4", 86},
    {"l2v4", 165},
    {"l2v4", 889},
    {"l3v1", 1046 },

}

#endif










