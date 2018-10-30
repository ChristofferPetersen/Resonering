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
        
        public DataGroup HighScoreModule(DataGroup datagroup)
        {
            //Console.WriteLine(datagroup.newScore);
            List<string> highscorelist = new List<string>();
            highscorelist=readFile(datagroup);

            datagroup.newScore = 5;

            highscorelist =checkScore(highscorelist, datagroup.newScore);
            return datagroup;
        }

        public List<string> readFile(DataGroup dataGroup)
        {
            List<string> highscorelist = new List<string>();
            string file = "../../highscore.txt";
            if (File.Exists(file))
            {
                string fileContent = File.ReadAllText(file).Replace("\r", "");
                string[] lines = fileContent.Split('\n');
                foreach (string value in lines)
                {
                    Console.WriteLine(value.Split(',')[0] + " - " + value.Split(',')[1]);
                    highscorelist.Add(value);
                }
            }
            else
                File.OpenWrite(file);

            return highscorelist;
        }

        public List<string> checkScore(List<string> highscorelist,int score)
        {
            List<string> NyHighScoreList = new List<string>();
            foreach (string linje in highscorelist)
            {
                //if(linje.Split[1]<score)
            }
            return highscorelist;
        }
            /*
            public void writeFile(DataGroup dataGroup)
            {
                string[] listeArr = dataGroup.list.Split(",");
                //foreach (string value in listeArr) File.AppendAllText(dataGroup.path+dataGroup.filename,value+"\n");
                File.WriteAllLines(dataGroup.path + dataGroup.filename, listeArr);
            }
            */
        }
}
