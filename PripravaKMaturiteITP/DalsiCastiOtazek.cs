using System;
using System.Net.Mail;

namespace PripravaKMaturiteITP
{
    public class DalsiCastiOtazek
    {
        void ZakladniTypy()
        {
            
            
           //podminku if pouzivame vicmene nejcasteji ve vsech programech, dovoli nam kontrolovat vstup
           //a upravit chovani programu podle toho co od programu chceme, protoze jakmile se zavola cast kodu
           //ktera splnuje podminku, zbytek bude ignorovat
            
            int time = 22;
            if (time < 10) //pokud by promenna cas byla mensi nez deset, program nam vypise: Good morning.
            {
                Console.WriteLine("Good morning.");
            } 
            else if (time < 20) //pokud by promenna cas byla mensi nez dvacet a vetsi nebo rovna 10, program nam vypise: Good day. toto nam zajistuje klicove slovicko else if, protoze vime, ze nase promenna nesplnila prvni podminku
            {
                Console.WriteLine("Good day.");
            } 
            else //ve vsech drive nezminenych pripadech (tj. 20 - nekonecno) nam program vypise: Good evening.
            {
                Console.WriteLine("Good evening.");
            }
            //program do konzole vypise: Good evening.

            
            
            
            
            //switch se pouziva jako nahrada za podminku if v pripade ze mame jasne dane data, kterym by se mela promenna rovnat (napr. enum, kde je preddefinovanych par hodnot)
            //pro jednodussi ukazku jsem si vybral jednoduchy string
            string jmeno = "Karel";
            switch (jmeno) //v zavorce mame definovane jakou promennou ma tato funkce overovat
            {
                case "Karel": //pokud ma promenna v zavorce hodnotu Karel, program provede tuto cast kodu
                    Console.WriteLine("Jmeno je Karel");
                    break; //klicove slovo break zapricini to, ze switch nebude nadale hledat dalsi cast kodu, kterou by mel provest
                case "Frantisek": //pokud ma promenna v zavorce hodnotu Frantisek, program provede tuto cast kodu
                    Console.WriteLine("Jmeno je Frantisek");
                    break;
                default: //Ve vsech ostatnich, drive neuvedenych pripadech program provede cast kodu za klicovym slovem default
                    Console.WriteLine("Toto jmeno neznam");
                    break;
            } //program do konzole vypise: Jmeno je Karel

            
            
            
            //cyklus while se pouziva v pripadech, kdy nepotrebujeme vedet kvantifikator pokusu (tj. pokolikate cyklus probiha)
            int pocitadlo = 0;
            //zde jsem si vybral nejjednodussi ukazku, kde pokazde vypisujeme cislo a navysujeme ho o 1
            while (pocitadlo < 5)
            {
                Console.Write(pocitadlo);
                pocitadlo++; //navyseni hodnoty promenne o 1
            }
            //program do konzole vypise: 01234
            
            
            
            
            //cyklus do while funguje naprosto stejne jako cyklus while, ale overuje hodnotu az po pusteni kodu, pouziva se v nekterych prikladech misto while pro lepsi citelnost kodu 
            int pocitacka = 0;
            do
            {
                Console.WriteLine($"cislo: {pocitacka}");
                pocitacka++;
            } 
            while (pocitacka < 5); // zde si opet ukazejeme nejjednodussi dukaz 
            //do konzole program vypise
            //cislo: 0
            //cislo: 1
            //cislo: 2
            //cislo: 3
            //cislo: 4
            
            
            
            

            //cyklus for je zrejme nejpouzivanejsi cyklus, protoze nam ke vsemu co zvladne i while pridava jeste cislo kolikrat cyklus probehl. Neni vhodne pro nektere zadani
            int pocetCyklu = 3;
            for (int i = 0; i < pocetCyklu; i++)
            {
                Console.WriteLine($"Toto je {i + 1}. pokus");
            }
            //do konzole program vypise
            //Toto je 1. pokus
            //Toto je 2. pokus
            //Toto je 3. pokus

            
            

            //cyklus foreach se pouziva na prochazeni kolekci, protoze nam dovoluje pri kazde polozce v kolekci dostat bez dalsich kvantifikatoru jakoukoliv hodnotu z dane kolekce (napr. vlastnosti ze tridy) 
            int[] cisla = { 7, 5, 3, 8, 1, 0};
            //opet jsem si vybral jednoduchy priklad, ktery pouze prochazi jedno pole a vypisuje kazdou jeho hodnotu
            foreach (var polozka in cisla)
            {
                Console.WriteLine($"toto je {polozka} ");
            }
            //do konzole program vypise
            //toto je 7
            //toto je 5
            //toto je 3
            //toto je 8
            //toto je 1
            //toto je 0
            
            
        }
    }
}