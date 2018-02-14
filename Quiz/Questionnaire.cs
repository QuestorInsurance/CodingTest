using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuestionServiceWebApi
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public Dictionary<int, string> Questions { get; set; }
        public Dictionary<int, List<string>> AnswerOptions { get; set; }
    }
}