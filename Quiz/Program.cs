using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize score for a new game
            UserScore newScore = new UserScore();

            // call calculate score method
            newScore = newScore.CalculateScore(newScore, "test question", "ja", "ja");
        }
    }

    class Methods
    {

        public void FilMedSvar()
        {

        }

        public void FileReadingAndListReturn()
        {
            string path; //Stien til sp�rgsm�l og svar filen
        }

        public void BrugerInput()
        {
            //Tager imod bruger input.
            string brugerInput = Console.ReadLine();
            
            //If s�tning der tjekker om svaret er sandt eller falsk.
            if (brugerInput == "Yes")
            {   //Besked ved svar 'Yes'.
                Console.WriteLine("You answered Yes.");
            }
            else if (brugerInput == "No")
            {   //Besked ved svar 'No'.
                Console.WriteLine("You answered No.");
            }
            else
            {   //Besked ved forkert input.
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
