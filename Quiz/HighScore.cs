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
            readFile(datagroup);
            return datagroup;
        }

        public string readFile(DataGroup dataGroup)
        {
            string file = "../../highscore.txt";
            if (File.Exists(file))
            {
                string fileContent = File.ReadAllText(file).Replace("\r", "");
                //string[] lines = fileContent.Split("\n");
                //foreach (string value in lines) Console.WriteLine(value+"\n");
            }
            else
                File.OpenWrite(file);

            return "";
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
