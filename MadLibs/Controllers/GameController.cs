using System;
using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class GameController : Controller
    {
        [HttpGet("/game")]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet("/game/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        
        [HttpPost("/game/story")]
        public ActionResult Story(string myNoun, string myVerb, string myAdjective, string myAdverb, string myExclammation)
        {
            MyMadLibs newMadLib = new MyMadLibs(myNoun, myVerb, myAdjective, myAdverb, myExclammation);
            return View(newMadLib);
        }
    }
}