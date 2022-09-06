using System;

namespace CSharp_Challenge_ImaginaryCodingInterview.classes
{
    public class Interview
    {
        // - Fields -
        private readonly int[] questions;
        private readonly int totalTime;
        private readonly bool[] interviewCriteria;
        private readonly bool isQualified;
        private readonly bool allQuestionsAnswered; //Checks to see if the interviewee answered all the questions

        // - Constructors -
        public Interview(int[] questions, int totalTime)
        {
            this.questions = questions;
            this.interviewCriteria = new bool[questions.Length];
            this.totalTime = totalTime;
            this.isQualified = false; //Default value

            if (questions.Length < 8)
            {
                this.allQuestionsAnswered = false;
                //Console.WriteLine("Not all questions were answered.");
            }
            else
            {
                this.allQuestionsAnswered = true;
                //Console.WriteLine("All questions answered.");
                for (int question = 0; question < questions.Length; question++) //Loop through the question arary
                {
                    switch (question) //Find which question in the questions array we are evaluating
                    {
                        case 0:
                            this.interviewCriteria[question] = CheckVeryEasy(question);
                            break;
                        case 1:
                            this.interviewCriteria[question] = CheckVeryEasy(question);
                            break;
                        case 2:
                            this.interviewCriteria[question] = CheckEasy(question);
                            break;
                        case 3:
                            this.interviewCriteria[question] = CheckEasy(question);
                            break;
                        case 4:
                            this.interviewCriteria[question] = CheckMedium(question);
                            break;
                        case 5:
                            this.interviewCriteria[question] = CheckMedium(question);
                            break;
                        case 6:
                            this.interviewCriteria[question] = CheckHard(question);
                            break;
                        case 7:
                            this.interviewCriteria[question] = CheckHard(question);
                            break;
                        default:
                            Console.WriteLine("Something went wrong. Closing application...");
                            Environment.Exit(0);
                            break;
                    }
                }
            }

            //Check if the interviewee is qualified
            if(this.interviewCriteria.All(element => element == true) && allQuestionsAnswered && this.totalTime <= 120)
            {
                this.isQualified = true;
            } else
            {
                this.isQualified = false;
            }

        }

        // - Methods -

        /// <summary>
        /// Returns a <c>bool</c> value checking if the question was answered in 5 minutes or less.
        /// </summary>
        /// <param name="question">Index used to find values in the questions array.</param>
        /// <returns><c>true</c> if criteria is met. Else returns <c>false</c></returns>
        private bool CheckVeryEasy(int question)
        {
            if (this.questions[question] >= 0 && this.questions[question] <= 5)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a <c>bool</c> value checking if the question was answered in 10 minutes or less.
        /// </summary>
        /// <param name="question">Index used to find values in the questions array.</param>
        /// <returns><c>true</c> if criteria is met. Else returns <c>false</c></returns>
        private bool CheckEasy(int question)
        {
            if (this.questions[question] >= 0 && this.questions[question] <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a <c>bool</c> value checking if the question was answered in 15 minutes or less.
        /// </summary>
        /// <param name="question">Index used to find values in the questions array.</param>
        /// <returns><c>true</c> if criteria is met. Else returns <c>false</c></returns>
        private bool CheckMedium(int question)
        {
            if (this.questions[question] >= 0 && this.questions[question] <= 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a <c>bool</c> value checking if the question was answered in 20 minutes or less.
        /// </summary>
        /// <param name="question">Index used to find values in the questions array.</param>
        /// <returns><c>true</c> if criteria is met. Else returns <c>false</c></returns>
        private bool CheckHard(int question)
        {
            if (this.questions[question] >= 0 && this.questions[question] <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // - Properties -
        public bool IsQualified
        {
            get { return this.isQualified; }
        }
    }
}

