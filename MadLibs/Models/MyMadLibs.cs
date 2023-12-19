using System;


namespace MadLibs.Models
{
    public class MyMadLibs
    {
        public string Noun { get; set; }
        public string Verb { get; set; }
        public string Adjective { get; set; }
        public string Adverb { get; set; }
        public string Exclammation { get; set; }

        public MyMadLibs(string myNoun, string myVerb, string myAdjective, string myAdverb, string myExclammation)
        {
            Noun = myNoun;
            Verb = myVerb;
            Adjective = myAdjective;
            Adverb = myAdverb;
            Exclammation = myExclammation;
        } 

        
    }
}