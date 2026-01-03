using System.ComponentModel.Design;
using System.Globalization;

namespace ConsoleApp1;



public class Proeiktua
{
    private Eskaerak? eskaera;
   

    List<string> eskaerak = new List<string> { "Hautatu duzun janaria :" };

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
                    eskaera = new Eskaerak(); // sortzen dugu eskarea berri orduan guk egingadakoa ezabatzen da.
                    EskaeraSortu();

                    break;

                case 2:
                    EskaerakIkusi();
                    break;


                case 3:
                    running = false;
                    break;

                default:
                    break;
            }


        }
    }
    public void EskaeraSortu()
    {

        Dictionary<string, string> janariak = new Dictionary<string, string>();

        janariak.Add("Aragi kebab", "aragi kebab");
        janariak.Add("Oilasko kebab", "oilasko kebab");
        janariak.Add("Patatak", "patatak");
        janariak.Add("Patatak aragiarekin", "patatak aragiarekin");
        janariak.Add("Nuggets", "Nuggets");
        janariak.Add("Alitak", "alitak");
        janariak.Add("Falafel", "falafel");

        Console.WriteLine("Aragi kebab");
        Console.WriteLine("");
        Console.WriteLine("Oilasko kebab");
        Console.WriteLine("");
        Console.WriteLine("Patatak");
        Console.WriteLine("");
        Console.WriteLine("Patatak aragiarekin");
        Console.WriteLine("");
        Console.WriteLine("Nuggets");
        Console.WriteLine("");
        Console.WriteLine("Alitak");
        Console.WriteLine("");
        Console.WriteLine("Falafel");
        Console.WriteLine("");

        Console.WriteLine("Janari bat aukeratzeko jarri bere izena mesedez:");  //hasten zara zure janaria aukeratzen 1-7 eta 8 ateratzen zara
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu janari bat aukeratzen ez zara aterako.");
        Console.WriteLine("");



        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu janari bat:");
            string? janaria = Console.ReadLine();

            if (janaria != null && janariak.ContainsKey(janaria))
            {
                Console.WriteLine($"Aukera duzu {janaria}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setJanaria(janaria);
                Console.WriteLine("Aukera duzun janaria da :" + eskaera.getJanaria());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu Janari bat");
                    Console.WriteLine("");
                    Console.WriteLine("Aragi kebab");
                    Console.WriteLine("");
                    Console.WriteLine("Oilasko kebab");
                    Console.WriteLine("");
                    Console.WriteLine("Patatak");
                    Console.WriteLine("");
                    Console.WriteLine("Patatak aragiarekin");
                    Console.WriteLine("");
                    Console.WriteLine("Nuggets");
                    Console.WriteLine("");
                    Console.WriteLine("Alitak");
                    Console.WriteLine("");
                    Console.WriteLine("Falafel");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setJanaria(aldatu);
                    Menu();
                }
                else
                {
                    Menu();
                }

                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri janari bat duguna sukaldean");
                Console.WriteLine("");
            }
        }
        
    }
    public void Menu()
    {
        Console.WriteLine("Menua aukeratzen badauzu konplementu bat aukera izango duzu eskubidea. (- Menu handia: plater handia/ 7 pieza. - Menu txikia: plater txikia/ 4 pieza)");
        Console.WriteLine("");
        Console.WriteLine("Nahi duzu menua Bai/Ez:"); //galdetzen dizu menua nahi badazu ala ez
        string? erantzuna = Console.ReadLine();

        if (erantzuna == "Bai" || erantzuna == "bai")
        {
            Console.WriteLine("zein tamaina nahiko zenuke? Handia/Txikia"); //menuaren tamaina galdetzen dizu
            string? tamaina = Console.ReadLine();
            if (tamaina == "Handia" || tamaina == "handia")
            {
                Console.WriteLine("Orain edari Handiak erakutsiko dizut:");
                Edariak_Handiak(); //joango zara edari handien  menura
            }
            else
            {
                Console.WriteLine("Orain edari Txikiak erakutsiko dizut");
                Edariak_Txikiak();
            }
        }
        else
        {
            Console.WriteLine("Nahi duzu edaria {Bai},Izozki bat nahi duzu {Izkozkia} ?  edo eskaria amaitzea {Amaitu}  "); //edaria nahi badadu ala ez
            string? hartu = Console.ReadLine();
            if (hartu == "Bai" || hartu == "bai")
            {
                Console.WriteLine("Orain edariak erakutsiko dizkizut");
                Edariak();
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

        Dictionary<string, string> Edariak = new Dictionary<string, string>();

        Edariak.Add("kokakola", "kokakola");
        Edariak.Add("Sprite", "Sprite");
        Edariak.Add("Fanta laranja", "Fanta laranja");
        Edariak.Add("Fanta limoia", "Fanta limoia");
        Edariak.Add("Nestea", "Nestea");
        Edariak.Add("Bifrutas", "Bifrutas");
        Edariak.Add("Ura", "Ura");



        Console.WriteLine("kokakola");
        Console.WriteLine("");
        Console.WriteLine("Sprite");
        Console.WriteLine("");
        Console.WriteLine("Fanta laranja");
        Console.WriteLine("");
        Console.WriteLine("Fanta limoia");
        Console.WriteLine("");
        Console.WriteLine("Nestea");
        Console.WriteLine("");
        Console.WriteLine("Bifrutas");
        Console.WriteLine("");
        Console.WriteLine("Ura");

        Console.WriteLine("");

        Console.WriteLine("Edari  bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu Edari bat aukeratzen ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu edari bat:");
            string? edaria = Console.ReadLine();

            if (edaria != null && Edariak.ContainsKey(edaria)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {edaria}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setEdaria(edaria);
                Console.WriteLine("Aukera duzun edaria da :" + eskaera.getEdaria());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu edari bat:");
                    Console.WriteLine("");
                    Console.WriteLine("kokakola");
                    Console.WriteLine("");
                    Console.WriteLine("Sprite");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta laranja");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta limoia");
                    Console.WriteLine("");
                    Console.WriteLine("Nestea");
                    Console.WriteLine("");
                    Console.WriteLine("Bifrutas");
                    Console.WriteLine("");
                    Console.WriteLine("Ura");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setEdaria(aldatu);
                    
                }
                else
                {
                    Izozkiak();
                }
                Izozkiak();
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri edari bat duguna Barran.");
                Console.WriteLine("");
            }
        }
        
    }
    public void Edariak_Handiak()
    {

        Dictionary<string, string> Edaria_Handiak = new Dictionary<string, string>();

        Edaria_Handiak.Add("kokakola_handia", "kokakola_handia");
        Edaria_Handiak.Add("Sprite_handia", "Sprite_handia");
        Edaria_Handiak.Add("Fanta laranja_handia", "Fanta laranja_handia");
        Edaria_Handiak.Add("Fanta limoia_handia", "Fanta limoia_handia");
        Edaria_Handiak.Add("Nestea_handia", "Nestea_handia");
        Edaria_Handiak.Add("Bifrutas_handia", "Bifrutas_handia");
        Edaria_Handiak.Add("Ura_handia", "Ura_handia");

        Console.WriteLine("");

        Console.WriteLine("kokakola_handia");
        Console.WriteLine("");
        Console.WriteLine("Sprite_handia");
        Console.WriteLine("");
        Console.WriteLine("Fanta laranja_handia");
        Console.WriteLine("");
        Console.WriteLine("Fanta limoia_handia");
        Console.WriteLine("");
        Console.WriteLine("Nestea_handia");
        Console.WriteLine("");
        Console.WriteLine("Bifrutas_handia");
        Console.WriteLine("");
        Console.WriteLine("Ura_handia");
        Console.WriteLine("");

        Console.WriteLine("Edari  bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu Edari bat aukeratzen ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu edari bat:");
            string? edaria = Console.ReadLine();

            if (edaria != null && Edaria_Handiak.ContainsKey(edaria)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {edaria}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setEdaria_Handia(edaria);
                Console.WriteLine("Aukera duzun edari da :" + eskaera.getEdaria_Handia());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu edari bat:");
                    Console.WriteLine("");
                    Console.WriteLine("kokakola_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Sprite_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta laranja_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta limoia_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Nestea_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Bifrutas_handia");
                    Console.WriteLine("");
                    Console.WriteLine("Ura_handia");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setEdaria_Handia(aldatu);
                }
                else
                {
                    konplementu_Handiak();
                }

                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri edari bat duguna Barran.");
                Console.WriteLine("");
            }
        }
        konplementu_Handiak();
    }
    public void Edariak_Txikiak()
    {

        Dictionary<string, string> Edaria_Txikiak = new Dictionary<string, string>();

        Edaria_Txikiak.Add("kokakola_txikia", "kokakola_txikia");
        Edaria_Txikiak.Add("Sprite_txikia", "Sprite_txikia");
        Edaria_Txikiak.Add("Fanta laranja_txikia", "Fanta laranja_txikia");
        Edaria_Txikiak.Add("Fanta limoia_txikia", "Fanta limoia_txikia");
        Edaria_Txikiak.Add("Nestea_txikia", "Nestea_txikia");
        Edaria_Txikiak.Add("Bifrutas_txikia", "Bifrutas_txikia");
        Edaria_Txikiak.Add("Ura_txikia", "Ura_txikia");


        Console.WriteLine("kokakola_txikia");
        Console.WriteLine("");
        Console.WriteLine("Sprite_txikia");
        Console.WriteLine("");
        Console.WriteLine("Fanta laranja_txikia");
        Console.WriteLine("");
        Console.WriteLine("Fanta limoia_txikia");
        Console.WriteLine("");
        Console.WriteLine("Nestea_txikia");
        Console.WriteLine("");
        Console.WriteLine("Bifrutas_txikia");
        Console.WriteLine("");
        Console.WriteLine("Ura_txikia");
        Console.WriteLine("");

        Console.WriteLine("Edari  bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu Edari bat aukeratzen ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu edari bat:");
            string? edaria = Console.ReadLine();

            if (edaria != null && Edaria_Txikiak.ContainsKey(edaria)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {edaria}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setEdaria_Txikia(edaria);
                Console.WriteLine("Aukera duzun edaria da :" + eskaera.getEdari_Txikia());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu edari bat:");
                    Console.WriteLine("");
                    Console.WriteLine("kokakola_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Sprite_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta laranja_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Fanta limoia_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Nestea_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Bifrutas_txikia");
                    Console.WriteLine("");
                    Console.WriteLine("Ura_txikia");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setEdaria_Txikia(aldatu);
                }
                else
                {
                    konplementu_Txikiak();
                }

                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri edari bat duguna Barran.");
                Console.WriteLine("");

            }
        }
        konplementu_Txikiak();
    }
    public void konplementu_Handiak()
    {

        Dictionary<string, string> Konplementu_Handiak = new Dictionary<string, string>();

        Konplementu_Handiak.Add("Nacho_Handiak", "Nacho_Handiak");
        Konplementu_Handiak.Add("Arroz_Handia", "Arroz_Handia");
        Konplementu_Handiak.Add("Oilasko Fingerr_Handiak", "Oilasko Fingerr_Handiak");
        Konplementu_Handiak.Add("Saltxitak_hanida ", "Saltxitak_hanida ");
        Konplementu_Handiak.Add("patatak arrunta_handiak", "patatak arrunta_handiak");
        Konplementu_Handiak.Add("patatak deluxe_handiak", "patatak deluxe_handiak");
        Konplementu_Handiak.Add("patatak beacon chease_handiak", "patatak beacon chease_handiak");



        Console.WriteLine("Nacho_Handiak");
        Console.WriteLine("");
        Console.WriteLine("Arroz_Handia");
        Console.WriteLine("");
        Console.WriteLine("Oilasko Fingerr_Handiak");
        Console.WriteLine("");
        Console.WriteLine("Saltxitak_hanida ");
        Console.WriteLine("");
        Console.WriteLine("patatak arrunta_handiak");
        Console.WriteLine("");
        Console.WriteLine("patatak deluxe_handiak");
        Console.WriteLine("");
        Console.WriteLine("patatak beacon chease_handiak");

        Console.WriteLine("");

        Console.WriteLine("konplementu handi bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu konplementu handi bat aukeratu ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu konplementu bat:");
            string? konplementu = Console.ReadLine();

            if (konplementu != null && Konplementu_Handiak.ContainsKey(konplementu)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {konplementu}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setKonplementu_Handiak(konplementu);
                Console.WriteLine("Aukera duzun konplementu da :" + eskaera.getKonplementu_Handiak());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu konplementu bat:");
                    Console.WriteLine("");
                    Console.WriteLine("Nacho_Handiak");
                    Console.WriteLine("");
                    Console.WriteLine("Arroz_Handia");
                    Console.WriteLine("");
                    Console.WriteLine("Oilasko Fingerr_Handiak");
                    Console.WriteLine("");
                    Console.WriteLine("patatak arrunta_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("patatak deluxe_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("patatak beacon chease_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("Saltxitak_hanida ");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setKonplementu_Handiak(aldatu);
                }
                else
                {
                    Izozkiak();
                }

                break;
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri konplementu  bat medesedez.");
                Console.WriteLine("");
            }
        }
        Izozkiak();
       
    }
    public void konplementu_Txikiak()
    {

        Dictionary<string, string> Konplementu_txikiak = new Dictionary<string, string>();

        Konplementu_txikiak.Add("Nacho_txikiak", "Nacho_txikiak");
        Konplementu_txikiak.Add("Arroz_txikia", "Arroz_txikia");
        Konplementu_txikiak.Add("Oilasko Fingerr_txikiak", "Oilasko Fingerr_txikia");
        Konplementu_txikiak.Add("Saltxitak_txikiak ", "Saltxitak_txikia ");
        Konplementu_txikiak.Add("patatak arrunta_txikia", "patatak arrunta_txikiak");
        Konplementu_txikiak.Add("patatak deluxe_txikia", "patatak deluxe_txikiak");
        Konplementu_txikiak.Add("patatak beacon chease_txikiak", "patatak beacon chease_txikiak");



        Console.WriteLine("Nacho_txikiak");
        Console.WriteLine("");
        Console.WriteLine("Arroz_txikia");
        Console.WriteLine("");
        Console.WriteLine("Oilasko Fingerr_txikiak");
        Console.WriteLine("");
        Console.WriteLine("Saltxitak_txikiak ");
        Console.WriteLine("");
        Console.WriteLine("patatak arrunta_txikia");
        Console.WriteLine("");
        Console.WriteLine("patatak deluxe_txikia");
        Console.WriteLine("");
        Console.WriteLine("patatak beacon chease_txikiak");

        Console.WriteLine("");

        Console.WriteLine("konplementu txiki bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu konplementu txiki bat aukeratu ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu konplementu  bat:");
            string? konplementu = Console.ReadLine();

            if (konplementu != null && Konplementu_txikiak.ContainsKey(konplementu)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {konplementu}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setKonplementu_Txikiak(konplementu);
                Console.WriteLine("Aukera duzun konplementu da :" + eskaera.getKonplementu_Txikiak());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu konplementu barri bat:");
                    Console.WriteLine("");
                    Console.WriteLine("Nacho_Handiak");
                    Console.WriteLine("");
                    Console.WriteLine("Arroz_Handia");
                    Console.WriteLine("");
                    Console.WriteLine("Oilasko Fingerr_Handiak(4p)");
                    Console.WriteLine("");
                    Console.WriteLine("patatak arrunta_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("patatak deluxe_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("patatak beacon chease_handiak");
                    Console.WriteLine("");
                    Console.WriteLine("Saltxitak_hanida (4p)");
                    Console.WriteLine("");
                    string? aldatu = Console.ReadLine();
                    eskaera.setKonplementu_Txikiak(aldatu);
                }
                else
                {
                    Izozkiak();
                }

                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri konplementu  bat medesedez.");
                Console.WriteLine("");
            }
        }
        Izozkiak();
    }
    public void Izozkiak()
    {

        Dictionary<string, string> Izozkiak = new Dictionary<string, string>();

        Izozkiak.Add("Pistatxoa izozkia", "Pistatxoa izozkia");
        Izozkiak.Add("Banila izozkia", "Banila izozkia");
        Izozkiak.Add("Lotus izozkia", "Lotus izozkia)");
        Izozkiak.Add("txokolate oizozkia", "txokolate oizozkia");

        Console.WriteLine("Pistatxoa izozkia");
        Console.WriteLine("");
        Console.WriteLine("Banila izozkia");
        Console.WriteLine("");
        Console.WriteLine("Lotus izozkia");
        Console.WriteLine("");
        Console.WriteLine("txokolate oizozkia");
        Console.WriteLine("");

        Console.WriteLine("izozki bat aukeratzeko jarri bere izena mesedez:");
        Console.WriteLine("");
        Console.WriteLine("Ez baduzu izozki bat aukeratu ez zara aterako.");
        Console.WriteLine("");
        while (true) // edari bat aukearatu harte eta hiztegian badago aterako zara whiletik.
        {
            Console.WriteLine("");
            Console.WriteLine("Aukeratu izozki bat:");
            string? izozkiak = Console.ReadLine();

            if (izozkiak != null && Izozkiak.ContainsKey(izozkiak)) // hemen zuk jarritzen duzun edaria konprobatzen du ea dagoen hiztegian, bestela eskatuko dizu berri edari bat jartzea hiztegian dagoen bat.
            {
                Console.WriteLine($"Aukera duzu {Izozkiak}, joango zara Menuen Menuara.");
                Console.WriteLine("");
                eskaera.setIzozkia(izozkiak);
                Console.WriteLine("Aukera duzun izozki da :" + eskaera.getIzozkia());
                Console.WriteLine("");
                Console.WriteLine("Nahi duzu aldatu? Bai/Ez ");
                string? Aldatu = Console.ReadLine();
                if (Aldatu == "Bai" && Aldatu == "bai")
                {
                    Console.WriteLine("Aukearu izozki  barri bat:");
                    Console.WriteLine("");
                    Console.WriteLine("Pistatxoa izozkia");
                    Console.WriteLine("");
                    Console.WriteLine("Banila izozkia");
                    Console.WriteLine("");
                    Console.WriteLine("Lotus izozkia");
                    Console.WriteLine("");
                    Console.WriteLine("txokolate oizozkia");
                    Console.WriteLine("");

                    string? aldatu = Console.ReadLine();
                    eskaera.setIzozkia(aldatu);
                }
                else
                {
                    return;
                }

                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Jarri izozki  bat medesedez.");
                Console.WriteLine("");
            }
        }
        return;
    }
    public void EskaerakIkusi()
    {
        if (eskaera == null)
        {
            Console.WriteLine("Ez dago oraindik eskaerarik.");
            return;
        }

        Console.WriteLine("===== AURREKO ESKAERA =====");

        Console.WriteLine("Janaria: " + eskaera.getJanaria());
        Console.WriteLine("Edaria: " + eskaera.getEdaria());
        Console.WriteLine("Edari handia: " + eskaera.getEdaria_Handia());
        Console.WriteLine("Edari txikia: " + eskaera.getEdari_Txikia());
        Console.WriteLine("Konplementu handiak: " + eskaera.getKonplementu_Handiak());
        Console.WriteLine("Konplementu txikiak: " + eskaera.getKonplementu_Txikiak());
        Console.WriteLine("Izozkia: " + eskaera.getIzozkia());
    }


}