using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
