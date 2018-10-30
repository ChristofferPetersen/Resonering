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
            Methods game = new Methods();
            DataGroup datagroup = new DataGroup();
            // initialize score for a new game
            UserScore newScore = new UserScore();
            HighScore highScore = new HighScore();
            
            // call calculate score method
            datagroup = game.FileReadingAndListReturn(datagroup);

            DataGroup test = new DataGroup();
            test.questions = new List<string> { "test", "hej"};

            //Kalder brugerInput.
            Methods brugerInput = new Methods();
            var input = brugerInput.BrugerInput(test);

            //newScore = newScore.CalculateScore(newScore, datagroup);
      
                     
            datagroup = highScore.HighScoreModule(datagroup);
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
            string[] fileArray = File.ReadAllLines("../../questions.txt");
            for (int i = 0; i < fileArray.Length; i+=1)
            {
                dataGroup.questions.Add(fileArray[i]);
            }
            return dataGroup;
        }

        public DataGroup BrugerInput(DataGroup dataGroup)
        {
            //Loop der køre gennem alle spørgsmål.
            for (int i = 0; i < dataGroup.questions.Count; i++)
            {
                Console.WriteLine(dataGroup.questions[i]);

                //Tager imod bruger input, dette er et trimmet input.
                string brugerInput = UdvidetTrim(Console.ReadLine());

                //If saetning der tjekker om svaret er sandt eller falsk.
                if (brugerInput.ToLower() == "yes")
                {
                    //Besked ved svar 'Yes'.
                    Console.WriteLine("You answered Yes.");

                    //Add Yes to the List called quesses which is located inside Datagroup class.
                    dataGroup.guesses.Add("Yes");
                }
                else if (brugerInput.ToLower() == "no")
                {
                    //Besked ved svar 'No'.
                    Console.WriteLine("You answered No.");

                    //Add No to the List called quesses which is located inside Datagroup class.
                    dataGroup.guesses.Add("No");
                }
                else
                {
                    //Besked ved forkert input.
                    Console.WriteLine("Write the answer as: 'Yes' / 'No'.");
                }
            }            
            return dataGroup;
            
        }

        public void CheckerAntalRigtige()
        {

        }
        /*
        public DataGroup DisplayHighscores(DataGroup datagroup)
        {
            //datagroup.questions[0] = "kage,j";
            //datagroup.quesses[0] = "j";
            //File.ReadAllLines("highscore.txt");
            Console.WriteLine("hej");

            return datagroup;
        }
        */
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
    public int newScore=0;

}