using System;
using ProjetoJogoRPG.src.Entities;


namespace ProjetoJogoRPG
{
    class Program
    {
         static void Main(string[] args)
        {

            Knight hero = new Knight("Arus", 23, "Knight", 469);
            Wizard wizard = new  Wizard("Jennica", 56, "White Wizard", 325);
            Ninja nija = new Ninja("Wedge", 42, "Ninja", 292);
            BlackWizard blackWizard = new BlackWizard("Topapa", 89, "Black Wizard", 106);

            Console.WriteLine("***DUNGEON DIO***");
            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(nija.Attack());
            Console.WriteLine(blackWizard.Attack());
            


        }
    }
}


