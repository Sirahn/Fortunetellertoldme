﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortunetellertoldme
{
    class Program
    {


        static void Main(string[] args)
        {
            //our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();
            fortuneTeller.Greet(); //say hi
            fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed
            crystalBall.Work(); //run it (do the service)
            TarotCards tarotCards = new TarotCards();
            fortuneTeller.StartService((Service)tarotCards);
            tarotCards.Work();
            tarotCards.Show();
            tarotCards.StateEffectiveness();
            crystalBall.Show(); //display it (state results of the service)
            crystalBall.StateEffectiveness(); //state effectiveness of service.
     
            fortuneTeller.Farewell(); //say goodbye.

        }

    }
    
}
