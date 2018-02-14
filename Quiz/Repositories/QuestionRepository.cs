using System.Collections.Generic;
using QuestionServiceWebApi.Interfaces;
using QuestionServiceWebApi.Models;

namespace QuestionServiceWebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        public IList<QuestionDto> GetQuestions()
        {
            var questionList = new List<QuestionDto>
            {
                new QuestionDto
                {
                    QuestionCategory = "Geography Questions",
                    QuestionTitle = "What is the capital of Cuba?",
                    QuestionId = 1,
                    PossibleAnswers = new List<string>
                    {
                         "Warsaw",
                         "San José",
                         "Bissau",
                         "Havana"
                    }
                }
            };

            return questionList;
        }
    }
}