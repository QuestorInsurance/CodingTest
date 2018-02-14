using Xunit;
using QuestionServiceWebApi;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    public class QuestionRepositoryTests
    {
        [Fact]
        public void ShouldGetExpectedQuestions()
        {
            var questionRepository = new QuestionRepository();

            var questionDtoList = questionRepository.GetQuestions();

            Assert.Equal("Geography Questions", questionDtoList[0].QuestionCategory);
            Assert.Equal(1, questionDtoList[0].QuestionId);
            Assert.Equal("What is the capital of Cuba?", questionDtoList[0].QuestionTitle);
            Assert.Equal("Warsaw", questionDtoList[0].PossibleAnswers[0]);
            Assert.Equal("San José", questionDtoList[0].PossibleAnswers[1]);
            Assert.Equal("Bissau", questionDtoList[0].PossibleAnswers[2]);
            Assert.Equal("Havana", questionDtoList[0].PossibleAnswers[3]);
        }
    }
}