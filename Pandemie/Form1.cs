//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                   PROJET C# 2020 : PainDeMie Simulateur                                  ////
////                                  DUT GEII / IUT SAINT ÉTIENNE JEAN MONNET                                ////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                        PENSÉ, CODÉ & DESIGNÉ PAR YANNIS GUIRONNET & JULIEN MUGUET                        ////
////      ETUDIANT EN CITISE 2, CLASSE PRÉPARATOIRE INTÉGRÉE DE L'ÉCOLE D'INGÉNIEUR TÉLÉCOM SAINT ÉTIENNE     ////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                REPRODUCTION NON CONTRACTUELLE DE PANDÉMIE                                ////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////
////               LIBRAIRY               ////
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

//////////////////////////////////////////////
////            CORPS DU CODE             ////
//////////////////////////////////////////////

namespace Pandemie

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DateTime date_time = DateTime.Today;
        Maladie PainDeMie = new Maladie();

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////                              DÉFINITION D'UNE ZONE SOUS LA FORME SUIVANTE :                              ////
        ////                            Zone nom = new Zone(nb_habitants, "nom", "climat");                           ////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Point[] usa =
        {

        new Point( 117 , 224),
        new Point( 106 , 213),
        new Point( 106 , 187),
        new Point( 137 , 155),
        new Point( 228 , 155),
        new Point( 240 , 161),
        new Point( 260 , 166),
        new Point( 272 , 172),
        new Point( 281 , 175),
        new Point( 285 , 170),
        new Point( 304 , 169),
        new Point( 312 , 165),
        new Point( 317 , 166),
        new Point( 318 , 170),
        new Point( 249 , 228),
        new Point( 248 , 254),
        new Point( 241 , 252),
        new Point( 238 , 234),
        new Point( 199 , 232),
        new Point( 184 , 255),
        new Point( 174 , 237),
        new Point( 161 , 237),
        new Point( 158 , 230),


        };
        Zone Usa = new Zone(330252000, "USA", 0);
        Point[] oce =
        {
            new Point( 946 , 503),
            new Point( 950 , 493),
            new Point( 951 , 459),
            new Point( 981 , 446),
            new Point( 1003 , 419),
            new Point( 1017 , 424),
            new Point( 1022 , 413),
            new Point( 1042 , 411),
            new Point( 1039 , 423),
            new Point( 1055 , 434),
            new Point( 1064 , 423),
            new Point( 1066 , 411),
            new Point( 1076 , 391),
            new Point( 1076 , 383),
            new Point( 1036 , 374),
            new Point( 1059 , 362),
            new Point( 1111 , 383),
            new Point( 1129 , 370),
            new Point( 1137 , 375),
            new Point( 1111 , 388),
            new Point( 1123 , 401),
            new Point( 1123 , 403),
            new Point( 1108 , 400),
            new Point( 1104 , 393),
            new Point( 1096 , 398),
            new Point( 1077 , 393),
            new Point( 1074 , 413),
            new Point( 1078 , 438),
            new Point( 1097 , 466),
            new Point( 1153 , 509),
            new Point( 1161 , 521),
            new Point( 1110 , 558),
            new Point( 1100 , 551),
            new Point( 1150 , 520),
            new Point( 1151 , 508),
            new Point( 1096 , 465),
            new Point( 1096 , 486),
            new Point( 1061 , 522),
            new Point( 1030 , 519),
            new Point( 1028 , 501),
            new Point( 1017 , 505),
            new Point( 1009 , 497),
            new Point( 950 , 509),
            new Point( 947 , 505),

        };
        Zone Oce = new Zone(42350000, "Océanie", 1, "sud");
        Point[] afr_sud =
        {
            new Point( 598 , 388),
            new Point( 610 , 388),
            new Point( 611 , 392),
            new Point( 620 , 394),
            new Point( 624 , 389),
            new Point( 629 , 388),
            new Point( 630 , 399),
            new Point( 659 , 415),
            new Point( 660 , 409),
            new Point( 655 , 407),
            new Point( 657 , 396),
            new Point( 670 , 395),
            new Point( 655 , 375),
            new Point( 663 , 362),
            new Point( 676 , 363),
            new Point( 695 , 375),
            new Point( 701 , 425),
            new Point( 713 , 432),
            new Point( 734 , 413),
            new Point( 740 , 413),
            new Point( 724 , 464),
            new Point( 713 , 464),
            new Point( 709 , 455),
            new Point( 713 , 433),
            new Point( 701 , 426),
            new Point( 681 , 442),
            new Point( 680 , 462),
            new Point( 673 , 468),
            new Point( 671 , 476),
            new Point( 646 , 503),
            new Point( 615 , 502),
            new Point( 589 , 434),
            new Point( 588 , 424),
            new Point( 595 , 416),
            new Point( 597 , 386),
            new Point( 609 , 387),

        };
        Zone Afr_sud = new Zone(266520000, "Afrique du Sud", 1, "sud");
        Point[] afr_sub =
        {
            new Point( 535 , 338),
            new Point( 513 , 345),
            new Point( 482 , 310),
            new Point( 482 , 264),
            new Point( 521 , 213),
            new Point( 543 , 212),
            new Point( 560 , 206),
            new Point( 589 , 207),
            new Point( 587 , 219),
            new Point( 602 , 224),
            new Point( 607 , 228),
            new Point( 620 , 231),
            new Point( 625 , 222),
            new Point( 673 , 230),
            new Point( 678 , 239),
            new Point( 677 , 242),
            new Point( 668 , 237),
            new Point( 682 , 262),
            new Point( 678 , 265),
            new Point( 638 , 266),
            new Point( 637 , 278),
            new Point( 613 , 264),
            new Point( 603 , 264),
            new Point( 608 , 284),
            new Point( 599 , 304),
            new Point( 563 , 304),
            new Point( 560 , 310),
            new Point( 546 , 316),
            new Point( 535 , 315),
            new Point( 534 , 337),

        };
        Zone Afr_sub = new Zone(622905000, "Afrique du Nord", 2);
        Point[] afr_cen =
        {
            new Point( 535 , 339),
            new Point( 535 , 316),
            new Point( 560 , 309),
            new Point( 560 , 304),
            new Point( 599 , 303),
            new Point( 608 , 288),
            new Point( 604 , 265),
            new Point( 611 , 263),
            new Point( 636 , 279),
            new Point( 639 , 267),
            new Point( 675 , 266),
            new Point( 681 , 263),
            new Point( 683 , 263),
            new Point( 715 , 316),
            new Point( 743 , 313),
            new Point( 746 , 321),
            new Point( 697 , 377),
            new Point( 677 , 363),
            new Point( 660 , 361),
            new Point( 656 , 376),
            new Point( 668 , 394),
            new Point( 657 , 397),
            new Point( 654 , 406),
            new Point( 662 , 411),
            new Point( 658 , 414),
            new Point( 632 , 402),
            new Point( 630 , 388),
            new Point( 622 , 387),
            new Point( 621 , 394),
            new Point( 614 , 394),
            new Point( 610 , 387),
            new Point( 598 , 388),
            new Point( 584 , 369),
            new Point( 581 , 368),
            new Point( 582 , 342),
            new Point( 569 , 341),
            new Point( 567 , 336),
            new Point( 556 , 332),
            new Point( 535 , 337),
            new Point( 535 , 316),
            new Point( 544 , 317),

        };
        Zone Afr_cen = new Zone(325256000, "Afrique centrale", 2);
        Point[] ala =
        {
            new Point( 131 , 124),
            new Point( 138 , 119),
            new Point( 134 , 114),
            new Point( 129 , 114),
            new Point( 126 , 109),
            new Point( 161 , 77),
            new Point( 155 , 71),
            new Point( 109 , 71),
            new Point( 90 , 79),
            new Point( 89 , 87),
            new Point( 69 , 87),
            new Point( 49 , 115),
            new Point( 58 , 116),
            new Point( 41 , 126),
            new Point( 48 , 130),
            new Point( 81 , 113),
            new Point( 121 , 112),
            new Point( 132 , 124),

        };
        Zone Ala = new Zone(737000, "Alaska", -2);
        Point[] ame_cen =
        {
            new Point( 131 , 264),
            new Point( 119 , 241),
            new Point( 118 , 224),
            new Point( 156 , 228),
            new Point( 161 , 236),
            new Point( 172 , 236),
            new Point( 180 , 255),
            new Point( 174 , 263),
            new Point( 183 , 281),
            new Point( 199 , 280),
            new Point( 206 , 269),
            new Point( 214 , 272),
            new Point( 234 , 261),
            new Point( 244 , 261),
            new Point( 296 , 281),
            new Point( 250 , 287),
            new Point( 231 , 266),
            new Point( 216 , 270),
            new Point( 217 , 278),
            new Point( 211 , 292),
            new Point( 227 , 293),
            new Point( 229 , 315),
            new Point( 234 , 319),
            new Point( 247 , 317),
            new Point( 250 , 321),
            new Point( 260 , 311),
            new Point( 287 , 311),
            new Point( 308 , 319),
            new Point( 313 , 324),
            new Point( 310 , 338),
            new Point( 298 , 344),
            new Point( 299 , 353),
            new Point( 291 , 357),
            new Point( 286 , 351),
            new Point( 277 , 352),
            new Point( 276 , 373),
            new Point( 258 , 363),
            new Point( 244 , 381),
            new Point( 234 , 378),
            new Point( 233 , 363),
            new Point( 241 , 352),
            new Point( 246 , 347),
            new Point( 246 , 331),
            new Point( 240 , 327),
            new Point( 237 , 329),
            new Point( 224 , 326),
            new Point( 211 , 308),
            new Point( 151 , 282),
            new Point( 131 , 240),
            new Point( 129 , 241),
            new Point( 136 , 258),
            new Point( 132 , 263),



        };
        Zone Ame_cen = new Zone(315135000, "Amérique centrale", 2);
        Point[] ame_sud =
        {
            new Point( 233 , 377),
            new Point( 243 , 380),
            new Point( 256 , 364),
            new Point( 277 , 374),
            new Point( 277 , 351),
            new Point( 286 , 351),
            new Point( 289 , 355),
            new Point( 299 , 353),
            new Point( 298 , 344),
            new Point( 314 , 323),
            new Point( 324 , 332),
            new Point( 343 , 335),
            new Point( 352 , 354),
            new Point( 361 , 360),
            new Point( 374 , 363),
            new Point( 377 , 371),
            new Point( 392 , 369),
            new Point( 412 , 385),
            new Point( 413 , 395),
            new Point( 402 , 409),
            new Point( 397 , 449),
            new Point( 370 , 461),
            new Point( 366 , 477),
            new Point( 349 , 507),
            new Point( 337 , 505),
            new Point( 346 , 519),
            new Point( 322 , 532),
            new Point( 323 , 577),
            new Point( 326 , 580),
            new Point( 340 , 588),
            new Point( 326 , 588),
            new Point( 321 , 585),
            new Point( 324 , 581),
            new Point( 321 , 579),
            new Point( 312 , 577),
            new Point( 294 , 555),
            new Point( 293 , 539),
            new Point( 285 , 532),
            new Point( 279 , 439),
            new Point( 258 , 425),
            new Point( 232 , 381),
            new Point( 233 , 378),

        };
        Zone Ame_sud = new Zone(326459000, "Amérique latine", 0, "sud");
        Point[] asi_oue =
        {
            new Point( 709 , 147),
            new Point( 752 , 147),
            new Point( 752 , 138),
            new Point( 775 , 131),
            new Point( 838 , 152),
            new Point( 845 , 157),
            new Point( 827 , 171),
            new Point( 830 , 184),
            new Point( 814 , 193),
            new Point( 817 , 205),
            new Point( 838 , 213),
            new Point( 839 , 228),
            new Point( 886 , 245),
            new Point( 895 , 238),
            new Point( 908 , 243),
            new Point( 902 , 250),
            new Point( 899 , 276),
            new Point( 884 , 265),
            new Point( 855 , 297),
            new Point( 853 , 318),
            new Point( 840 , 323),
            new Point( 820 , 270),
            new Point( 817 , 273),
            new Point( 808 , 269),
            new Point( 809 , 266),
            new Point( 797 , 256),
            new Point( 775 , 255),
            new Point( 780 , 246),
            new Point( 769 , 218),
            new Point( 770 , 212),
            new Point( 767 , 206),
            new Point( 753 , 200),
            new Point( 742 , 201),
            new Point( 743 , 192),
            new Point( 727 , 179),
            new Point( 725 , 171),
            new Point( 732 , 166),
            new Point( 729 , 163),
            new Point( 717 , 166),
            new Point( 710 , 161),
            new Point( 710 , 147),
            new Point( 750 , 146),

        };
        Zone Asi_oue = new Zone(1837648000, "Asie du Sud-Ouest", 0);
        Point[] asi_est =
        {
            new Point( 813 , 192),
            new Point( 830 , 187),
            new Point( 827 , 171),
            new Point( 858 , 148),
            new Point( 875 , 152),
            new Point( 881 , 142),
            new Point( 920 , 153),
            new Point( 944 , 155),
            new Point( 949 , 152),
            new Point( 946 , 138),
            new Point( 963 , 136),
            new Point( 982 , 154),
            new Point( 1006 , 160),
            new Point( 1007 , 182),
            new Point( 1041 , 185),
            new Point( 1035 , 169),
            new Point( 1015 , 140),
            new Point( 1018 , 138),
            new Point( 1037 , 155),
            new Point( 1053 , 178),
            new Point( 1045 , 187),
            new Point( 1052 , 190),
            new Point( 1055 , 209),
            new Point( 1048 , 213),
            new Point( 1042 , 214),
            new Point( 1044 , 217),
            new Point( 1037 , 218),
            new Point( 1029 , 224),
            new Point( 1022 , 220),
            new Point( 1025 , 211),
            new Point( 1041 , 207),
            new Point( 1044 , 196),
            new Point( 1042 , 187),
            new Point( 1007 , 182),
            new Point( 1009 , 193),
            new Point( 1001 , 194),
            new Point( 1017 , 206),
            new Point( 1012 , 215),
            new Point( 1007 , 213),
            new Point( 1003 , 204),
            new Point( 994 , 201),
            new Point( 993 , 194),
            new Point( 984 , 196),
            new Point( 978 , 189),
            new Point( 971 , 197),
            new Point( 976 , 203),
            new Point( 990 , 202),
            new Point( 982 , 211),
            new Point( 999 , 241),
            new Point( 1005 , 258),
            new Point( 1003 , 264),
            new Point( 997 , 260),
            new Point( 1001 , 256),
            new Point( 998 , 241),
            new Point( 988 , 262),
            new Point( 959 , 272),
            new Point( 966 , 276),
            new Point( 966 , 281),
            new Point( 962 , 283),
            new Point( 957 , 281),
            new Point( 960 , 270),
            new Point( 950 , 275),
            new Point( 949 , 283),
            new Point( 964 , 299),
            new Point( 963 , 313),
            new Point( 949 , 322),
            new Point( 948 , 316),
            new Point( 940 , 316),
            new Point( 930 , 304),
            new Point( 929 , 319),
            new Point( 949 , 351),
            new Point( 948 , 354),
            new Point( 935 , 346),
            new Point( 929 , 332),
            new Point( 920 , 326),
            new Point( 918 , 299),
            new Point( 916 , 290),
            new Point( 910 , 293),
            new Point( 907 , 293),
            new Point( 903 , 282),
            new Point( 899 , 278),
            new Point( 902 , 250),
            new Point( 909 , 245),
            new Point( 897 , 238),
            new Point( 888 , 246),
            new Point( 838 , 229),
            new Point( 836 , 214),
            new Point( 819 , 205),
            new Point( 814 , 192),
            new Point( 830 , 186),
            new Point( 830 , 186),
            new Point( 913 , 337),
            new Point( 947 , 385),
            new Point( 987 , 398),
            new Point( 1006 , 403),
            new Point( 1034 , 397),
            new Point( 1016 , 378),
            new Point( 1019 , 367),
            new Point( 1038 , 360),
            new Point( 1044 , 348),
            new Point( 1012 , 284),
            new Point( 1005 , 282),
            new Point( 1003 , 295),
            new Point( 1011 , 306),
            new Point( 997 , 317),
            new Point( 1000 , 332),
            new Point( 991 , 333),
            new Point( 986 , 342),
            new Point( 968 , 352),
            new Point( 966 , 364),
            new Point( 972 , 371),
            new Point( 974 , 385),
            new Point( 959 , 385),
            new Point( 954 , 371),
            new Point( 927 , 342),
            new Point( 913 , 337),
            new Point( 831 , 186),

        };
        Zone Asi_est = new Zone(2234174000, "Asie de l'Est", 0);
        Point[] can =
        {
            new Point( 137 , 154),
            new Point( 129 , 146),
            new Point( 131 , 126),
            new Point( 138 , 119),
            new Point( 125 , 109),
            new Point( 161 , 76),
            new Point( 216 , 75),
            new Point( 245 , 86),
            new Point( 220 , 75),
            new Point( 238 , 58),
            new Point( 324 , 51),
            new Point( 353 , 35),
            new Point( 408 , 33),
            new Point( 355 , 54),
            new Point( 348 , 55),
            new Point( 373 , 90),
            new Point( 356 , 111),
            new Point( 360 , 132),
            new Point( 372 , 135),
            new Point( 371 , 158),
            new Point( 318 , 159),
            new Point( 332 , 154),
            new Point( 333 , 156),
            new Point( 328 , 163),
            new Point( 343 , 168),
            new Point( 324 , 178),
            new Point( 319 , 173),
            new Point( 319 , 166),
            new Point( 312 , 165),
            new Point( 306 , 169),
            new Point( 287 , 170),
            new Point( 281 , 177),
            new Point( 273 , 173),
            new Point( 270 , 167),
            new Point( 265 , 167),
            new Point( 262 , 165),
            new Point( 258 , 157),
            new Point( 242 , 162),
            new Point( 232 , 156),

        };
        Zone Can = new Zone(37590000, "Canada", -1);
        Point[] eur_est =
        {
            new Point( 601 , 148),
            new Point( 599 , 134),
            new Point( 611 , 131),
            new Point( 620 , 132),
            new Point( 621 , 119),
            new Point( 626 , 122),
            new Point( 627 , 121),
            new Point( 625 , 116),
            new Point( 625 , 114),
            new Point( 638 , 112),
            new Point( 641 , 128),
            new Point( 649 , 128),
            new Point( 657 , 138),
            new Point( 653 , 141),
            new Point( 685 , 155),
            new Point( 680 , 164),
            new Point( 668 , 166),
            new Point( 672 , 171),
            new Point( 666 , 172),
            new Point( 664 , 169),
            new Point( 652 , 168),
            new Point( 647 , 183),
            new Point( 651 , 190),
            new Point( 635 , 190),
            new Point( 629 , 194),
            new Point( 632 , 202),
            new Point( 627 , 207),
            new Point( 614 , 185),
            new Point( 608 , 182),
            new Point( 600 , 171),
            new Point( 604 , 165),
            new Point( 609 , 160),
            new Point( 605 , 155),
            new Point( 609 , 152),
            new Point( 600 , 148),
            new Point( 599 , 135),
            new Point( 611 , 131),
            new Point( 619 , 131),
            new Point( 620 , 120),

        };
        Zone Eur_est = new Zone(410842000, "Europe de l'Est", 0);
        Point[] eur_oue =
        {
            new Point( 517 , 178),
            new Point( 543 , 175),
            new Point( 543 , 165),
            new Point( 535 , 159),
            new Point( 537 , 156),
            new Point( 542 , 157),
            new Point( 539 , 151),
            new Point( 532 , 151),
            new Point( 517 , 146),
            new Point( 519 , 136),
            new Point( 526 , 131),
            new Point( 533 , 131),
            new Point( 536 , 119),
            new Point( 542 , 120),
            new Point( 549 , 136),
            new Point( 556 , 140),
            new Point( 552 , 149),
            new Point( 545 , 154),
            new Point( 578 , 134),
            new Point( 577 , 128),
            new Point( 580 , 120),
            new Point( 586 , 121),
            new Point( 586 , 127),
            new Point( 590 , 126),
            new Point( 593 , 133),
            new Point( 600 , 134),
            new Point( 600 , 147),
            new Point( 609 , 152),
            new Point( 605 , 154),
            new Point( 610 , 160),
            new Point( 604 , 163),
            new Point( 604 , 168),
            new Point( 599 , 171),
            new Point( 593 , 172),
            new Point( 612 , 190),
            new Point( 609 , 193),
            new Point( 605 , 200),
            new Point( 602 , 215),
            new Point( 595 , 210),
            new Point( 591 , 199),
            new Point( 603 , 200),
            new Point( 603 , 193),
            new Point( 584 , 175),
            new Point( 579 , 177),
            new Point( 582 , 196),
            new Point( 578 , 198),
            new Point( 577 , 182),
            new Point( 562 , 181),
            new Point( 558 , 186),
            new Point( 563 , 194),
            new Point( 559 , 197),
            new Point( 557 , 186),
            new Point( 540 , 206),
            new Point( 522 , 206),
            new Point( 517 , 198),

        };
        Zone Eur_oue = new Zone(386204000, "Europe de l'Ouest", 0);
        Point[] gro =
        {
            new Point( 403 , 87),
            new Point( 414 , 81),
            new Point( 416 , 68),
            new Point( 406 , 58),
            new Point( 384 , 56),
            new Point( 383 , 50),
            new Point( 420 , 36),
            new Point( 462 , 37),
            new Point( 491 , 32),
            new Point( 527 , 37),
            new Point( 523 , 41),
            new Point( 512 , 42),
            new Point( 493 , 77),
            new Point( 511 , 86),
            new Point( 516 , 93),
            new Point( 503 , 99),
            new Point( 485 , 95),
            new Point( 494 , 89),
            new Point( 510 , 87),
            new Point( 492 , 80),
            new Point( 466 , 82),
            new Point( 460 , 88),
            new Point( 435 , 96),
            new Point( 424 , 110),
            new Point( 413 , 109),
            new Point( 403 , 102),
            new Point( 402 , 88),
            new Point( 415 , 82),
            new Point( 414 , 70),
            new Point( 410 , 59),
            new Point( 385 , 56),
            new Point( 383 , 51),

        };
        Zone Gro = new Zone(420000, "Groënland", -2);
        Point[] moy =
        {
            new Point( 641 , 195),
            new Point( 647 , 206),
            new Point( 666 , 207),
            new Point( 663 , 214),
            new Point( 670 , 215),
            new Point( 673 , 207),
            new Point( 679 , 208),
            new Point( 672 , 229),
            new Point( 706 , 291),
            new Point( 712 , 308),
            new Point( 753 , 288),
            new Point( 772 , 267),
            new Point( 757 , 253),
            new Point( 751 , 260),
            new Point( 744 , 253),
            new Point( 735 , 249),
            new Point( 725 , 233),
            new Point( 733 , 236),
            new Point( 743 , 247),
            new Point( 773 , 255),
            new Point( 776 , 256),
            new Point( 781 , 247),
            new Point( 776 , 240),
            new Point( 767 , 216),
            new Point( 771 , 210),
            new Point( 767 , 205),
            new Point( 753 , 199),
            new Point( 742 , 202),
            new Point( 741 , 205),
            new Point( 731 , 204),
            new Point( 718 , 186),
            new Point( 701 , 180),
            new Point( 694 , 180),
            new Point( 693 , 190),
            new Point( 655 , 188),
            new Point( 649 , 192),
            new Point( 640 , 191),
            new Point( 647 , 204),

        };
        Zone Moy = new Zone(409371000, "Moyen-Orient", 2);
        Point[] nor =
        {
            new Point( 568 , 107),
            new Point( 613 , 75),
            new Point( 642 , 73),
            new Point( 635 , 74),
            new Point( 648 , 102),
            new Point( 639 , 111),
            new Point( 628 , 111),
            new Point( 618 , 107),
            new Point( 625 , 92),
            new Point( 621 , 91),
            new Point( 606 , 105),
            new Point( 613 , 114),
            new Point( 597 , 127),
            new Point( 588 , 117),
            new Point( 572 , 118),
            new Point( 568 , 108),
        };
        Zone Nor = new Zone(18001000, "Pays Nordiques", -1);
        Point[] rus =
        {
            new Point( 639 , 112),
            new Point( 648 , 101),
            new Point( 634 , 73),
            new Point( 640 , 71),
            new Point( 673 , 81),
            new Point( 668 , 87),
            new Point( 651 , 88),
            new Point( 656 , 99),
            new Point( 700 , 81),
            new Point( 745 , 78),
            new Point( 743 , 66),
            new Point( 754 , 66),
            new Point( 759 , 71),
            new Point( 799 , 52),
            new Point( 845 , 52),
            new Point( 848 , 62),
            new Point( 899 , 61),
            new Point( 907 , 69),
            new Point( 929 , 69),
            new Point( 936 , 61),
            new Point( 965 , 68),
            new Point( 969 , 74),
            new Point( 1048 , 75),
            new Point( 1100 , 86),
            new Point( 1106 , 93),
            new Point( 1079 , 92),
            new Point( 1077 , 95),
            new Point( 1091 , 101),
            new Point( 1089 , 103),
            new Point( 1063 , 114),
            new Point( 1071 , 124),
            new Point( 1071 , 144),
            new Point( 1048 , 127),
            new Point( 1047 , 114),
            new Point( 1027 , 115),
            new Point( 995 , 117),
            new Point( 990 , 135),
            new Point( 1007 , 134),
            new Point( 1025 , 155),
            new Point( 1024 , 171),
            new Point( 1018 , 176),
            new Point( 1008 , 179),
            new Point( 1007 , 164),
            new Point( 982 , 155),
            new Point( 965 , 137),
            new Point( 946 , 139),
            new Point( 949 , 151),
            new Point( 921 , 153),
            new Point( 881 , 143),
            new Point( 874 , 154),
            new Point( 859 , 149),
            new Point( 844 , 157),
            new Point( 836 , 152),
            new Point( 777 , 131),
            new Point( 752 , 139),
            new Point( 752 , 144),
            new Point( 710 , 146),
            new Point( 710 , 158),
            new Point( 716 , 166),
            new Point( 720 , 185),
            new Point( 693 , 180),
            new Point( 678 , 173),
            new Point( 679 , 166),
            new Point( 685 , 166),
            new Point( 681 , 163),
            new Point( 684 , 154),
            new Point( 653 , 140),
            new Point( 655 , 139),
            new Point( 650 , 130),
            new Point( 640 , 127),

        };
        Zone Rus = new Zone(144500000, "Russie", -1);

        Zone Actual = new Zone(1); // La zone Actual permet d'afficher les info du pays sur lequel le curseur est.
        Zone Monde = new Zone(7705312952, "Monde", 10);

        //////////////////////////////////////////////
        ////     CRÉATION DE LA LISTE DE PAYS     ////
        //////////////////////////////////////////////

        List<Zone> AllPays = new List<Zone>();
        List<Point> Morts = new List<Point>();

        bool start = false;
        bool maladie = false;
        bool cap1 = true; bool cap10 = true; bool cap50 = true; bool cap100 = true;
        int day_count = 0;
        int day = 1;
        int changement = 0;
        double pourcentage_mond;

        Timer t = new Timer();
        Random rand = new Random();
        
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 20;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            //////////////////////////////////////////////
            ////        AJOUT DES PAYS UN A UN        ////
            //////////////////////////////////////////////
            AllPays.Add(Usa); Usa.hitbox = usa;          
            AllPays.Add(Oce); Oce.hitbox = oce;
            AllPays.Add(Afr_sud); Afr_sud.hitbox = afr_sud;
            AllPays.Add(Afr_sub);  Afr_sub.hitbox = afr_sub;
            AllPays.Add(Afr_cen); Afr_cen.hitbox = afr_cen;
            AllPays.Add(Ala);  Ala.hitbox = ala;
            AllPays.Add(Ame_cen);  Ame_cen.hitbox = ame_cen;
            AllPays.Add(Ame_sud); Ame_sud.hitbox = ame_sud;
            AllPays.Add(Asi_oue); Asi_oue.hitbox = asi_oue;
            AllPays.Add(Asi_est); Asi_est.hitbox = asi_est;
            AllPays.Add(Can);  Can.hitbox = can;
            AllPays.Add(Eur_est); Eur_est.hitbox = eur_est;
            AllPays.Add(Eur_oue); Eur_oue.hitbox = eur_oue;
            AllPays.Add(Gro);  Gro.hitbox = gro;
            AllPays.Add(Moy);  Moy.hitbox = moy;
            AllPays.Add(Nor); Nor.hitbox = nor;
            AllPays.Add(Rus); Rus.hitbox = rus;

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////          CETTE PARTIE PERMET DE DÉFINIR TOUT LES CONTACTS (VOISINS) ENTRE LES RÉGIONS DU MONDE           ////
            ////                                  CONTACTS TERRESTRES, MARITIMES & AÉRIENS                                ////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Voisins Alaska
            Ala.Voisins.Add(Can); //terrestre
            Ala.Voisins_mar.Add(Rus);  //maritime & aérien
            
            //Voisins Groënland
            Gro.Voisins_mar.Add(Can); Gro.Voisins_mar.Add(Nor); //maritime & aérien

            //Voisins Canada
            Can.Voisins.Add(Ala); Can.Voisins.Add(Usa); //terrestre
            Can.Voisins_mar.Add(Gro); //maritime & aérien

            //Voisins USA
            Usa.Voisins.Add(Can); Usa.Voisins.Add(Ame_cen); //terrestre
            Usa.Voisins_mar.Add(Eur_oue); Usa.Voisins_mar.Add(Asi_est); //maritime & aérien

            //Voisins Amérique centrale
            Ame_cen.Voisins.Add(Usa); Ame_cen.Voisins.Add(Ame_sud); //terrestre

            //Voisins Amérique du Sud 
            Ame_sud.Voisins.Add(Ame_cen); //terrestre
            Ame_sud.Voisins_mar.Add(Eur_oue); //maritime & aérien

            //Voisins Afrique du sud
            Afr_sud.Voisins.Add(Afr_cen); //terrestre

            //Voisins Afrique centrale
            Afr_cen.Voisins.Add(Afr_sud); Afr_cen.Voisins.Add(Afr_sub); //terrestre

            //Voisins Afrique Subsaharienne
            Afr_sub.Voisins.Add(Afr_cen); Afr_sub.Voisins.Add(Moy); //terrestre
            Afr_sub.Voisins_mar.Add(Eur_oue);  //maritime & aérien

            //Voisins Europe Ouest
            Eur_oue.Voisins.Add(Eur_est); //terrestre
            Eur_oue.Voisins_mar.Add(Usa); Eur_oue.Voisins_mar.Add(Afr_sub); //maritime & aérien
            Eur_oue.Voisins_mar.Add(Ame_sud); Eur_oue.Voisins_mar.Add(Asi_est); //maritime & aérien

            //Voisins Europe Est                              
            Eur_est.Voisins.Add(Eur_oue); Eur_est.Voisins.Add(Rus); //terrestre

            //Voisins Pays du Nord
            Nor.Voisins.Add(Rus); //terrestre
            Nor.Voisins_mar.Add(Gro); //maritime & aérien

            //Voisins Russie
            Rus.Voisins.Add(Asi_est); Rus.Voisins.Add(Asi_oue); Rus.Voisins.Add(Nor); Rus.Voisins.Add(Moy); //terrestre
            Rus.Voisins_mar.Add(Ala); //maritime & aérien

            //Voisins Moyen Orient
            Moy.Voisins.Add(Asi_oue); Moy.Voisins.Add(Rus); Moy.Voisins.Add(Afr_sub); //terrestre

            //Voisins Asie du Sud Ouest
            Asi_oue.Voisins.Add(Rus); Asi_oue.Voisins.Add(Asi_est); Asi_oue.Voisins.Add(Moy); //terrestre

            //Voisins Asie du Sud Est
            Asi_est.Voisins.Add(Rus); Asi_est.Voisins.Add(Asi_oue); //terrestre
            Asi_est.Voisins_mar.Add(Eur_oue); Asi_est.Voisins_mar.Add(Usa); Asi_est.Voisins_mar.Add(Oce); //maritime & aérien

            //Voisins Océanie
            Oce.Voisins.Add(Asi_est);//maritime
            Oce.Voisins_mar.Add(Asi_est); //maritime & aérien

            //Pour lock certains panneaux
            panel4.Location = new Point(0,0) ;
            panel5.Location = new Point(27, 27); //Menu Mutations
            panel7.Location = new Point(27, 27); //Climats
            panel14.Location = new Point(27, 27); //Recherche
            panel16.Location = new Point(27, 27); //Symptômes
            panel18.Location = new Point(27, 27); //Développement
            panel20.Location = new Point(27, 27); //Transmissions
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////          ON VÉRIFIE A CHAQUE TICK CERTAINES CONDITIONS ET ON ACTUALISE CERTAINES VARIABLES               ////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void t_Tick(object sender, EventArgs e)
        {

            Point p = this.PointToClient(Control.MousePosition);
            p.X = p.X - 100;
            day_count++;
            
            //////////////////////////////////////////////
            ////            MENU PRINCIPAL            ////
            //////////////////////////////////////////////

            if (!maladie)
            {
                if (PainDeMie.type == 0 || textBox1.Text == "")
                {
                    button1.Text = "Selectionnez votre maladie et son nom";
                    button1.ForeColor = Color.Black;
                }
                else
                {
                    button1.Text = "Cliquez ici pour commencer";
                    button1.ForeColor = Color.Crimson;
                    button1.BackColor = Color.LightCoral;

                }
            }
            //////////////////////////////////////////////
            ////        DÉBUT DE LA SIMULATION        ////
            //////////////////////////////////////////////
            if (maladie)
            {
                if(!start)
                {
                    textBox2.Location = new Point(30, 40);
                    textBox2.Font = new Font("OCR A Extended", 16);
                    textBox2.Size = new Size(1600,100); 
                    textBox2.Text = "Choisissez un pays de départ";

                }
                else
                {
                    Monde.habs = 0;
                    Monde.nb_guéris = 0;
                    Monde.nb_morts = 0;
                    Monde.nb_malades = 0;
                    

                    foreach (Zone zone in AllPays)
                    {
                        //////////////////////////////////////////
                        /////////     PARTIE REFRESH     /////////
                        //////////////////////////////////////////
                        
                        zone.Refresh_Tick(day_count, date_time);
                        Monde.habs += zone.habs;
                        Monde.nb_guéris += zone.nb_guéris;
                        Monde.nb_morts += zone.nb_morts;
                        Monde.nb_malades += zone.nb_malades;
                        pourcentage_mond = 100.0*(Monde.nb_malades * 1.0 / Monde.habs * 1.0);
                    }

                    //////////////////////////////////////////////
                    ////          AFFICHAGE JOUR 1            ////
                    //////////////////////////////////////////////
                    if (day == 1)
                    {
                        textBox2.Text = "Jour " + day + " -- " + date_time.ToString("ddd dd MMMM yyyy");
                        textBox2.Location = new Point(3, 3);
                        textBox2.Font = new Font("OCR A Extended", 16);
                        textBox2.Size = new Size(428, 32);
                        panel8.Visible = true;
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ////         HORLOGE QUI AVANCE CHAQUE JOUR, ON EN PROFITE POUR FAIRE AVANCER LA MALADIE AU JOUR SUIVANT      ////
                    ////                                        AVANCE TOUT LES 24 TICKS                                          ////
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    
                    if (day_count == 24)
                    {
                        day_count = 0;
                        day++;
                        date_time = date_time.AddDays(1);
                        foreach (Zone zone in AllPays)
                        {
                            zone.Refresh_Day(PainDeMie, day_count, date_time, pourcentage_mond);
                        }
                        textBox2.Text = "Jour " + day + " -- " + date_time.ToString("ddd dd MMMM yyyy");

                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        ////         CETTE PARTIE PERMET D'AFFICHER DU TEXTE A GAUCHE AU FUR ET A MESURE DE L'AVANCEMENT              ////
                        ////                                           DE LA MALADIE                                                  ////
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        if (pourcentage_mond > 1 && cap1)
                        {
                            richTextBox2.Text += "\nJour " + day + " : 1% de la population mondiale est malade.";
                            cap1 = false;
                        }
                        if (pourcentage_mond > 10 && cap10)
                        {
                            richTextBox2.Text += "\nJour " + day + " : 10% de la population mondiale est malade.";
                            cap10 = false;
                        }
                        if (pourcentage_mond > 50 && cap50)
                        {
                            richTextBox2.Text += "\nJour " + day + " : 50% de la population mondiale est malade.";
                            cap50 = false;
                        }
                        if (pourcentage_mond > 100 && cap100)
                        {
                            richTextBox2.Text += "\nJour " + day + " : 100% de la population mondiale est malade.";
                            cap100 = false;
                        }
                    }
                }
                Cursor new_cursor;

                //////////////////////////////////////////////////////
                ///////////    AFFICHAGE RICHETEXTBOX1    ////////////
                //////////////////////////////////////////////////////

                if (Actual != Monde) //CURSEUR SUR UNE RÉGION
                {
                    richTextBox1.Text =
                     "--- " + Actual.nom + " ---" +
                    "\n" + Actual.habs.ToString("0,0") + " habitants" +
                    "\nMalades : " + Actual.nb_malades.ToString("0,0") +
                    "\nGuéris : " + Actual.nb_guéris.ToString("0,0") +              // + Actual.pourcentage.ToString("0.0000") +
                    "\nMorts : " + Actual.nb_morts.ToString("0,0") +
                    "\nClimat : " + Actual.Nom_Climat()+
                    "\nSaison : " + Actual.saison;
                }
                else                //CURSEUR HORS UNE RÉGION
                {
                    richTextBox1.Text =
                     "--- " + Actual.nom + " ---" +
                    "\n" + Actual.habs.ToString("0,0") + " habitants" +
                    "\nMalades : " + Actual.nb_malades.ToString("0,0") +
                    "\nGuéris : " + Actual.nb_guéris.ToString("0,0") +              // + Actual.pourcentage.ToString("0.0000") +
                    "\nMorts : " + Actual.nb_morts.ToString("0,0") +
                    "\nClimat : " + Actual.Nom_Climat() +
                    "\n% de malades : " + pourcentage_mond.ToString("0.0000");
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ////         VÉRIFICATION CURSEUR : SI DANS UN PAYS ALORS IL DEVIENT "ACTUAL" ET ON AFFICHE SES INFOS         ////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (PointIsInPolygon(usa, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.usa;
                    Actual = Usa;
                    panel3.Visible = true;
                    changement = 1;
                    

                }
                else if (PointIsInPolygon(can, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.canada;
                    Actual = Can;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(ala, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.alaska;
                    Actual = Ala;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(ame_cen, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.ame_centre;
                    Actual = Ame_cen;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(ame_sud, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.ame_sud;
                    Actual = Ame_sud;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(gro, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.groen;
                    Actual = Gro;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(afr_sub, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.afr_sub;
                    Actual = Afr_sub;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(afr_cen, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.afr_centre;
                    Actual = Afr_cen;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(afr_sud, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.afr_sud;
                    Actual = Afr_sud;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(oce, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.austra;
                    Actual = Oce;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(rus, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.urss;
                    Actual = Rus;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(nor, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.pays_nord;
                    Actual = Nor;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(asi_est, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.asie_est;
                    Actual = Asi_est;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(asi_oue, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.asie_ouest;
                    Actual = Asi_oue;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(moy, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.moy_ori;
                    Actual = Moy;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(eur_est, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.eur_est;
                    Actual = Eur_est;
                    panel3.Visible = true;
                    changement = 1;
                }
                else if (PointIsInPolygon(eur_oue, p))
                {
                    new_cursor = Cursors.Cross;
                    this.BackgroundImage = Resource1.eur_ouest;
                    Actual = Eur_oue;

                    panel3.Visible = true;
                    changement = 1;
                }
                else
                {
                    new_cursor = Cursors.Default;
                    this.BackgroundImage = Resource1.blank;
                    Actual = Monde;

                    panel3.Visible = true;

                    changement = 1;

                }
                if (this.Cursor != new_cursor) this.Cursor = new_cursor;
            }
            else richTextBox1.Visible = false;


            //////////////////////////////////////////////
            ////         BARRE DE PROGRESSION         ////
            //////////////////////////////////////////////
            if (changement == 1)
            {
                panel10.Width = Convert.ToInt32(Actual.nb_morts* 1.0 / Actual.habs_base * 1.0 * 392); //??????
                panel10.Location = new Point(0, 0);
                panel9.Width = Convert.ToInt32(Actual.nb_malades * 1.0 / Actual.habs_base * 1.0 * 392);
                panel9.Location = new Point(panel10.Width, 0);
                panel12.Width = Convert.ToInt32((Actual.habs_base * 1.0 - Actual.nb_malades * 1.0 - Actual.nb_morts * 1.0 - Actual.nb_guéris * 1.0) / Actual.habs_base * 1.0 * 392);
                panel12.Location = new Point(panel9.Width + panel10.Width, 0);
                panel11.Width = Convert.ToInt32(Actual.nb_guéris * 1.0 / Actual.habs_base * 1.0 * 392);
                panel11.Location = new Point(panel9.Width + panel12.Width + panel10.Width, 0);
                changement = 0;


            }
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //////////////////////////////////////////////
        ////            DÉBUT MALADIE             ////
        //////////////////////////////////////////////

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (maladie && !start && Actual!=Monde)
            {
                start = true;
                Actual.nb_malades = 5;
                day_count = 0;
                richTextBox2.Text = "* " + PainDeMie.nom_maladie + " "+ PainDeMie.nom + " a été lancé dans " + Actual.nom;
            }
        }

        HatchBrush Inside = new HatchBrush(HatchStyle.ZigZag, Color.Blue, Color.LightSkyBlue);

        //public object Mouse { get; private set; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Point m in Morts)
            {
                e.Graphics.FillRectangle(Brushes.Red, m.X+100, m.Y, 3, 3);
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        //////////////////////////////////////////////
        ////        FONCTION HITBOX RÉGION        ////
        //////////////////////////////////////////////

        private bool PointIsInPolygon(Point[] polygon, Point target_point)
        {
            // Make a GraphicsPath containing the polygon.
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(polygon);

            // See if the point is inside the path.
            return path.IsVisible(target_point);
        }

        Pen Contour = new Pen(Color.Crimson, 3);

        //////////////////////////////////////////////
        ////   LORSQUE L'ON CLIQUE SUR DÉMARRER   ////
        //////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            if (PainDeMie.type != 0 && textBox1.Text != "")
            {
                panel4.Visible = false;
                richTextBox1.Visible = true;
                maladie = true;
                PainDeMie.Init();
                PainDeMie.nom = textBox1.Text;

            }

        }

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //////////////////////////////////////////////
        ////         PANEL & TEXTBOX ZONE         ////
        //////////////////////////////////////////////

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawRectangle(Contour,
             e.ClipRectangle.Left,
             e.ClipRectangle.Top,
             e.ClipRectangle.Width - 1,
             e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PainDeMie.type = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PainDeMie.type = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PainDeMie.type = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool var = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (var)
            {
                panel5.Visible = true;
                var = false;
                button2.BackgroundImage = Resource1.adn_reverse;

            }
            else if (!var)
            {
                panel5.Visible = false;
                var = true;
                button2.BackgroundImage = Resource1.dna_icon_icons_com_48637;

            }

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
