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
            newScore = newScore.CalculateScore(newScore, datagroup);
            Methods game = new Methods();
            datagroup = game.DisplayHighscores(datagroup);
        }
    }

    class Methods
    {
        public void test()
        {

        }

        public DataGroup FileReadingAndListReturn(DataGroup dataGroup)
        {
            //Fix for spaden der �del�gger
            string[] fileArray = File.ReadAllLines("questions.txt");
            for (int i = 0; i < fileArray.Length; i+=1)
            {
                dataGroup.questions[i] = fileArray[i];
            }
            return dataGroup;
        }

        public bool BrugerInput()
        {
            //Tager imod bruger input, dette er et trimmet input.
            string brugerInput = UdvidetTrim(Console.ReadLine());

            //Lav nyt objekt kaldet datagroup, for at få adgang til listen quesses
            DataGroup dataGroup = new DataGroup();

            //If saetning der tjekker om svaret er sandt eller falsk.
            if (brugerInput == "Yes")
            {   
                //Besked ved svar 'Yes'.
                Console.WriteLine("You answered Yes.");

                //Add Yes to the List called quesses which is located inside Datagroup class.
                dataGroup.guesses.Add("Yes");

                //Returnere en true status på svaret, indikere at svaret er 'Yes'.
                return true;
            }
            else if (brugerInput == "No")
            {   
                //Besked ved svar 'No'.
                Console.WriteLine("You answered No.");

                //Add No to the List called quesses which is located inside Datagroup class.
                dataGroup.guesses.Add("No");

                //Returnere en false status på svaret, indikere at svaret er 'No'.
                return false;
            }
            else
            {   
                //Besked ved forkert input.
                Console.WriteLine("Write the answer as: 'Yes' / 'No'.");

                //Den returnere en false ellers brokker metoden sig over at den ikke returnere noget data.
                return false;
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
    public List<string> guesses = new List<string>();
}