using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    /// <summary>
    /// contains user score and method to update score throughout the game
    /// </summary>
    public class HighScore
    {
        
        public DataGroup HighScoreModule(DataGroup datagroup)
        {
            Console.WriteLine(datagroup.newScore);
            return datagroup;
        }
    }
}
