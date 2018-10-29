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

        public void test()
        {

        }

        public void FileReadingAndListReturn()
        {
            string path; //Stien til sp�rgsm�l og svar filen
        }

        public void BrugerInput()
        {
            //Tager imod bruger input, dette er et trimmet input.
            string brugerInput = UdvidetTrim(Console.ReadLine());
            
            //If saetning der tjekker om svaret er sandt eller falsk.
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
                Console.WriteLine("Write the answer as: 'Yes' / 'No'.");
            }
            
        }

        public void CheckerAntalRigtige()
        {

        }

        public void OpretteHenteOgGemmeHighscores()
        {
            File.ReadAllLines("highscore.txt");
        }

        public string UdvidetTrim(string brugerInput)
        { //Funktion der fjerner overfloedige mellemrum fra input.
            //Variabler der styre hvilket stadie input er i.
            string trimmetInput = input.Trim();
            string gammeltInput;

            //Laver alle dobbelt mellemrum om til almindeligt mellemrum.
            do
            {
                gammeltInput = trimmetInput;
                trimmetInput = trimmetInput.Replace("  ", " ");
            }

            while (trimmetInput != gammeltInput);

            //Returnere det nye inputs string.
            return trimmetInput;
        }
    }
}
