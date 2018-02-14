using QuestionServiceWebApi.Models;
using System.Collections.Generic;

namespace QuestionServiceWebApi.Interfaces
{
    public interface IQuestionRepository
    {
        IList<QuestionDto> GetQuestions();
    }
}