using Microsoft.Maui.Controls;
using Question.Models;
using Question.Services;
using System.Collections;
using System.Text.Json;

namespace Question
{
    public partial class MainPage : ContentPage
    {
        private const int totalQuestionsGame = 5;

        private List<QuestionModel> questions;
        private Queue<int> selecedQuestionIds = new Queue<int>();
        private int currentQuestionIndex = 0;
        private int selectedQuestionIndex = 0;
        private int score = 0;
        private int previeusQuestionId = 0;
        private Random random = new Random();
        private QuestionDb questionDb;
        private Button[] answearButtons = new Button[3];

        public MainPage()
        {
            InitializeComponent();

            this.questionDb = new QuestionDb();
            LoadQuestions();
            DisplayQuestion();
        }

        void LoadQuestions()
        { 
            questions = JsonSerializer.Deserialize<List<QuestionModel>>(questionDb.GetAllQuestionsJson());

            for (int i = 0; i < totalQuestionsGame; i++)
            {
                int randomId = this.random.Next(0, questions.Count - 1);
                while (randomId == this.previeusQuestionId)
                {
                    randomId = this.random.Next(0, questions.Count - 1);
                }

                this.selecedQuestionIds.Enqueue(randomId);
            }
        }

        void DisplayQuestion()
        {
            if (currentQuestionIndex >= totalQuestionsGame)
            {
                QuestionLabel.Text = "Край!";
                ScoreLabel.Text = $"Score: {score}/{totalQuestionsGame} correct answers";
                ScoreLabel.IsVisible = true;

                int percent = (int) ((double)score / totalQuestionsGame * 100);

                if (percent == 100)
                {
                    ScoreImage.Source = "exellent.gif";
                }
                else if (percent >= 80 && percent < 100)
                {
                    ScoreImage.Source = "let_go.gif";
                }
                else if (percent > 40 && percent < 80)
                {
                    ScoreImage.Source = "good.gif";
                }
                else if (percent > 20 && percent <= 40)
                {
                    ScoreImage.Source = "really.gif";
                } else
                {
                    ScoreImage.Source = "bad.gif";
                }

                foreach (var button in answearButtons)
                {
                    button.IsVisible = false;
                }

                NextButton.IsVisible = false;
                ResetGame.IsVisible = true;
                return;
            }


            int questionId = this.selecedQuestionIds.Dequeue();

            QuestionModel q = questions[questionId];
            this.previeusQuestionId = questionId;
            this.selectedQuestionIndex = questionId;

            QuestionLabel.Text = q.QuestionText;

            answearButtons[0] = AnswerButton1;
            answearButtons[1] = AnswerButton2;
            answearButtons[2] = AnswerButton3;

            for (int i = 0; i < q.Answers.Count; i++)
            {
                answearButtons[i].Text = q.Answers[i].AnswerText;
                answearButtons[i].BackgroundColor = Colors.Gray;
            }

            EnableAnswerButtons(true);
            NextButton.IsVisible = false;
        }

        void OnAnswerClicked(object sender, EventArgs e)
        {
            var selectedButton = (Button)sender;
            var selectedIndex = 0;

            for (int i = 0; i < answearButtons.Length; i++)
            {
                if (answearButtons[i] == selectedButton)
                {
                    selectedIndex = i + 1;
                }
            }

            var correct = questions[selectedQuestionIndex].CorrectOptionNumber;
            if (selectedIndex == correct)
            {
                selectedButton.BackgroundColor = Colors.Green;
                selectedButton.TextColor = Colors.White;
                score++;
            }
            else
            {
                for (int i = 0; i < answearButtons.Length; i++)
                {
                    if (correct != i + 1)
                    {
                        answearButtons[i].BackgroundColor = Colors.Red;
                        answearButtons[i].TextColor = Colors.White;
                    }
                }


                // Also show correct answer
                answearButtons[correct - 1].BackgroundColor = Colors.Green; 
                answearButtons[correct - 1].TextColor = Colors.White;
            }

            EnableAnswerButtons(true);
            NextButton.IsVisible = true;
        }

        void EnableAnswerButtons(bool enable)
        {
            foreach (var button in answearButtons)
            {
                button.IsEnabled = enable;
            }
        }

        void OnNextClicked(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

        void OnResetClicked(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;

            ScoreLabel.IsVisible = false;
            foreach (var button in answearButtons)
            {
                button.IsVisible = true;
            }

            NextButton.IsVisible = false;
            ResetGame.IsVisible = false;

            LoadQuestions();
            DisplayQuestion();
        }
    }

}
