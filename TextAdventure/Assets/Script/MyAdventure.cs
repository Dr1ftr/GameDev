using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update

    private enum States
    {
        start,
        intro1,
        intro2,
        deel2nee,
        hack,
        deelnee,
        nacht,
        leukpotje,
        delen,
        delen2,
        inbraak,
        mes,
        telefoon,
        rug,
        frontaal,
        nietren,
        renweg,
        renje,
        nietren2,
        buurman,
        politie,
        reboot
    }

    private States currentState = States.start;

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Horrornite");
        Terminal.WriteLine("Gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Als geen ander commando is aangegeven,");
        Terminal.WriteLine("gebruik het commando:'verder'");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    void OnUserInput(string Input)
    {
        if (currentState == States.start)
        {
            if (Input == "start")
            {
                currentState = States.intro1;
                StartIntro();
            }
            else if (Input == "331516")
            {
                Terminal.WriteLine("Jup, dat ben ik.");
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }
        else if (currentState == States.intro1)
        {
            if (Input == "verder")
            {
                currentState = States.intro2;
                VerderIntro();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }
        else if (currentState == States.intro2)
        {
            if (Input == "verder") 
            {
                currentState = States.delen;
                deel();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }
        else if (currentState == States.delen)
        {
            if (Input == "nee") 
            {
                currentState = States.deelnee;
                deelnee();
            }
            else if (Input == "ja")
            {
                currentState = States.inbraak;
                deelja();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.deelnee)
        {
            if (Input == "verder")
            {
                currentState = States.leukpotje;
                leukpotje();
            }
            else
            {
                Terminal.WriteLine("verkeerde invoer");
            }
        }
        else if (currentState == States.leukpotje)
        {
            if (Input == "verder")
            { 
                currentState = States.delen2;
                delen2();

            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }
        else if (currentState == States.delen2)
        {
            if (Input == "ja")
            {
                currentState = States.inbraak;
                deelja();
            }
            else if (Input == "nee")
            {
                currentState = States.deel2nee;
                deel2nee();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.deel2nee)
        {
            if (Input == "verder")
            {
                currentState = States.hack;
                hack();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }    
        else if (currentState == States.hack)
        {
            if (Input == "verder")
            {
                currentState = States.inbraak;
                inbraak();

            }                  
        }
        else if (currentState == States.inbraak)
        {
            if (Input == "verder")
            {
                currentState = States.nacht;
                nacht();
            }    
        }
        else if (currentState == States.nacht)
        {
            if (Input == "ren")
            {
                currentState = States.renweg;
                renweg();
            }
            else if (Input == "niet rennen")
            {
                currentState = States.nietren;
                nietren();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.nietren)
        {
            if (Input == "mes")
            {
                currentState = States.mes;
                mes();
            }
            else if (Input == "telefoon")
            {
                currentState = States.telefoon;
                telefoon();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }    
        else if (currentState == States.mes)
        {
            if (Input == "rug")
            {
                currentState = States.rug;
                rug();
            }
            else if (Input == "frontaal")
            {
                currentState = States.frontaal;
                frontaal();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.telefoon)
        {
            if (Input == "buurman")
            {
                currentState = States.buurman;
                buurman();
            }
            else if (Input == "politie")
            {
                currentState = States.politie;
                politie();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.rug)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.delen2)
        {
            if (Input == "ja")
            {
                currentState = States.inbraak;
                deelja();
            }
            else if (Input == "nee")
            {
                currentState = States.deel2nee;
                deel2nee();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.buurman)
        {
            if (Input == "verder")
            {
                currentState = States.renje;
                renje();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.nietren2)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.politie)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.renweg)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.nietren2)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }       
        else if (currentState == States.renweg)
        {
                     if (Input == "verder")
                     {
                         currentState = States.reboot;
                         reboot();
                     }
                     else
                     {
                         Terminal.WriteLine("Verkeerde invoer");
                     }     
        }
        else if (currentState == States.nietren2)
        {
                     if (Input == "verder")
                     {
                         currentState = States.reboot;
                         reboot();
                     }
                     else
                     {
                         Terminal.WriteLine("Verkeerde invoer");
                     }     
        }
        else if (currentState == States.renje)
        {
            if (Input == "nietren")
            {
                currentState = States.nietren2;
                nietren2();
            }
            else if (Input == "renweg")
            {
                currentState = States.renweg;
                renweg();    
            }     
        }   
        else if (currentState == States.reboot)
        {
            if (Input == "reboot")
            {
                currentState = States.start;
                ShowMainMenu();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.renweg)
        {
            if (Input == "verder")
            {
                currentState = States.reboot;
                reboot();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }     
        }
        else if (currentState == States.renje)
        {
            if (Input == "nietren")
            {
                currentState = States.nietren2;
                nietren2();
            }
            else if (Input == "renweg")
            {
                currentState = States.renweg;
                renweg();    
            }     
        }   
    }    


    private class MyAdventureImpl : MyAdventure
    {
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude donkere nacht");
        Terminal.WriteLine("Een goede nacht om Fortnite te spelen");
    }

    void VerderIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt een koel biertje naast je op de tafel staan");
        Terminal.WriteLine("Je start de game op");
        Terminal.WriteLine("En na een tijdje begin je bekent te raken met een");
        Terminal.WriteLine("mede speler");
    }

    void deel()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De mede-gamer vraagt je");
        Terminal.WriteLine("of je je adres wilt delen");
        Terminal.WriteLine("");
        Terminal.WriteLine("Deel je je adres?");
        Terminal.WriteLine("Typ nee om je adres niet te delen,");
        Terminal.WriteLine("en ja om je adres wel te delen");
    }

    void deelja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt je adres gedeeld");
        Terminal.WriteLine("Na een paar leuke potjes ga je");
        Terminal.WriteLine("Rustig naar bed");
    }

    void deelnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt je adres niet gedeeld");
    }

    void leukpotje()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt een leuk potje met de mede-gamer");
        Terminal.WriteLine("De gamer is heel aardig en maakt er een");
        Terminal.WriteLine("leuke avond van");
    }

    void delen2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("de mede-gamer vraagt je weer om je adres te delen");
        Terminal.WriteLine("");
        Terminal.WriteLine("Deel je je adres?");
        Terminal.WriteLine("Typ nee om je adres niet te delen,");
        Terminal.WriteLine("en ja om je adres wel te delen");
    }

    void deel2nee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je geeft de gamer weer niet je adres,");
        Terminal.WriteLine("Maar deze keer pakt hij het niet zo goed op.");
        Terminal.WriteLine("Je bent er na dit incident een beetje klaar mee,");
        Terminal.WriteLine("en je gaat naar bed.");
    }

    void hack()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent gehackt");
    }

    void inbraak()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De inbraak");
    }

    void nacht()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Ren je weg of niet?");
        Terminal.WriteLine("typ ren om te rennen & niet rennen om niet te rennen");
    }

    void reboot()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Dit is het einde");
        Terminal.WriteLine("Bedankt voor het spelen!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ reboot om terug te gaan");
        Terminal.WriteLine("naar de main menu!");
    }

    void renweg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent weg");
        Terminal.WriteLine("Je komt de volgende dag thuis");
        Terminal.WriteLine("Met €2000 schade");
    }

    void nietren()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent niet weg");
        Terminal.WriteLine("Maar de inbreker is wel binnen");
        Terminal.WriteLine("Je staat in de keuken,");
        Terminal.WriteLine("Je ziet een telefoon en een mes");
        Terminal.WriteLine("Welke pak je?");
        Terminal.WriteLine("typ telefoon voor de telefoon en mes voor het mes");
    }

    void mes()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt het mes opgepakt");
        Terminal.WriteLine("Maar hoe val je aan?");
        Terminal.WriteLine("Frontaal of in de rug?");
        Terminal.WriteLine("Typ frontaal voor frontaal,");
        Terminal.WriteLine("en rug voor in de rug");
    }

    void telefoon()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt de telefoon opgepakt");
        Terminal.WriteLine("Maar wie bel je?");
        Terminal.WriteLine("De buurman of de politie?");
        Terminal.WriteLine("Typ buurman voor je buurman");
        Terminal.WriteLine("of politie voor de politie");
    }

    void buurman()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt je buurman gebelt,");
        Terminal.WriteLine("die na 5 minuten voor je deur staat met een honkbal knuppel");
        Terminal.WriteLine("De inbreker heeft daarintegen een pistool, en schiet je buurman neer");
        Terminal.WriteLine("Je hoort hem schreeuwen van de pijn");
    }

    void politie()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt de politie gebeld");
        Terminal.WriteLine("Ze komen na 10 minutjes aan");
        Terminal.WriteLine("Ze pakken de inbreker op en hij krijgt 6 maanden voor inbraak");
        Terminal.WriteLine("Na een maandje ben je dit al helemaal weer vergeten,");
        Terminal.WriteLine("nadat je natuurlijk fortnite van je ps4 hebt verwijderd");
    }

    void renje()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je buurman is neergeschoten en je hebt niks,");
        Terminal.WriteLine("ren je weg of niet?");
        Terminal.WriteLine("typ renweg om te rennen en nietren om niet te rennen");
    }

    void nietren2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt ervoor gekozen om niet te rennen");
        Terminal.WriteLine("De inbreken vind je met zijn pistool en je sterft...");
    }

    void rug()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt ervoor gekozen om de inbreken in de rug te steken");
        Terminal.WriteLine("De inbreker sterft en je belt de politie");
        Terminal.WriteLine("Zijn familie doet een aanklacht die ze grandioos verliezen van je");
    }

    void frontaal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt ervoor gekozen om frontaal aan te vallen");
        Terminal.WriteLine("De inbreker heeft daarintegen een pistool en je sterft...");
    }
    // Update is called once per frame
    void Update()
    {

    }


}

