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


        [HttpGet("/game/new-myself")]
        public ActionResult CreateFormSelf()
        {
            
            return View();
        }

        [HttpGet("/game/new-mydog")]
        public ActionResult CreateFormDog()
        {
            
            return View();
        }

        [HttpGet("/game/new-myfather")]
        public ActionResult CreateFormFather()
        {
            
            return View();
        }
        
        [HttpPost("/game/selfStory")]
        public ActionResult MyselfStory(string myNoun, string myVerb, string myAdjective, string myAdverb, string myExclammation)
        {
            MyMadLibs newMadLib = new MyMadLibs(myNoun, myVerb, myAdjective, myAdverb, myExclammation);
            return View(newMadLib);
        }

        [HttpPost("/game/dogStory")]
        public ActionResult MydogStory(string myNoun, string myVerb, string myAdjective, string myAdverb, string myExclammation)
        {
            MyMadLibs newMadLib = new MyMadLibs(myNoun, myVerb, myAdjective, myAdverb, myExclammation);
            return View(newMadLib);
        }

        [HttpPost("/game/fatherStory")]
        public ActionResult MyFatherStory(string myNoun, string myVerb, string myAdjective, string myAdverb, string myExclammation)
        {
            MyMadLibs newMadLib = new MyMadLibs(myNoun, myVerb, myAdjective, myAdverb, myExclammation);
            return View(newMadLib);
        }
    }
}