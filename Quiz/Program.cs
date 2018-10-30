using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods game = new Methods();
            DataGroup datagroup = new DataGroup();
            UserScore newScore = new UserScore();
            HighScore highScore = new HighScore();
            
            // call calculate score method
            datagroup = game.FileReadingAndListReturn(datagroup);
            

            //Kalder brugerInput.
            Methods brugerInput = new Methods();
            var input = brugerInput.BrugerInput(datagroup);

            newScore = newScore.CalculateScore(newScore, input);
            
            highScore.HighScoreModule(datagroup,newScore);
        }
    }

    class Methods
    {
        public void test()
        {

        }

        public DataGroup FileReadingAndListReturn(DataGroup dataGroup)
        {
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
                //Dette er for at slette tidligere spørgsmål og svar
                Thread.Sleep(1000);
                Console.Clear();

                //Splitter spørgmål fra svar.
                string[] questions = dataGroup.questions[i].Split(',');

                //Holder quizzen kørende.
                bool quizRunning = true;

                while (quizRunning)
                {
                    //Stiller et spørgsmål.
                    Console.WriteLine(questions[0]);
                    
                    //Tager imod bruger input, dette er et trimmet input.
                    string brugerInput = UdvidetTrim(Console.ReadLine());

                    //If saetning der tjekker om svaret er sandt eller falsk.
                    if (brugerInput.ToLower() == "yes")
                    {
                        //Besked ved svar 'Yes'.
                        Console.WriteLine("You answered Yes.");

                        //Add Yes to the List called quesses which is located inside Datagroup class.
                        dataGroup.guesses.Add("Yes");
                        quizRunning = false;
                    }
                    else if (brugerInput.ToLower() == "no")
                    {
                        //Besked ved svar 'No'.
                        Console.WriteLine("You answered No.");

                        //Add No to the List called quesses which is located inside Datagroup class.
                        dataGroup.guesses.Add("No");
                        quizRunning = false;
                    }
                    else
                    {
                        //Besked ved forkert input.
                        Console.WriteLine("Write the answer as: 'Yes' / 'No'.");
                        //Dette er for at slette tidligere spørgsmål og svar
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
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

}