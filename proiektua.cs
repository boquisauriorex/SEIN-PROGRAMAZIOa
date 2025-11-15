
namespace consoleApp1;

public class Proeiktua
{
    List<string> eskaerak = new List<string> {"Hautatu duzun janaria :"};
    public void Run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Ongi Etorri KEBAB PAKISTANI");
            Console.WriteLine("============================");
            Console.WriteLine("1.Eskera bat sortu");
            Console.WriteLine("2.Aurreko eskariak kontsultatu");
            Console.WriteLine("3.Irten programatik");

            Console.WriteLine("Aukeratu aukera bat: ");
            string? testua = Console.ReadLine();
            int menua = int.TryParse(testua, out int m) ? m : 0;

            switch (menua)
            {
                case 1:
                    Eskaerak();
                    break;
                case 2:
                    Eskaerak_ikusi();
                    break;
                case 3:
                    running = false;
                    ireten();
                    break;
                default:
                    Console.WriteLine("Aukera ez da zuzena, saiatu berriro");
                    break;
            }
        }   
    
        
    }
        public void Eskaerak()
    {

        List<string> janariak = new List<string> { "1.aragi kebab", "2.oilasko kebab", "3.patatak", "4.patatak aragiarekin", "5.Nuggets", "6.alitak", "7.falafel" };
        Console.WriteLine("Aukeratu janari bat:", '\n');
        for (int i = 0; i < janariak.Count; i++) // janaria zerertzen du
        {
            Console.WriteLine(janariak[i]); // janaria erakusten du
        }


        Console.WriteLine("Sartu zure aukera (1-7), edo 8 ateratzeko manu nagusira");  //hasten zara zure janaria aukeratzen 1-7 eta 8 ateratzen zara
        string? testua = Console.ReadLine();
        int aukera = testua != null ? int.Parse(testua) : 0;

        switch (aukera)
        {
            case 1:
                    Console.WriteLine("Aragi kebab hautatu duzu");
                    eskaerak.Add("1. Aragi kebab ");
                    menu();
                    break;
            case 2:
                    Console.WriteLine("Oilasko kebab hautatu duzu");
                    eskaerak.Add("1. Oilasko kebab");
                    menu();
                    break;
            case 3:
                    Console.WriteLine("patatak hautatu dituzu");
                    eskaerak.Add("1. Patatak ");
                    menu();
                    break;
            case 4:
                    Console.WriteLine("Patatak aragiarekin hautatu dituzu");
                    eskaerak.Add(" 1.Patatak aragiarekin ");
                    menu();
                    break;
                case 5:
                    Console.WriteLine("Nuggets hautatu dituzu");
                    eskaerak.Add("1. Nuggets ");
                    menu();
                    break;
                case 6:
                    Console.WriteLine("Alitak hautatu duzu");
                    eskaerak.Add("1. Alitak ");
                    menu();
                    break;
                case 7:
                    Console.WriteLine("Falafel hatatu duzu");
                    eskaerak.Add(" 1.Falafel ");
                    menu();
                    break;
                case 8:
                    Console.WriteLine(" menu nagusira aterako zara");
                    Run();
                    break;
                default:
                    Console.WriteLine("Aukera ez da zuzena, aukerartu janari bat dagoena sukaldean");
                    break;
        }

    }
    public void menu()
    {
        Console.WriteLine("Menua aukeratzen badauzu konplementu bat aukera izango duzu eskubidea. (- Menu handia: plater handia/ 7 pieza. - Menu txikia: plater txikia/ 4 pieza)");
        Console.WriteLine("Nahi duzu menua Bai/Ez:"); //galdetzen dizu menua nahi badazu ala ez
        string? erantzuna = Console.ReadLine();

        if (erantzuna == "Bai" || erantzuna == "bai")
        {
            Console.WriteLine("zein tamaina nahiko zenuke? Handia/Txikia"); //menuaren tamaina galdetzen dizu
            string? tamaina = Console.ReadLine();
            if (tamaina == "Handia" || tamaina == "handia")
            {
                Console.WriteLine("Orain edari Handiak erakutsiko dizut:");
                Edari_handiak(); //joango zara edari handien  menura
            }
            else
            {
                Console.WriteLine("Orain edari Txikiak erakutsiko dizut");
                Edari_txikiak();
            }
        }
        else
        {
            Console.WriteLine("Nahi duzu edaria {Bai}, aldatu zure janaria aldatu  {Aldatu}, Izozki bat nahi duzu {Izkozkia} ?  edo eskaria amaitzea {Amaitu}  "); //edaria nahi badadu ala ez
            string? hartu = Console.ReadLine();
            if (hartu == "Bai" || hartu == "bai")
            {
                Console.WriteLine("Orain edariak erakutsiko dizkizut");
                Edariak();
            }
            else if (hartu == "Aldatu" || hartu == "aldatu")
            {
                Console.WriteLine("Joango zara janari menura" + '\n');
                Eskaerak();
            }
            else if (hartu == "Izozkia" || hartu == "izozkia")
            {
                Console.WriteLine("Izozki menua erakutsiko dizut");
                Izozkiak();

            }
            else
            {
                Console.WriteLine("Zure eskaera bukatu duzu");
                Run();

            }
        }
    }
    public void Edariak()
    {

        List<string> edariak = new List<string> { "1.kokakola", "2.Sprite", "3.Fanta laranja", "4.Fanta limoia", "5.Nestea", "6.Bifrutas", "7.Ura" }; //lista barruan egongo diren aukeren edariak 
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < edariak.Count; i++) // edariak zerertzen du
        {
            Console.WriteLine(edariak[i]); // edariak erakusten du
        }

        Console.WriteLine("sartu nahi duzun edaria edaria baina aukera (1-7) edo 8 nahi duzu menu bat aplikatzea?");
        string? testu = Console.ReadLine();
        int auker = testu != null ? int.Parse(testu) : 0;

        switch (auker)
        {
            case 1:
                Console.WriteLine("kokakola edaria aukera duzu");
                eskaerak.Add("2. Kokakola "); //hemen kokakola hitza gordetzen du eskaerak zerrenda batean
                break;

            case 2:
                Console.WriteLine("Sprite edaria aukera duzu");
                eskaerak.Add("2. Sprite ");
                break;
            case 3:
                Console.WriteLine("Fanta laranja edaria aukera duzu");
                eskaerak.Add("2. Fanta laranja");

                break;
            case 4:
                Console.WriteLine("Fanta limoia edaria aukera duzu");
                eskaerak.Add("2. Fanta limoia ");

                break;
            case 5:
                Console.WriteLine("Nestea edaria aukera duzu");
                eskaerak.Add("2. Nestea ");

                break;
            case 6:
                Console.WriteLine("Bifrutas edaria aukera duzu");
                eskaerak.Add("2. ifrutas ");

                break;
            case 7:
                Console.WriteLine("Ura hautatu duzu");
                eskaerak.Add(" 2. Ura");
                break;
            case 8:
                Console.WriteLine("aldatu nahi duzu zure menu tamaina ");
                int zenbat = eskaerak.Count();// Hemen zuk aukeraten duzu janaria zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1); // Ezabatzen du zuk aukeratzen duzun janaria, janaria aldatzeko.
                Eskaerak();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }
        Console.WriteLine("Nahi duzu izozkia Bai/Ez"); //galdetzen diot nahi baduzu izozki bat
        string? izozkia = Console.ReadLine();

        if (izozkia == "Bai" || izozkia == "bai")
        {
            Console.WriteLine("Erakutsiko dizkizut izozki motak");
            Izozkiak();

        }
        else
        {
            Console.WriteLine("Zure eskaria bukatu duzu");
            Run();
        }

    }
    public void Edari_handiak()
    {

        List<string> edaria_handiak = new List<string> { "1.kokakola-handia", "2.Sprite-handia", "3.Fanta laranja-handia", "4.Fanta limoia-hanida", "5.Nestea-handia", "6.Bifrutas", "7.Ura" };
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < edaria_handiak.Count; i++) // edariak zerertzen du
        {
            Console.WriteLine(edaria_handiak[i]); // edariak erakusten du
        }

        Console.WriteLine("sartu nahi duzun edaria edaria baina aukera  (1-7) edo 8 Aldatu zure janaria");
        string? testu = Console.ReadLine();
        int auker = testu != null ? int.Parse(testu) : 0;

        switch (auker)
        {
            case 1:
                Console.WriteLine(" Kokakola_handia edaria aukeratu duzu");
                eskaerak.Add(" 2. Kokakola_handia "); //hemen kokakola hitza gordetzen du eskaerak zerrenda batean
                break;
            case 2:
                Console.WriteLine("Sprite_handia aukeratu duzu");
                eskaerak.Add("2. Sprite_handia ");
                break;
            case 3:
                Console.WriteLine("Fanta laranaja_handia edaria aukeratu duzu");
                eskaerak.Add("2. Fanta laranaja_handia ");
                break;
            case 4:
                Console.WriteLine("Fanta limoia_handia aukeratu duzu");
                eskaerak.Add("2. Fanta limoia_handia ");
                break;
            case 5:
                Console.WriteLine("Nestea_Handia aukeratu duzu");
                eskaerak.Add(" 2. Nestea_Handia ");
                break;
            case 6:
                Console.WriteLine("Bifrutas_edaria aukeratu duzu");
                eskaerak.Add("2. Bifrutas_handia");
                break;
            case 7:
                Console.WriteLine("Ura_handia aukeratu duzu");
                eskaerak.Add(" 2. Ura_handia ");
                break;
            case 8:
                Console.WriteLine("Zure janaria aldatuko duzu, Janariaren menua erakutsiko dizut");
                int zenbat = eskaerak.Count(); // Hemen zuk aukeraten duzu janaria zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1); // Ezabatzen du zuk aukeratzen duzun janaria, janaria aldatzeko.
                Eskaerak();
                break;

            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }
        Console.WriteLine("Orain aukeratu behar duzu konplementu_handi bat"); //joango zara konplementu_txikien menura
        konplementu_handiak();

    }
    public void Edari_txikiak()
    {

        List<string> edaria_txikiak = new List<string> { "1.kokakola_txikia", "2.Sprite_txikia", "3.Fanta laranja_txikia", "4.Fanta limoia_txikia", "5.Nestea_txikia", "6.Bifrutas_txikia", "7.Ura_txikia" };
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < edaria_txikiak.Count; i++) // edariak zerertzen du
        {
            Console.WriteLine(edaria_txikiak[i]); // edariak erakusten du
        }

        Console.WriteLine("sartu nahi duzun edaria edaria baina aukera  (1-7) edo 8  Aldatu zure janaria");
        string? testu = Console.ReadLine();
        int auker = testu != null ? int.Parse(testu) : 0;

        switch (auker)
        {
            case 1:
                Console.WriteLine("Kokakola_txikia edaria aukera duzu");
                eskaerak.Add("2 .Kokakola_txikia ");//hemen kokakola hitza gordetzen du edari zerrenda batean
                break;
            case 2:
                Console.WriteLine("Sprite_txikia edaria aukera duzu");
                eskaerak.Add("2. Sprite_txikia");
                break;
            case 3:
                Console.WriteLine("Fanta larjanja_txikia edaria aukera duzu");
                eskaerak.Add("2. Fanta larjanja_txikia");
                break;
            case 4:
                Console.WriteLine("Fanta limoia_txikia edaria aukera duzu");
                eskaerak.Add("2. Fanta limoia_txiki");
                break;
            case 5:
                Console.WriteLine("Nestea_txikia edaria aukera duzu");
                eskaerak.Add("2. Nestea_txiki");
                break;
            case 6:
                Console.WriteLine("Bifrutas_txikia edaria aukera duzu");
                eskaerak.Add("2. Bifrutas_txiki");
                break;
            case 7:
                Console.WriteLine("Ura_txikia edaria aukera duzu");
                eskaerak.Add("2. ura_txiki");
                break;
            case 8:
                Console.WriteLine("Zure janaria aldatuko duzu, Janariaren menua erakutsiko dizut");
                int zenbat = eskaerak.Count(); // Hemen zuk aukeraten duzu janaria zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1); // Ezabatzen du zuk aukeratzen duzun janaria, janaria aldatzeko.
                Eskaerak();
                break;

            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }
        Console.WriteLine("Orain aukeratu behar duzu konplementu_txiki bat"); //joango zara konplementu_txikien menura
        konplementu_txikiak();
    }
    public void konplementu_handiak()
    {

        List<string> konplementu_handiak = new List<string> { "1.Nacho_Handiak", "2.Arroz_Handia", "3.Oilasko Fingerr_Handiak(7p)", "4.Saltxitak_hanida (7p)", "5.patatak arrunta_handiak", "6.patatak deluxe_handiak", "7.patatak beacon chease_handiak" };
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < konplementu_handiak.Count; i++) // konplementua zerertzen du
        {
            Console.WriteLine(konplementu_handiak[i]); // konplementua erakusten du
        }

        Console.WriteLine("sartu nahi duzun edaria  baina aukera  (1-7) edo 8 Aldatu zure menu tamaina");
        string? testu = Console.ReadLine();
        int auker = testu != null ? int.Parse(testu) : 0;

        switch (auker)
        {
            case 1:
                Console.WriteLine(" Nacho_Handia  aukeratu duzu");
                eskaerak.Add(" 3. Nacho_Handiaka "); //hemen nacho handiak hitza gordetzen du eskaerak zerrenda batean
                break;
            case 2:
                Console.WriteLine("Arroz_Handia aukeratu duzu");
                eskaerak.Add("3. Arroz_Handia ");
                break;
            case 3:
                Console.WriteLine("Oilasko Finger_Handiak aukeratu duzu");
                eskaerak.Add("3. Oilasko Finger_Handiak ");
                break;
            case 4:
                Console.WriteLine("Saltxitak_hanida aukeratu duzu");
                eskaerak.Add("3. Saltxitak_hanida ");
                break;
            case 5:
                Console.WriteLine("patatak arrunta_handiak");
                eskaerak.Add(" 3. patatak arrunta_handiak ");
                break;
            case 6:
                Console.WriteLine("patatak deluxe_handiakaukeratu duzu");
                eskaerak.Add("3. patatak deluxe_handiak");
                break;
            case 7:
                Console.WriteLine("patatak beacon chease_handiak");
                eskaerak.Add(" 3. patatak beacon chease_handiak ");
                break;
            case 8:

                Console.WriteLine("Edaririen_handien menura joango zara");
                int zenbat = eskaerak.Count(); // Hemen zuk aukeraten duzu edaria_handia zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1);// Ezabatzen du zuk aukeratzen duzun edaria_handia, edaria_handia aldatzeko.
                Edari_handiak();
                break;

            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }

        Console.WriteLine("Nahi duzu izozkia Bai/Ez"); //izozki nahi baduzu ala ez aukeratzen duzu
        string? izozkia = Console.ReadLine();

        if (izozkia == "Bai" || izozkia == "bai")
        {
            Console.WriteLine("Erakutsiko dizkizut izozki motak");
            Izozkiak();

        }
        else
        {
            Console.WriteLine("Zure eskaria bukatu duzu");
            Run();
        }

    }
    public void konplementu_txikiak()
    {
        List<string> konplementu_txikiak = new List<string> { "1.Nacho_txikiak", "2.Arroz_txikiak", "3.Oilasko Fingerr_txikiak(7p)", "4.Saltxitak_txikiak(7p)", "5.patatak arrunta_txikiak", "6.patatak deluxe_txikiak", "7.patatak beacon chease_txikiak" };
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < konplementu_txikiak.Count; i++) // konplementua zerertzen du
        {
            Console.WriteLine(konplementu_txikiak[i]); // konplementua erakusten du
        }

        Console.WriteLine("sartu nahi duzun edaria  baina aukera  (1-7) edo 8 Aldatu zure menu tamaina");
        string? testu = Console.ReadLine();
        int auker = testu != null ? int.Parse(testu) : 0;

        switch (auker)
        {
            case 1:
                Console.WriteLine(" Nacho_txikiak  aukeratu dituzu");
                eskaerak.Add("3. Nacho_Handiaka "); //hemen nacho handiak hitza gordetzen du eskaerak zerrenda batean
                break;
            case 2:
                Console.WriteLine("Arroz_Handia aukeratu duzu");
                eskaerak.Add("3. Arroz_Handia ");
                break;
            case 3:
                Console.WriteLine("Oilasko Finger_txikiakaukeratu dituzu");
                eskaerak.Add("3. Oilasko Finger_txikiak ");
                break;
            case 4:
                Console.WriteLine("Saltxitak_txikiak aukeratu dituzu");
                eskaerak.Add("3. Saltxitak_txikiak ");
                break;
            case 5:
                Console.WriteLine("patatak arrunta_handiak aukeratu dituzu");
                eskaerak.Add(" 3. patatak arrunta_handiak ");
                break;
            case 6:
                Console.WriteLine("patatak deluxe_txikiak aukeratu dituzu");
                eskaerak.Add("3. patatak deluxe_txikiak");
                break;
            case 7:
                Console.WriteLine("patatak beacon chease_txikiak");
                eskaerak.Add(" 3. patatak beacon chease_txikiak ");
                break;
            case 8:
                Console.WriteLine("Edari_txikien menura joango zara");
                int zenbat = eskaerak.Count(); // Hemen zuk aukeraten duzu edaria_txikien zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1);// Ezabatzen du zuk aukeratzen duzun edaria_txikiena, edaria_txikiena aldatzeko.
                Edari_txikiak();
                break;

            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }

        Console.WriteLine("Nahi duzu izozkia Bai/Ez"); //izozki nahi baduzu ala ez aukeratzen duzu
        string? izozkia = Console.ReadLine();

        if (izozkia == "Bai" || izozkia == "bai")
        {
            Console.WriteLine("Erakutsiko dizkizut izozki motak");
            Izozkiak();

        }
        else
        {
            Console.WriteLine("Zure eskaria bukatu duzu");
            Run();
        }

    }
    public void Izozkiak()
    {
        List<string> izozkiak = new List<string> { "1. Pistatxoa izozkia", "2.banila izozkia", "3. Lotus izozkia", "4.txokolate oizozkia" };
        Console.WriteLine($"Aukeratu edari bat: ", '\n');

        for (int i = 0; i < izozkiak.Count; i++) // edariak zerertzen du
        {
            Console.WriteLine(izozkiak[i]); // edariak erakusten du
        }
        Console.WriteLine("aukeratu izkozi bat (1-4) , Aldatu nahi duzu zure edaria {5} konplementu handia aldatu {6} konplementu txikia aldatu {7} ? "); // adirazten ditut izozki motak
        string? testua = Console.ReadLine();
        int izozkia = testua != null ? int.Parse(testua) : 0;


        switch (izozkia)
        {
            case 1:
                Console.WriteLine("Pistatxoa izozkia aukeratu duzu");
                eskaerak.Add("4. Pistatxoa izozkia ");//hemen kokakola hitza gordetzen du edari zerrenda batean
                break;
            case 2:
                Console.WriteLine("Banila izozkia aukeratu duzu");
                eskaerak.Add("4. Banila izkozkia");
                Run();
                break;
            case 3:
                Console.WriteLine("Lotus izozkia aukeratu duzu");
                eskaerak.Add("4. Lotus izozkia ");
                Run();
                break;
            case 4:
                Console.WriteLine("txokolate oizozkia aukeratu duzu");
                eskaerak.Add("4. txokolate oizozkia");
                Run();
                break;
            case 5:
                Console.WriteLine("Edari menura menura joango zara ");
                int zenbat = eskaerak.Count(); // Hemen zuk aukeraten duzu edaria zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbat - 1);// Ezabatzen du zuk aukeratzen duzun edaria, edaria aldatzeko.
                Edariak();
                break;
            case 6:
                Console.WriteLine("konplementu_handiren menura menura joango zara ");
                int zenbatu = eskaerak.Count();// Hemen zuk aukeraten duzu Konplementu_handia zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbatu - 1);// Ezabatzen du zuk aukeratzen duzun klonplementu_handia, konplementu_handia aldatzeko.
                konplementu_handiak();
                break;
            case 7:
                Console.WriteLine("konplementu_txikien menura menura joango zara ");
                int zenbatua = eskaerak.Count(); // Hemen zuk aukeraten duzu Konplementu_txikia zenbatzen du bere posizioa zenbat aldagaian.
                eskaerak.RemoveAt(zenbatua - 1);// Ezabatzen du zuk aukeratzen duzun Konplementu_txikia, Konplementu_txikia aldatzeko.
                konplementu_txikiak();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena, aukerartu edari bat dagoena lokalean");
                break;
        }
    }
    public void Eskaerak_ikusi()
    {
        for (int i = 0; i < eskaerak.Count; i++) // edariak zerertzen du
        {
            Console.WriteLine(eskaerak[i]); // edariak erakusten du
        }
    }
    public void ireten()
    {
        Console.WriteLine("Programatik irten zaude, agur!");
    }
}