using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocalGovts",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Aba North", 1 },
                    { 512, "Epe", 25 },
                    { 513, "Eti Osa", 25 },
                    { 514, "Ibeju-Lekki", 25 },
                    { 515, "Ifako-Ijaiye", 25 },
                    { 516, "Ikeja", 25 },
                    { 517, "Ikorodu", 25 },
                    { 518, "Kosofe", 25 },
                    { 519, "Lagos Island", 25 },
                    { 520, "Lagos Mainland", 25 },
                    { 511, "Badagry", 25 },
                    { 521, "Mushin", 25 },
                    { 523, "Oshodi-Isolo", 25 },
                    { 524, "Shomolu", 25 },
                    { 525, "Surulere, Lagos State", 25 },
                    { 526, "Akwanga", 26 },
                    { 527, "Awe", 26 },
                    { 528, "Doma", 26 },
                    { 529, "Karu", 26 },
                    { 530, "Keana", 26 },
                    { 531, "Keffi", 26 },
                    { 522, "Ojo", 25 },
                    { 532, "Kokona", 26 },
                    { 510, "Apapa", 25 },
                    { 508, "Alimosho", 25 },
                    { 488, "Yagba East", 23 },
                    { 489, "Yagba West", 23 },
                    { 490, "Asa", 24 },
                    { 491, "Baruten", 24 },
                    { 492, "Edu", 24 },
                    { 493, "Ekiti, Kwara State", 24 },
                    { 494, "Ifelodun", 24 },
                    { 495, "Ilorin East", 24 },
                    { 496, "Ilorin South", 24 },
                    { 509, "Amuwo-Odofin", 25 },
                    { 497, "Ilorin West", 24 },
                    { 499, "Isin", 24 },
                    { 500, "Kaiama", 24 },
                    { 501, "Moro", 24 },
                    { 502, "Offa", 24 },
                    { 503, "Oke Ero", 24 },
                    { 504, "Oyun", 24 },
                    { 505, "Pategi", 24 },
                    { 506, "Agege", 25 },
                    { 507, "Ajeromi-Ifelodun", 25 },
                    { 498, "Irepodun", 24 },
                    { 533, "Lafia", 26 },
                    { 534, "Nasarawa", 26 },
                    { 535, "Nasarawa Egon", 26 },
                    { 561, "Suleja", 27 },
                    { 562, "Tafa", 27 },
                    { 563, "Wushishi", 27 },
                    { 564, "Abeokuta North", 28 },
                    { 565, "Abeokuta South", 28 },
                    { 566, "Ado-Odo/Ota", 28 },
                    { 567, "Egbado North", 28 },
                    { 568, "Egbado South", 28 },
                    { 569, "Ewekoro", 28 },
                    { 560, "Shiroro", 27 },
                    { 570, "Ifo", 28 },
                    { 572, "Ijebu North", 28 },
                    { 573, "Ijebu North East", 28 },
                    { 574, "Ijebu Ode", 28 },
                    { 575, "Ikenne", 28 },
                    { 576, "Imeko Afon", 28 },
                    { 577, "Ipokia", 28 },
                    { 578, "Obafemi Owode", 28 },
                    { 579, "Odeda", 28 },
                    { 580, "Odogbolu", 28 },
                    { 571, "Ijebu East", 28 },
                    { 559, "Rijau", 27 },
                    { 558, "Rafi", 27 },
                    { 557, "Paikoro", 27 },
                    { 536, "Obi", 26 },
                    { 537, "Toto", 26 },
                    { 538, "Wamba", 26 },
                    { 539, "Agaie", 27 },
                    { 540, "Agwara", 27 },
                    { 541, "Bida", 27 },
                    { 542, "Borgu", 27 },
                    { 543, "Bosso", 27 },
                    { 544, "Chanchaga", 27 },
                    { 545, "Edati", 27 },
                    { 546, "Gbako", 27 },
                    { 547, "Gurara", 27 },
                    { 548, "Katcha", 27 },
                    { 549, "Kontagora", 27 },
                    { 550, "Lapai", 27 },
                    { 551, "Lavun", 27 },
                    { 552, "Magama", 27 },
                    { 553, "Mariga", 27 },
                    { 554, "Mashegu", 27 },
                    { 555, "Mokwa", 27 },
                    { 556, "Moya", 27 },
                    { 487, "Omala", 23 },
                    { 581, "Ogun Waterside", 28 },
                    { 486, "Olamaboro", 23 },
                    { 484, "Okehi", 23 },
                    { 415, "Batagarawa", 21 },
                    { 416, "Batsari", 21 },
                    { 417, "Baure", 21 },
                    { 418, "Bindawa", 21 },
                    { 419, "Charanchi", 21 },
                    { 420, "Dandume", 21 },
                    { 421, "Danja", 21 },
                    { 422, "Dan Musa", 21 },
                    { 423, "Daura", 21 },
                    { 414, "Bakori", 21 },
                    { 424, "Dutsi", 21 },
                    { 426, "Faskari", 21 },
                    { 427, "Funtua", 21 },
                    { 428, "Ingawa", 21 },
                    { 429, "Jibia", 21 },
                    { 430, "Kafur", 21 },
                    { 431, "Kaita", 21 },
                    { 432, "Kankara", 21 },
                    { 433, "Kankia", 21 },
                    { 434, "Katsina", 21 },
                    { 425, "Dutsin Ma", 21 },
                    { 435, "Kurfi", 21 },
                    { 413, "Wudil", 20 },
                    { 411, "Ungogo", 20 },
                    { 390, "Kano Municipal", 20 },
                    { 391, "Karaye", 20 },
                    { 392, "Kibiya", 20 },
                    { 393, "Kiru", 20 },
                    { 394, "Kumbotso", 20 },
                    { 395, "Kunchi", 20 },
                    { 396, "Kura", 20 },
                    { 397, "Madobi", 20 },
                    { 398, "Makoda", 20 },
                    { 412, "Warawa", 20 },
                    { 399, "Minjibir", 20 },
                    { 401, "Rano", 20 },
                    { 402, "Rimin Gado", 20 },
                    { 403, "Rogo", 20 },
                    { 404, "Shanono", 20 },
                    { 405, "Sumaila", 20 },
                    { 407, "Tarauni", 20 },
                    { 408, "Tofa", 20 },
                    { 409, "Tsanyawa", 20 },
                    { 410, "Tudun Wada", 20 },
                    { 400, "Nasarawa", 20 },
                    { 436, "Kusada", 21 },
                    { 437, "Mai''Adua", 21 },
                    { 438, "Malumfashi", 21 },
                    { 464, "Shanga", 22 },
                    { 465, "Suru", 22 },
                    { 466, "Wasagu/Danko", 22 },
                    { 467, "Yauri", 22 },
                    { 468, "Zuru", 22 },
                    { 469, "Adavi", 23 },
                    { 470, "Ajaokuta", 23 },
                    { 471, "Ankpa", 23 },
                    { 472, "Bassa", 23 },
                    { 463, "Sakaba", 22 },
                    { 473, "Dekina", 23 },
                    { 475, "Idah", 23 },
                    { 476, "Igalamela Odolu", 23 },
                    { 477, "Ijumu", 23 },
                    { 478, "Kabba/Bunu", 23 },
                    { 479, "Kogi", 23 },
                    { 480, "Lokoja", 23 },
                    { 481, "Mopa Muro", 23 },
                    { 482, "Ofu", 23 },
                    { 483, "Ogori/Magongo", 23 },
                    { 474, "Ibaji", 23 },
                    { 462, "Ngaski", 22 },
                    { 461, "Maiyama", 22 },
                    { 460, "Koko/Besse", 22 },
                    { 439, "Mani", 21 },
                    { 440, "Mashi", 21 },
                    { 441, "Matazu", 21 },
                    { 442, "Musawa", 21 },
                    { 443, "Rimi", 21 },
                    { 444, "Sabuwa", 21 },
                    { 445, "Safana", 21 },
                    { 446, "Sandamu", 21 },
                    { 447, "Zango", 21 },
                    { 448, "Aleiro", 22 },
                    { 449, "Arewa Dandi", 22 },
                    { 450, "Argungu", 22 },
                    { 451, "Augie", 22 },
                    { 452, "Bagudo", 22 },
                    { 453, "Birnin Kebbi", 22 },
                    { 454, "Bunza", 22 },
                    { 455, "Dandi", 22 },
                    { 456, "Fakai", 22 },
                    { 457, "Gwandu", 22 },
                    { 458, "Jega", 22 },
                    { 459, "Kalgo", 22 },
                    { 485, "Okene", 23 },
                    { 389, "Kabo", 20 },
                    { 582, "Remo North", 28 },
                    { 584, "Akoko North-East", 29 },
                    { 706, "Bodinga", 34 },
                    { 707, "Dange Shuni", 34 },
                    { 708, "Gada", 34 },
                    { 709, "Goronyo", 34 },
                    { 710, "Gudu", 34 },
                    { 711, "Gwadabawa", 34 },
                    { 712, "Illela", 34 },
                    { 713, "Isa", 34 },
                    { 714, "Kebbe", 34 },
                    { 705, "Binji", 34 },
                    { 715, "Kware", 34 },
                    { 717, "Sabon Birni", 34 },
                    { 718, "Shagari", 34 },
                    { 719, "Silame", 34 },
                    { 720, "Sokoto North", 34 },
                    { 721, "Sokoto South", 34 },
                    { 722, "Tambuwal", 34 },
                    { 723, "Tangaza", 34 },
                    { 724, "Tureta", 34 },
                    { 725, "Wamako", 34 },
                    { 716, "Rabah", 34 },
                    { 726, "Wurno", 34 },
                    { 704, "Tai", 33 },
                    { 702, "Oyigbo", 33 },
                    { 682, "Abua/Odual", 33 },
                    { 683, "Ahoada East", 33 },
                    { 684, "Ahoada West", 33 },
                    { 685, "Akuku-Toru", 33 },
                    { 686, "Andoni", 33 },
                    { 687, "Asari-Toru", 33 },
                    { 688, "Bonny", 33 },
                    { 689, "Degema", 33 },
                    { 690, "Eleme", 33 },
                    { 703, "Port Harcourt", 33 },
                    { 691, "Emuoha", 33 },
                    { 693, "Gokana", 33 },
                    { 694, "Ikwerre", 33 },
                    { 695, "Khana", 33 },
                    { 696, "Obio/Akpor", 33 },
                    { 697, "Ogba/Egbema/Ndoni", 33 },
                    { 698, "Ogu/Bolo", 33 },
                    { 699, "Okrika", 33 },
                    { 700, "Omuma", 33 },
                    { 701, "Opobo/Nkoro", 33 },
                    { 692, "Etche", 33 },
                    { 727, "Yabo", 34 },
                    { 728, "Ardo Kola", 35 },
                    { 729, "Bali", 35 },
                    { 755, "Nangere", 36 },
                    { 756, "Nguru", 36 },
                    { 757, "Potiskum", 36 },
                    { 758, "Tarmuwa", 36 },
                    { 759, "Yunusari", 36 },
                    { 760, "Yusufari", 36 },
                    { 761, "Anka", 37 },
                    { 762, "Bakura", 37 },
                    { 763, "Birnin Magaji/Kiyaw", 37 },
                    { 754, "Machina", 36 },
                    { 764, "Bukkuyum", 37 },
                    { 766, "Gummi", 37 },
                    { 767, "Gusau", 37 },
                    { 768, "Kaura Namoda", 37 },
                    { 769, "Maradun", 37 },
                    { 770, "Maru", 37 },
                    { 771, "Shinkafi", 37 },
                    { 772, "Talata Mafara", 37 },
                    { 773, "Chafe", 37 },
                    { 774, "Zurmi", 37 },
                    { 765, "Bungudu", 37 },
                    { 753, "Karasuwa", 36 },
                    { 752, "Jakusko", 36 },
                    { 751, "Gulani", 36 },
                    { 730, "Donga", 35 },
                    { 731, "Gashaka", 35 },
                    { 732, "Gassol", 35 },
                    { 733, "Ibi", 35 },
                    { 734, "Jalingo", 35 },
                    { 735, "Karim Lamido", 35 },
                    { 736, "Kumi", 35 },
                    { 737, "Lau", 35 },
                    { 738, "Sardauna", 35 },
                    { 739, "Takum", 35 },
                    { 740, "Ussa", 35 },
                    { 741, "Wukari", 35 },
                    { 742, "Yorro", 35 },
                    { 743, "Zing", 35 },
                    { 744, "Bade", 36 },
                    { 745, "Bursari", 36 },
                    { 746, "Damaturu", 36 },
                    { 747, "Fika", 36 },
                    { 748, "Fune", 36 },
                    { 749, "Geidam", 36 },
                    { 750, "Gujba", 36 },
                    { 681, "Wase", 32 },
                    { 583, "Shagamu", 28 },
                    { 680, "Shendam", 32 },
                    { 678, "Qua''an Pan", 32 },
                    { 609, "Ede South", 30 },
                    { 610, "Ife Central", 30 },
                    { 611, "Ife East", 30 },
                    { 612, "Ife North", 30 },
                    { 613, "Ife South", 30 },
                    { 614, "Egbedore", 30 },
                    { 615, "Ejigbo", 30 },
                    { 616, "Ifedayo", 30 },
                    { 617, "Ifelodun", 30 },
                    { 608, "Ede North", 30 },
                    { 618, "Ila", 30 },
                    { 620, "Ilesa West", 30 },
                    { 621, "Irepodun", 30 },
                    { 622, "Irewole", 30 },
                    { 623, "Isokan", 30 },
                    { 624, "Iwo", 30 },
                    { 625, "Obokun", 30 },
                    { 626, "Odo Otin", 30 },
                    { 627, "Ola Oluwa", 30 },
                    { 628, "Olorunda", 30 },
                    { 619, "Ilesa East", 30 },
                    { 629, "Oriade", 30 },
                    { 607, "Boripe", 30 },
                    { 605, "Aiyedire", 30 },
                    { 585, "Akoko North-West", 29 },
                    { 586, "Akoko South-West", 29 },
                    { 587, "Akoko South-East", 29 },
                    { 588, "Akure North", 29 },
                    { 589, "Akure South", 29 },
                    { 590, "Ese Odo", 29 },
                    { 591, "Idanre", 29 },
                    { 592, "Ifedore", 29 },
                    { 593, "Ilaje", 29 },
                    { 606, "Boluwaduro", 30 },
                    { 594, "Ile Oluji/Okeigbo", 29 },
                    { 596, "Odigbo", 29 },
                    { 597, "Okitipupa", 29 },
                    { 598, "Ondo East", 29 },
                    { 599, "Ondo West", 29 },
                    { 600, "Ose", 29 },
                    { 601, "Owo", 29 },
                    { 602, "Atakunmosa East", 30 },
                    { 603, "Atakunmosa West", 30 },
                    { 604, "Aiyedaade", 30 },
                    { 595, "Irele", 29 },
                    { 630, "Orolu", 30 },
                    { 631, "Osogbo", 30 },
                    { 632, "Afijio", 31 },
                    { 658, "Orelope", 31 },
                    { 659, "Ori Ire", 31 },
                    { 660, "Oyo", 31 },
                    { 661, "Oyo East", 31 },
                    { 662, "Saki East", 31 },
                    { 663, "Saki West", 31 },
                    { 664, "Surulere, Oyo State", 31 },
                    { 665, "Bokkos", 32 },
                    { 666, "Barkin Ladi", 32 },
                    { 657, "Ona Ara", 31 },
                    { 667, "Bassa", 32 },
                    { 669, "Jos North", 32 },
                    { 670, "Jos South", 32 },
                    { 671, "Kanam", 32 },
                    { 672, "Kanke", 32 },
                    { 673, "Langtang South", 32 },
                    { 674, "Langtang North", 32 },
                    { 675, "Mangu", 32 },
                    { 676, "Mikang", 32 },
                    { 677, "Pankshin", 32 },
                    { 668, "Jos East", 32 },
                    { 656, "Oluyole", 31 },
                    { 655, "Olorunsogo", 31 },
                    { 654, "Ogo Oluwa", 31 },
                    { 633, "Akinyele", 31 },
                    { 634, "Atiba", 31 },
                    { 635, "Atisbo", 31 },
                    { 636, "Egbeda", 31 },
                    { 637, "Ibadan North", 31 },
                    { 638, "Ibadan North-East", 31 },
                    { 639, "Ibadan North-West", 31 },
                    { 640, "Ibadan South-East", 31 },
                    { 641, "Ibadan South-West", 31 },
                    { 642, "Ibarapa Central", 31 },
                    { 643, "Ibarapa East", 31 },
                    { 644, "Ibarapa North", 31 },
                    { 645, "Ido", 31 },
                    { 646, "Irepo", 31 },
                    { 647, "Iseyin", 31 },
                    { 648, "Itesiwaju", 31 },
                    { 649, "Iwajowa", 31 },
                    { 650, "Kajola", 31 },
                    { 651, "Lagelu", 31 },
                    { 652, "Ogbomosho North", 31 },
                    { 653, "Ogbomosho South", 31 },
                    { 679, "Riyom", 32 },
                    { 388, "Gwarzo", 20 },
                    { 406, "Takai", 20 },
                    { 386, "Gezawa", 20 },
                    { 123, "Gboko", 7 },
                    { 124, "Guma", 7 },
                    { 125, "Gwer East", 7 },
                    { 126, "Gwer West", 7 },
                    { 127, "Katsina-Ala", 7 },
                    { 128, "Konshisha", 7 },
                    { 129, "Kwande", 7 },
                    { 130, "Logo", 7 },
                    { 131, "Makurdi", 7 },
                    { 122, "Buruku", 7 },
                    { 132, "Obi", 7 },
                    { 134, "Ohimini", 7 },
                    { 135, "Oju", 7 },
                    { 136, "Okpokwu", 7 },
                    { 137, "Oturkpo", 7 },
                    { 138, "Tarka", 7 },
                    { 139, "Ukum", 7 },
                    { 140, "Ushongo", 7 },
                    { 141, "Vandeikya", 7 },
                    { 142, "Abadam", 8 },
                    { 133, "Ogbadibo", 7 },
                    { 143, "Askira/Uba", 8 },
                    { 121, "Ado", 7 },
                    { 119, "Agatu", 7 },
                    { 99, "Giade", 5 },
                    { 100, "Itas/Gadau", 5 },
                    { 101, "Jama''are", 5 },
                    { 102, "Katagum", 5 },
                    { 103, "Kirfi", 5 },
                    { 104, "Misau", 5 },
                    { 105, "Ningi", 5 },
                    { 106, "Shira", 5 },
                    { 107, "Tafawa Balewa", 5 },
                    { 120, "Apa", 7 },
                    { 108, "Toro", 5 },
                    { 110, "Zaki", 5 },
                    { 111, "Brass", 6 },
                    { 112, "Ekeremor", 6 },
                    { 113, "Kolokuma/Opokuma", 6 },
                    { 114, "Nembe", 6 },
                    { 115, "Ogbia", 6 },
                    { 116, "Sagbama", 6 },
                    { 117, "Southern Ijaw", 6 },
                    { 118, "Yenagoa", 6 },
                    { 109, "Warji", 5 },
                    { 144, "Bama", 8 },
                    { 145, "Bayo", 8 },
                    { 146, "Biu", 8 },
                    { 172, "Bakassi", 9 },
                    { 173, "Bekwarra", 9 },
                    { 174, "Biase", 9 },
                    { 175, "Boki", 9 },
                    { 387, "Gwale", 20 },
                    { 177, "Calabar South", 9 },
                    { 178, "Etung", 9 },
                    { 179, "Ikom", 9 },
                    { 180, "Obanliku", 9 },
                    { 171, "Akpabuyo", 9 },
                    { 181, "Obubra", 9 },
                    { 183, "Odukpani", 9 },
                    { 184, "Ogoja", 9 },
                    { 185, "Yakuur", 9 },
                    { 186, "Yala", 9 },
                    { 187, "Aniocha North", 10 },
                    { 188, "Aniocha South", 10 },
                    { 189, "Bomadi", 10 },
                    { 190, "Burutu", 10 },
                    { 191, "Ethiope East", 10 },
                    { 182, "Obudu", 9 },
                    { 170, "Akamkpa", 9 },
                    { 169, "Abi", 9 },
                    { 168, "Shani", 8 },
                    { 147, "Chibok", 8 },
                    { 148, "Damboa", 8 },
                    { 149, "Dikwa", 8 },
                    { 150, "Gubio", 8 },
                    { 151, "Guzamala", 8 },
                    { 152, "Gwoza", 8 },
                    { 153, "Hawul", 8 },
                    { 154, "Jere", 8 },
                    { 155, "Kaga", 8 },
                    { 156, "Kala/Balge", 8 },
                    { 157, "Konduga", 8 },
                    { 158, "Kukawa", 8 },
                    { 159, "Kwaya Kusar", 8 },
                    { 160, "Mafa", 8 },
                    { 161, "Magumeri", 8 },
                    { 162, "Maiduguri", 8 },
                    { 163, "Marte", 8 },
                    { 164, "Mobbar", 8 },
                    { 165, "Monguno", 8 },
                    { 166, "Ngala", 8 },
                    { 167, "Nganzai", 8 },
                    { 98, "Ganjuwa", 5 },
                    { 192, "Ethiope West", 10 },
                    { 97, "Gamawa", 5 },
                    { 95, "Darazo", 5 },
                    { 26, "Larmurde", 2 },
                    { 27, "Madagali", 2 },
                    { 28, "Maiha", 2 },
                    { 29, "Mayo Belwa", 2 },
                    { 30, "Michika", 2 },
                    { 31, "Mubi North", 2 },
                    { 32, "Mubi South", 2 },
                    { 33, "Numan", 2 },
                    { 34, "Shelleng", 2 },
                    { 25, "Jada", 2 },
                    { 35, "Song", 2 },
                    { 37, "Yola North", 2 },
                    { 38, "Yola South", 2 },
                    { 39, "Abak", 3 },
                    { 40, "Eastern Obolo", 3 },
                    { 41, "Eket", 3 },
                    { 42, "Esit Eket", 3 },
                    { 43, "Essien Udim", 3 },
                    { 44, "Etim Ekpo", 3 },
                    { 45, "Etinan", 3 },
                    { 36, "Toungo", 2 },
                    { 46, "Ibeno", 3 },
                    { 24, "Hong", 2 },
                    { 22, "Gombi", 2 },
                    { 2, "Aba South", 1 },
                    { 3, "Arochukwu", 1 },
                    { 4, "Bende", 1 },
                    { 5, "Ikwuano", 1 },
                    { 6, "Isiala Ngwa North", 1 },
                    { 7, "Isiala Ngwa South", 1 },
                    { 8, "Isuikwuato", 1 },
                    { 9, "Obi Ngwa", 1 },
                    { 10, "Ohafia", 1 },
                    { 23, "Grie", 2 },
                    { 11, "Osisioma", 1 },
                    { 13, "Ukwa East", 1 },
                    { 14, "Ukwa West", 1 },
                    { 15, "Umuahia North", 1 },
                    { 16, "Umuahia South", 1 },
                    { 17, "Umu Nneochi", 1 },
                    { 18, "Demsa", 2 },
                    { 19, "Fufure", 2 },
                    { 20, "Ganye", 2 },
                    { 21, "Gayuk", 2 },
                    { 12, "Ugwunagbo", 1 },
                    { 47, "Ibesikpo Asutan", 3 },
                    { 48, "Ibiono-Ibom", 3 },
                    { 49, "Ika", 3 },
                    { 75, "Awka South", 4 },
                    { 76, "Ayamelum", 4 },
                    { 77, "Dunukofia", 4 },
                    { 78, "Ekwusigo", 4 },
                    { 79, "Idemili North", 4 },
                    { 80, "Idemili South", 4 },
                    { 81, "Ihiala", 4 },
                    { 82, "Njikoka", 4 },
                    { 83, "Nnewi North", 4 },
                    { 74, "Awka North", 4 },
                    { 84, "Nnewi South", 4 },
                    { 86, "Onitsha North", 4 },
                    { 87, "Onitsha South", 4 },
                    { 88, "Orumba North", 4 },
                    { 89, "Orumba South", 4 },
                    { 90, "Oyi", 4 },
                    { 91, "Alkaleri", 5 },
                    { 92, "Bauchi", 5 },
                    { 93, "Bogoro", 5 },
                    { 94, "Damban", 5 },
                    { 85, "Ogbaru", 4 },
                    { 73, "Anaocha", 4 },
                    { 72, "Anambra West", 4 },
                    { 71, "Anambra East", 4 },
                    { 50, "Ikono", 3 },
                    { 51, "Ikot Abasi", 3 },
                    { 52, "Ikot Ekpene", 3 },
                    { 53, "Ini", 3 },
                    { 54, "Itu", 3 },
                    { 55, "Mbo", 3 },
                    { 56, "Mkpat-Enin", 3 },
                    { 57, "Nsit-Atai", 3 },
                    { 58, "Nsit-Ibom", 3 },
                    { 59, "Nsit-Ubium", 3 },
                    { 60, "Obot Akara", 3 },
                    { 61, "Okobo", 3 },
                    { 62, "Onna", 3 },
                    { 63, "Oron", 3 },
                    { 64, "Oruk Anam", 3 },
                    { 65, "Udung-Uko", 3 },
                    { 66, "Ukanafun", 3 },
                    { 67, "Uruan", 3 },
                    { 68, "Urue-Offong/Oruko", 3 },
                    { 69, "Uyo", 3 },
                    { 70, "Aguata", 4 },
                    { 96, "Dass", 5 },
                    { 193, "Ika North East", 10 },
                    { 176, "Calabar Municipal", 9 },
                    { 195, "Isoko North", 10 },
                    { 317, "Owerri North", 17 },
                    { 318, "Owerri West", 17 },
                    { 319, "Unuimo", 17 },
                    { 320, "Auyo", 18 },
                    { 321, "Babura", 18 },
                    { 322, "Biriniwa", 18 },
                    { 323, "Birnin Kudu", 18 },
                    { 324, "Buji", 18 },
                    { 325, "Dutse", 18 },
                    { 316, "Owerri Municipal", 17 },
                    { 326, "Gagarawa", 18 },
                    { 328, "Gumel", 18 },
                    { 329, "Guri", 18 },
                    { 330, "Gwaram", 18 },
                    { 331, "Gwiwa", 18 },
                    { 332, "Hadejia", 18 },
                    { 333, "Jahun", 18 },
                    { 334, "Kafin Hausa", 18 },
                    { 335, "Kazaure", 18 },
                    { 336, "Kiri Kasama", 18 },
                    { 327, "Garki", 18 },
                    { 337, "Kiyawa", 18 },
                    { 315, "Oru West", 17 },
                    { 313, "Orsu", 17 },
                    { 293, "Aboh Mbaise", 17 },
                    { 294, "Ahiazu Mbaise", 17 },
                    { 295, "Ehime Mbano", 17 },
                    { 296, "Ezinihitte", 17 },
                    { 297, "Ideato North", 17 },
                    { 298, "Ideato South", 17 },
                    { 299, "Ihitte/Uboma", 17 },
                    { 300, "Ikeduru", 17 },
                    { 301, "Isiala Mbano", 17 },
                    { 314, "Oru East", 17 },
                    { 302, "Isu", 17 },
                    { 304, "Ngor Okpala", 17 },
                    { 305, "Njaba", 17 },
                    { 306, "Nkwerre", 17 },
                    { 307, "Nwangele", 17 },
                    { 308, "Obowo", 17 },
                    { 194, "Ika South", 10 },
                    { 310, "Ohaji/Egbema", 17 },
                    { 311, "Okigwe", 17 },
                    { 312, "Orlu", 17 },
                    { 303, "Mbaitoli", 17 },
                    { 338, "Kaugama", 18 },
                    { 339, "Maigatari", 18 },
                    { 340, "Malam Madori", 18 },
                    { 366, "Sanga", 19 },
                    { 367, "Soba", 19 },
                    { 368, "Zangon Kataf", 19 },
                    { 369, "Zaria", 19 },
                    { 370, "Ajingi", 20 },
                    { 371, "Albasu", 20 },
                    { 372, "Bagwai", 20 },
                    { 373, "Bebeji", 20 },
                    { 374, "Bichi", 20 },
                    { 365, "Sabon Gari", 19 },
                    { 375, "Bunkure", 20 },
                    { 377, "Dambatta", 20 },
                    { 378, "Dawakin Kudu", 20 },
                    { 379, "Dawakin Tofa", 20 },
                    { 380, "Doguwa", 20 },
                    { 381, "Fagge", 20 },
                    { 382, "Gabasawa", 20 },
                    { 383, "Garko", 20 },
                    { 384, "Garun Mallam", 20 },
                    { 385, "Gaya", 20 },
                    { 376, "Dala", 20 },
                    { 364, "Makarfi", 19 },
                    { 363, "Lere", 19 },
                    { 362, "Kudan", 19 },
                    { 341, "Miga", 18 },
                    { 342, "Ringim", 18 },
                    { 343, "Roni", 18 },
                    { 344, "Sule Tankarkar", 18 },
                    { 345, "Taura", 18 },
                    { 346, "Yankwashi", 18 },
                    { 347, "Birnin Gwari", 19 },
                    { 348, "Chikun", 19 },
                    { 349, "Giwa", 19 },
                    { 350, "Igabi", 19 },
                    { 351, "Ikara", 19 },
                    { 352, "Jaba", 19 },
                    { 353, "Jema''a", 19 },
                    { 354, "Kachia", 19 },
                    { 355, "Kaduna North", 19 },
                    { 356, "Kaduna South", 19 },
                    { 357, "Kagarko", 19 },
                    { 358, "Kajuru", 19 },
                    { 359, "Kaura", 19 },
                    { 360, "Kauru", 19 },
                    { 361, "Kubau", 19 },
                    { 292, "Yamaltu/Deba", 16 },
                    { 291, "Shongom", 16 },
                    { 309, "Oguta", 17 },
                    { 289, "Kwami", 16 },
                    { 220, "Ivo", 11 },
                    { 221, "Izzi", 11 },
                    { 222, "Ohaozara", 11 },
                    { 223, "Ohaukwu", 11 },
                    { 290, "Nafada", 16 },
                    { 225, "Akoko-Edo", 12 },
                    { 226, "Egor", 12 },
                    { 227, "Esan Central", 12 },
                    { 228, "Esan North-East", 12 },
                    { 219, "Ishielu", 11 },
                    { 229, "Esan South-East", 12 },
                    { 231, "Etsako Central", 12 },
                    { 232, "Etsako East", 12 },
                    { 233, "Etsako West", 12 },
                    { 234, "Igueben", 12 },
                    { 235, "Ikpoba Okha", 12 },
                    { 236, "Orhionmwon", 12 },
                    { 237, "Oredo", 12 },
                    { 238, "Ovia North-East", 12 }
                });

            migrationBuilder.InsertData(
                table: "LocalGovts",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[,]
                {
                    { 239, "Ovia South-West", 12 },
                    { 230, "Esan West", 12 },
                    { 240, "Owan East", 12 },
                    { 218, "Ikwo", 11 },
                    { 216, "Ezza North", 11 },
                    { 196, "Isoko South", 10 },
                    { 197, "Ndokwa East", 10 },
                    { 198, "Ndokwa West", 10 },
                    { 199, "Okpe", 10 },
                    { 200, "Oshimili North", 10 },
                    { 201, "Oshimili South", 10 },
                    { 202, "Patani", 10 },
                    { 203, "Sapele, Delta", 10 },
                    { 204, "Udu", 10 },
                    { 217, "Ezza South", 11 },
                    { 205, "Ughelli North", 10 },
                    { 207, "Ukwuani", 10 },
                    { 208, "Uvwie", 10 },
                    { 209, "Warri North", 10 },
                    { 210, "Warri South", 10 },
                    { 211, "Warri South West", 10 },
                    { 212, "Abakaliki", 11 },
                    { 213, "Afikpo North", 11 },
                    { 214, "Afikpo South", 11 },
                    { 215, "Ebonyi", 11 },
                    { 206, "Ughelli South", 10 },
                    { 241, "Owan West", 12 },
                    { 224, "Onicha", 11 },
                    { 243, "Ado Ekiti", 13 },
                    { 269, "Nkanu East", 14 },
                    { 270, "Nkanu West", 14 },
                    { 271, "Nsukka", 14 },
                    { 272, "Oji River", 14 },
                    { 273, "Udenu", 14 },
                    { 274, "Udi", 14 },
                    { 275, "Uzo Uwani", 14 },
                    { 276, "Abaji", 15 },
                    { 277, "Bwari", 15 },
                    { 268, "Isi Uzo", 14 },
                    { 278, "Gwagwalada", 15 },
                    { 280, "Kwali", 15 },
                    { 281, "Municipal Area Council", 15 },
                    { 282, "Akko", 16 },
                    { 242, "Uhunmwonde", 12 },
                    { 284, "Billiri", 16 },
                    { 285, "Dukku", 16 },
                    { 286, "Funakaye", 16 },
                    { 287, "Gombe", 16 },
                    { 288, "Kaltungo", 16 },
                    { 279, "Kuje", 15 },
                    { 267, "Igbo Eze South", 14 },
                    { 283, "Balanga", 16 },
                    { 265, "Igbo Etiti", 14 },
                    { 266, "Igbo Eze North", 14 },
                    { 244, "Efon", 13 },
                    { 245, "Ekiti East", 13 },
                    { 246, "Ekiti South-West", 13 },
                    { 248, "Emure", 13 },
                    { 249, "Gbonyin", 13 },
                    { 250, "Ido Osi", 13 },
                    { 251, "Ijero", 13 },
                    { 252, "Ikere", 13 },
                    { 253, "Ikole", 13 },
                    { 254, "Ilejemeje", 13 },
                    { 247, "Ekiti West", 13 },
                    { 256, "Ise/Orun", 13 },
                    { 255, "Irepodun/Ifelodun", 13 },
                    { 263, "Enugu South", 14 },
                    { 261, "Enugu East", 14 },
                    { 260, "Awgu", 14 },
                    { 262, "Enugu North", 14 },
                    { 259, "Aninri", 14 },
                    { 258, "Oye", 13 },
                    { 257, "Moba", 13 },
                    { 264, "Ezeagu", 14 }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 22, "Kebbi" },
                    { 27, "Niger" },
                    { 23, "Kogi" },
                    { 24, "Kwara" },
                    { 25, "Lagos" },
                    { 26, "Nasarawa" },
                    { 21, "Katsina" },
                    { 31, "Oyo" },
                    { 29, "Ondo" },
                    { 30, "Osun" },
                    { 32, "Plateau" },
                    { 33, "Rivers" },
                    { 34, "Sokoto" },
                    { 20, "Kano" },
                    { 35, "Taraba" },
                    { 28, "Ogun" },
                    { 19, "Kaduna" },
                    { 7, "Benue" },
                    { 17, "Imo" },
                    { 36, "Yobe" },
                    { 1, "Abia" },
                    { 2, "Adamawa" },
                    { 3, "Akwa Ibom" },
                    { 4, "Anambra" },
                    { 5, "Bauchi" },
                    { 6, "Bayelsa" },
                    { 18, "Jigawa" },
                    { 8, "Borno" },
                    { 10, "Delta" },
                    { 11, "Ebonyi" },
                    { 12, "Edo" },
                    { 13, "Ekiti" },
                    { 14, "Enugu" },
                    { 15, "FCT" },
                    { 16, "Gombe" },
                    { 9, "Cross River" },
                    { 37, "Zamfara" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "LocalGovts",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
