using QuestionServiceWebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuestionServiceWebApi.Models;
using System.Collections.Generic;

namespace QuestionServiceWebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public QuestionsController() : this(new QuestionRepository())
        {
        }

        // GET api/questions
        [HttpGet]
        public IList<QuestionDto> Get()
        {
            return _questionRepository.GetQuestions();
        }

        // GET api/questions/5
        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return string.Empty;
        }

        // POST api/questions
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/questions/5
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
