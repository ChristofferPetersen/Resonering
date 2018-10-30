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
        public UserScore CalculateScore(UserScore score, DataGroup data)
        {
            int i = 0;
            foreach(var question in data.questions)
            {
                var splitData = question.Split(',');
                // question = splitData[0]
                // correct answer = splitData[1]
                // user answer = data.guesses[i]
                if (splitData[1] == data.guesses[i]) score.CorrectAnswers++;
                else score.WrongAnswers.Add(splitData[0]);
                i++;
            }
            return score;
        }
    }
}
