using Xunit;
using QuestorTest.Unit.Tests.QuestionServiceWebApi.Stubs;
using QuestionServiceWebApi.Controllers;
using QuestionServiceWebApi.Models;
using System.Collections.Generic;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    public class QuestionsControllerTests
    {
        [Fact]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedCategory = "Expected category";
            var expectedQuestionId = 1;

            var expectedQuestions = new List<QuestionDto> { new QuestionDto { QuestionId = expectedQuestionId, QuestionCategory = expectedCategory } };
            var fakeQuestionRepository = new FakeQuestionRepository() {ExpectedQuestions = expectedQuestions};
            var questionsController = new QuestionsController(fakeQuestionRepository);

            //Act
            var questions = questionsController.Get();

            //Assert
            Assert.Equal(questions[0].QuestionCategory, expectedCategory);
            Assert.Equal(questions[0].QuestionId, expectedQuestionId);
        }
    }
}