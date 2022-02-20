using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblem
{
    /// <summary>
    /// Class to check a message, ability to analyse and respond happy or sad Mood
    /// </summary>
    public class Mood
    {
        //Declaring varibale
        public string message;
        //Constructor to initialize message 
        public Mood(string message)
        {
            this.message = message;
        }
        //Method to analyse the mood from  the given message
        public string AnalyseMood()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}