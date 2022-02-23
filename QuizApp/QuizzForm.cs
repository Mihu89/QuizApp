using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizzForm : Form
    {
        int timeToAnswer = 15;
        int currentQuestion = 0;
        int score = 0;
        public List<Question> Questions = new List<Question>();
        public QuizzForm()
        {
            InitializeComponent();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            // Get questions from DB or API
            var question = new Question(
                1,
                "What module do we learn now ?",
                "C#",
                "Winform",
                "Wpf",
                "Php",
                "Winform",
                5
                );
            Questions.Add(question);

            question = new Question(
                2,
                "What language do you like ?",
                "German",
                "Go",
                "C#",
                "Php",
                "C#",
                10
                );
            Questions.Add(question);

            question = new Question(
                3,
                "What is the capital of Great Britan",
                "Kiev",
                "Geneva",
                "Paris",
                "London",
                "London",
                10
                );
            Questions.Add(question);

            question = new Question(
                4,
                "What is the price of gas ?",
                "4.77",
                "16",
                "11",
                "20",
                "4.77",
                10
                );
            Questions.Add(question);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lQuizz.Visible = false;
            btnStart.Visible = false;
            tbTimer.Visible = true;
            panel.Visible = true;
            timerQuizz.Start();

            // Show first Question
            LoadQuestion(0);
            
        }
        private void LoadQuestion(int index)
        {
            lQuestion.Text = Questions[index].Id + ". " + Questions[index].Text;
            lChoiceA.Text = Questions[index].ChoiceA;
            lChoiceB.Text = Questions[index].ChoiceB;
            lChoiceC.Text = Questions[index].ChoiceC;
            lChoiceD.Text = Questions[index].ChoiceD;
            timeToAnswer = Questions[index].TimeToAnswer;
            tbTimer.Text = timeToAnswer.ToString();
            timerQuizz.Start();
        }

        private void timerQuizz_Tick(object sender, EventArgs e)
        {
            timeToAnswer--;
            tbTimer.Text = timeToAnswer.ToString();
            if (timeToAnswer == 0)
            {
                timerQuizz.Stop();
                currentQuestion++;
                btnNext_Click(this, new EventArgs());
                
            }
            if (timeToAnswer == 10)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void btnChoiceA_Click(object sender, EventArgs e)
        {
            if (lChoiceA.Text == Questions[currentQuestion].Answer)
            {
                score++;
            }
            currentQuestion++;
            btnNext_Click(this, new EventArgs());
        }

        private void btnChoiceB_Click(object sender, EventArgs e)
        {
            if (lChoiceB.Text == Questions[currentQuestion].Answer)
            {
                score++;
            }
            currentQuestion++;
            btnNext_Click(this, new EventArgs());
        }

        private void btnChoiceC_Click(object sender, EventArgs e)
        {
            if (lChoiceC.Text == Questions[currentQuestion].Answer)
            {
                score++;
            }
            currentQuestion++;
            btnNext_Click(this, new EventArgs());
        }

        private void btnChoiceD_Click(object sender, EventArgs e)
        {
            if (lChoiceD.Text == Questions[currentQuestion].Answer)
            {
                score++;
            }
            currentQuestion++;
            btnNext_Click(this, new EventArgs());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestion < Questions.Count)
            {
                LoadQuestion(currentQuestion);
            }
            else
            {
                timerQuizz.Stop();
                MessageBox.Show("Your score is " + score);
            }
            
        }
    }
}
