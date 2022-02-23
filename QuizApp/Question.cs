using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
        public string Answer { get; set; }
        public int TimeToAnswer { get; set; }
        public Question(int id, string text, string choiseA, string choiseB, string choiseC, string choiseD, string answer, int timeToAnswer)
        {
            Id = id;
            Text = text;
            ChoiceA = choiseA;
            ChoiceB = choiseB;
            ChoiceC = choiseC;
            ChoiceD = choiseD;
            Answer = answer;
            TimeToAnswer = timeToAnswer;
        }
    }
}
