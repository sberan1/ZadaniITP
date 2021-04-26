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
            Console.WriteLine("Zadej, kolik chces sestavit pocitacu: ");
            //Nacteme zadanou hodnotu od uzivatele a prekonvertujeme ji do pozadovaneho formatu
            DruheZadani(Convert.ToInt32(Console.ReadLine()));
            
            //Treti zadani 
            
            //Zakladame nekonecny cyklus while, ktery osetri moznost zadat cisla nekolikrat zasebou jak je uvedeno v zadani
            while (true)
            {
                Console.WriteLine("Zadejte cislo: ");
                //Nacteme zadanou hodnotu od uzivatele a prekonvertujeme ji do pozadovaneho formatu
                TretiZadani(Convert.ToInt32(Console.ReadLine()));
            }
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

        //Davame zde v argumentu uzivateli moznost kolik pocitacu chce sestrojit
        static void DruheZadani(int pocetPocitacu)
        {
            //Zadani:
            //Napište program, který bude simulovat výrobní linku počítače.

            // Pro výrobu počítače je potřeba hlídat stav skladu, ze kterého se berou díly.

            // Pro sestavení jednoho PC je potřeba:

            // 1x case, 1x základní deska s procesorem, 2x RAM, 3x chladič.

            // Je potřeba čekat na výrobní linku která:

            // Za jeden výrobní cyklus se vyrobí 1x case 0.5x základní desky s procesorem, 0.7x RAM a 4x chladičů.

            // Po naskladnění dostatku dílů program vypíše, kolik bylo potřeba výrobních cyklů, na sestavení jedné PC stanice

            
            //Deklarujeme si par promennych, sestavenyPocitac, ktery nam bude rikat, zda je hotovych dost komponentu, pocitadlo, ktere nam bude rikat, kolikrat uz cyklus probehl a vsechny komponenty jako double, ktere deklarujeme na 0
            bool sestavenyPocitac = false;
            int pocitadlo = 0;
            double krabice = 0;
            double motherboard = 0;
            double ram = 0;
            double chladic = 0;
            
            
            //Pouzijeme cyklus do while ktery nam dovoli provadet operace dokud nebude splnena podminka
            do
            {
                //Pridame do skladu pocet kusu co se vyrobi za jeden cyklus
                krabice += 1;
                motherboard += 0.5;
                ram += 0.7;
                chladic += 4;
                
                //pridame si jedno probehnuti cyklu 
                pocitadlo++;

                //podivame se, zda mame presne, nebo vice komponent ve skladu 
                if (krabice >= 1 * pocetPocitacu && motherboard >= 1 * pocetPocitacu && ram >= 2* pocetPocitacu && chladic >= 3 * pocetPocitacu)
                {
                    sestavenyPocitac = true;
                }

            } 
            //Zjistujeme, zda uz mame pocitac sestaveny
            while (!sestavenyPocitac);
            
            //Zaver programu 
            Console.WriteLine($"sestaveni {pocetPocitacu} pocitacu trvalo {pocitadlo} cyklu");
        }

        //Zakladame si metodu s argumentem cisla N 
        static void TretiZadani(int cisloN)
        {
            //Zadani: Napište program, který umožní uživateli opakovaně zadat celé číslo N. Program následně vypíše všechna čísla v intervalu 0 – N*20, která jsou zároveň násobky čísla N.

            //zalozime cyklus, ktery nam vypise vsechny vsechny cisla do N * 20
            for (int i = 0; i < (cisloN + 1) * 20; i++)
            {
                //zde zaciname zkoumat, zda jsou vypsane cisla take delitelne N a pokus ano, vypiseme je do konzole,  i % cisloN nam zkouma jaky je zbytek po deleni 
                if (i % cisloN == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            //Vypiseme enter, abychom dalsi dotaz meli na dalsim radku
            Console.WriteLine();
        }
    }
}
