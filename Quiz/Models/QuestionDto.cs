using System.Collections.Generic;

namespace QuestionServiceWebApi.Models
{
    public class QuestionDto
    {
        public string QuestionCategory { get; set; }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public IList<string> PossibleAnswers { get; set; }
    }
}