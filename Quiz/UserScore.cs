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
    public class UserScore
    {
        public int CorrectAnswers = 0;
        public List<string> WrongAnswers = new List<string>();

        // method to calculate and update score after each question
        public UserScore CalculateScore(UserScore score, string question, string rightAnswer, string userAnswer)
        {
            if (rightAnswer == userAnswer) score.CorrectAnswers++;
            else score.WrongAnswers.Add(question);
            return score;
        }
    }
}
