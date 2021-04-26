using System;
using System.Security.Cryptography;

namespace PripravaKMaturiteITP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prvni zadani
            
            //Deklarace promenne, kterou pozdeji pouzijeme jako argument pro nasi metodu 
            double[] mistniPole = new double[4];
            //Vypiseme do konzole vyzvu k zadani hodnot, muzeme to udelat manualne, ale ja si ulehcim praci cyklem for
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Zadejte {i + 1}. destinne cislo");
                //Zkousime zda nam to konverze nevyhodi chybu
                try
                {
                    //Plnime pole zadanym vstupem od uzivatele

                    mistniPole[i] = Convert.ToDouble(Console.ReadLine());
                }
                //Pokud chybu odhalime, vyzve program uzivatele k retartu
                catch (Exception)
                {
                    Console.WriteLine("Nespravne zadane cislo, restartujte prosim program");
                }
            }
            //Po skonceni cyklu pro naplneni pole zavolame metodu s argumentem mistnihoPole, ktere jsme si predtim naplnili 
            PrvniZadani(mistniPole);
            
            
            //Druhe zadani
        }

        //Metodu vytvarime statickou z duvodu toho, ze bychom ji jinak v mainu nemohli zavolat, jako argumenty metody prijmame pole double, protoze po nas chce pouzit k vypoctu cykly
        static void PrvniZadani(double[] cisla)
        {
            //Zadani: Načtěte od uživatele 4 desetinná čísla a na výstupu konzole bude vypsán aritmetický průměr těchto 4 hodnot a poté jejich součin, pro tyto operace si vyberte dva různé cykly.

            //Deklarujeme si promenne, vzhledem k tomu, ze soucin je vysledek nasobeni, musi byt deklarovan na jednicku, do prumeru budeme pricitat, tudiz musi byt deklarovana na 0
            double soucin = 1;
            double prumer = 0;
            
            //Spustime cyklus for ktery bude koncit na konci pole, protoze zaciname od nuly
            for (int i = 0; i < cisla.Length ; i++)
            {
                //Pricteme do promenne kazde cislo z cyklu (+= pricte k promenne cislo a zachova jeji hodnotu)
                prumer += cisla[i];
            }
            //Po skonceni cyklu vydelime vysledek poctem cisel abychom dosahli aritmetickeho prumeru a vypiseme vysledek do konzole
            prumer = prumer / cisla.Length;
            Console.WriteLine("Prumer: " + prumer);
            
            
            //Tady se vrhneme na soucin, musime pouzit jiny cyklus, tudiz si zvolime foreach, ktery za nas projde kazdou hodnotu v zadane kolekci(poli)
            foreach (var cislo in cisla)
            {
                //Udelame si soucin a budeme to cislo pokazde nasobit dalsi hodnotou v kolekci(poli) 
                soucin *= cislo;
            }
            //Po konci uz zbyva pouze vypsat hodnotu promenne soucin
            Console.WriteLine("Soucin: " + soucin);
        }
    }
}
