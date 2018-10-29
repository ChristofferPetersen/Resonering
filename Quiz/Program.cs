using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Methods
    {
        class Program
        {
            static void Main(string[] args)
            {
                
            }
        }


        public void FilMedSvar()
        {

        }

        public void LæseOgReturnereListMedSpørgsmålOgSvar()
        {

        }

        public void BrugerInput()
        {
            //Tager imod bruger input.
            string brugerInput = Console.ReadLine();
            
            //If sætning der tjekker om svaret er sandt eller falsk.
            if (brugerInput == "Yes")
            {
                Console.WriteLine("You answered Yes.");
            }
            else if (brugerInput == "No")
            {
                Console.WriteLine("You answered No.");
            }
            else
            {
                Console.WriteLine("Skriv svaret som enten 'Yes' / 'No'.");
            }
            
        }

        public void CheckerAntalRigtige()
        {

        }

        public void OpretteHenteOgGemmeHighscores()
        {
            File.ReadAllLines("highscore.txt");
        }
    }
}
