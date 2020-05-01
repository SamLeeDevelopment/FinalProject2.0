using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Final_Project.Algorithm;
using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project.Controllers
{
    public class SolverController : Controller
    {
        public AnswerFinder _answerFinder;
        public Log _logger;

        public SolverController ()
        {
            this._answerFinder = new AnswerFinder();
            this._logger = new Log();
        }

        [Authorize]
        public IActionResult History()
        {
            List<Question> models = new List<Question>();
            List<string> data = _logger.getData(User.FindFirstValue(ClaimTypes.NameIdentifier));
            for(int i = data.Count-1; i > 0; i -= 2)
            {
                models.Add(new Question(data[i], data[i-1]));
            }

            return View(models);
        }

        [HttpPost]
        public IActionResult Query(Query model)
        {
            //match the question asked to the user logged in
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //get the response from algorithm (xml)
            model.Response = _answerFinder.FindAnswers(model.Question, "sql");

            //parse xml into string to be displayed
            try
            {
                model.Answer = model.Response.Split("<Answer>")[1].Split("</Answer>")[0];
            } catch (Exception error)
            {
                model.Answer = "Sorry, we couldn't find anything.";
            }


            //log info to the user's file
            if(model.UserId != null) _logger.StoreInfo(model.UserId, model.Question, model.Answer);

            return View(model);
        }
    }
}