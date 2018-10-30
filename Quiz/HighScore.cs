using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    /// <summary>
    /// contains user score and method to update score throughout the game
    /// </summary>
    public class HighScore
    {
        
        public void HighScoreModule(DataGroup datagroup, UserScore score)
        {
            List<string> highscorelist = new List<string>();
            highscorelist=readFile(datagroup);
            highscorelist =checkScore(highscorelist, score.CorrectAnswers);
            writeFile(highscorelist);
            if (score.WrongAnswers.Count() > 0)
                ShowWrongAnswers(score);
        }

        public void ShowWrongAnswers(UserScore score)
        {
            foreach (string value in score.WrongAnswers)
            {
                Console.WriteLine(value+"\n");
            }
        }

        public List<string> readFile(DataGroup dataGroup)
        {
            List<string> highscorelist = new List<string>();
            string file = "../../highscore.txt";
            int i = 1;
            if (File.Exists(file))
            {
                string fileContent = File.ReadAllText(file).Replace("\r", "");
                string[] lines = fileContent.Split('\n');
                foreach (string value in lines)
                {
                    if (value != "")
                    {
                        Console.WriteLine(i + " - " + value.Split(',')[0] + " - " + value.Split(',')[1]);
                        highscorelist.Add(value);
                        i++;
                    }
                }
            }
            else
                File.OpenWrite(file);

            return highscorelist;
        }

        public void writeFile(List<string> highscorelist)
        {
            File.WriteAllLines("../../highscore.txt", highscorelist);
        }

        public List<string> checkScore(List<string> highscorelist,int score)
        {
            List<string> NyHighScoreList = new List<string>();
            foreach (string linje in highscorelist)
            {
                if (Int32.Parse(linje.Split(',')[1]) > score)
                {
                    NyHighScoreList.Add(linje);
                }
                else
                {
                    Console.WriteLine("Skriv dit navn");
                    string navn = Console.ReadLine();
                    NyHighScoreList.Add(navn+","+score);
                    NyHighScoreList.Add(linje);
                    score = -1;
                }
            }
            return NyHighScoreList;
        }

        }
}
