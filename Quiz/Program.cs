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
            DataGroup datagroup = new DataGroup();
            // initialize score for a new game
            UserScore newScore = new UserScore();

            // call calculate score method
            newScore = newScore.CalculateScore(newScore, "test question", "ja", "ja");
            Methods game = new Methods();
            datagroup=game.DisplayHighscores(datagroup);
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

        public DataGroup DisplayHighscores(DataGroup datagroup)
        {
            //datagroup.questions[0] = "kage,j";
            //datagroup.quesses[0] = "j";
            //File.ReadAllLines("highscore.txt");
            Console.WriteLine("hej");

            return datagroup;
        }

        public string UdvidetTrim(string brugerInput)
        { //Funktion der fjerner overfloedige mellemrum fra input.
            //Variabler der styre hvilket stadie input er i.
            string trimmetInput = brugerInput.Trim();
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

public class DataGroup
{
    public List<string> questions = new List<string>();
    public List<string> quesses = new List<string>();
}