using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace gra_o_menelu
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("ładowanie...");
            int ladowanie = 1;
                while (ladowanie < 10)
            {
                Console.WriteLine(ladowanie);
                ladowanie++;


            }
            Console.WriteLine("Załadowano!\n");


            int HP = 5;
            int maksHP = 5;
            string WiadomoscUwaga = "Uwaga! Masz mało zdrowia!";
            if (maksHP < HP)
            {
                HP = 5;
            }


            if (HP <= 0)
            {
                Console.WriteLine("Zginełeś.");
                Console.WriteLine("KONIEC GRY");
                Environment.Exit(1);
            }

            string ZycieSlowo = "Foo";
            if (HP == 1)
            {
                ZycieSlowo = " punkt zdrowia! Jesteś na skraju wyczerpania! ";

            }

            else if (HP == 2)
            {

                ZycieSlowo = " punkty zdrowia! Zaraz możasz zginąć! ";

            }

            else if (HP == 3)
            {

                ZycieSlowo = " punkty zdrowia! Nie czujesz się zbyt dobrze ";

            }
            else if (HP == 4)
            {

                ZycieSlowo = " punkty zdrowia. Jesteś blady";

            }
            else if (HP == 5);
            {

                ZycieSlowo = " punktów zdrowia. Zainspirowany i gotowy.";

            }


            int coin = 100;

            //nienawidzę gramatyki polskiej ale jak trzeba to trzeba jeszcze raz

            string SlowoMonety = "Bar";
            if (coin == 1)
            {
                SlowoMonety = "złotą monetę";

            }

            else if (coin == 2)
            {

                SlowoMonety ="złote monety";

            }
            
            else if (coin == 3)
            {

                SlowoMonety = "złote monety";

            }
            else if (coin == 4)
            {

                SlowoMonety = "złote monety";

            } 
            else if (coin > 4)
            {

                SlowoMonety = "złotych monet";

            }



            Console.WriteLine("POSŁANIEC KRÓLA");
            Console.WriteLine("  Stworzone przez Daniela Chudziaka\n\n");

            Console.WriteLine("Jak masz na imię?");
            string imie = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Jaki masz zawód?");
            string jest = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Masz na imię " + imie + ". Jesteś " + jest + "em mieszkającym w Imperium Rosyjskim");
            Console.WriteLine("Parę dni temu zostałeś wybrany przes księcia Mikołaja I Romanowa");
            Console.WriteLine("Jako jego posłaniec, choć niedawno tylko prowadzłeś typowe życie " + jest + "a");
            Console.WriteLine("Tak czy siak, szczęście się do ciebie uśmiechneło");
            Console.WriteLine("Jutro masz podjąc się zadania przewieźenia i wręczenia listu");
            Console.WriteLine("Karolowi IV zasiadającemu na tronie Hiszpanii");
            Console.WriteLine("Masz wybór się przygotować, lub nie i kontynuować swe codzienne czynności");
            Console.WriteLine("I jednocześnie stracić pracę i zostać zniesławionym\n");
            Console.WriteLine("\nMasz " + HP + " " + ZycieSlowo);
            
            Console.WriteLine("Naciśnij 1 jeżeli chcesz podjąć się pracy, jeśli nie naciśij 2 ");
            int wyb1 = Convert.ToInt32(Console.ReadLine());
            if (wyb1 == 2)
            {
                Console.WriteLine("Wybrałeś odwarzną drogę pełną spokoju, byłeś " + jest + "em i nim zostaniesz.");
                Console.WriteLine("A przynajmniej tak myślałeś lecz nie, zostajesz napadnięty w domu i porwany");
                Console.WriteLine("Przez namiestników księcia.");
                Console.WriteLine("  - Poniesiesz karę, chamie!");
                Console.WriteLine("Giniesz torturowany w podziemnych katakumbach.");
                Console.WriteLine("KONIEC GRY");
                
                ;
                return;
            }
            else
            {

                coin = 3;
                Console.WriteLine("Kupujesz tanią linę, prostą skórzaną zbroję");
                Console.WriteLine("Za pieniądze które uzyskałeś sprzedając swój cały dorobek");
                Console.WriteLine("Poświęciłeś prawie cały majątek jakie miałeś");
                Console.WriteLine("Aby mieć pewność, że nie zawiedziesz");
                Console.WriteLine("Zostały ci " + coin + " " + SlowoMonety);


            }

            Console.WriteLine("Masz tylko 6 dni zanim książe Mikołaj I Romanow");
            Console.WriteLine("Własnoręcznie da ci specjalny list od którego przewiezienia");
            Console.WriteLine("Od niego będzie zależć reszta twojego dotychczasowego życia.");
            Console.WriteLine("Teraz stajesz przed następnym wyborem w celu zdobycia pieniędzy na prowiant");
            Console.WriteLine("Możesz próbować wyżebrać pod kościołem parę groszy");
            Console.WriteLine("Lub dorobić wybierając ziemniaki z ziemii");
            Console.WriteLine("\nMasz " + HP + " " + ZycieSlowo);
            Console.WriteLine("Aby błagać pod kościołem naciśnij 1, aby próbować dorobić naciśnij 2");
            int wyb2 = Convert.ToInt32(Console.ReadLine());

            if (wyb2 == 1)
            {
                Console.WriteLine("Gdy siedisz na zimnych schodach katedry Św.Bazylego ");
                Console.WriteLine("W twoją stronę idzie młodzieniec ubrany w eleganckie ciuchy");
                Console.WriteLine("Widać wyrażnie, że z wysokiej klasy społecznej");
                Console.WriteLine("Być może jest paziem, lub już pełnoprawnym rycerzem");
                Console.WriteLine("W ręce trzyma zabrudzone piwem pół złotej monety");
                Console.WriteLine("\nMasz " + HP + " " + ZycieSlowo);
                Console.WriteLine("\nJeżeli chcesz go poprosić naciśnij 1, jeżeli nastraszyć naciśnij 2 ");
                int wyb2a1 = Convert.ToInt32(Console.ReadLine());
                if (wyb2a1 == 2)
                {
                    Console.WriteLine("Robisz straszną minę i krzyczysz coś niezrozumiałego w stronę nieznajomego");
                    Console.WriteLine("-Zostaw mnie szatanie! - krzyczy rzucając ci pół monety i wbiegając do kościoła");
                    Console.WriteLine("Najwyraźniej go efektywnie przestraszyłeś, skoro uznał cię za samego szatana ");
                    Console.WriteLine("Przecierz nawet tak źle nie wyglądasz, co nie?");

                    ///zrobić ŻycieSlowo proszę się i jeszcze /n tam i jeszcze gdzieś

                }






            }
            
           
        }



        


    }



}





