using QuestionServiceWebApi.Interfaces;
using QuestionServiceWebApi.Models;
using System.Collections.Generic;

namespace QuestorTest.Unit.Tests.QuestionServiceWebApi.Stubs
{
    public class FakeQuestionRepository : IQuestionRepository
    {
        public IList<QuestionDto> ExpectedQuestions { get; set; }
        public IList<QuestionDto> GetQuestions()
        {
            return ExpectedQuestions;
        }
    }
}