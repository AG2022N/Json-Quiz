using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.IO;
class Program
{
    static void Main()
    {
        for (int i = 1; i < 5;)
        {
            string filePath = (@"Questions/question.json");
            Convert_json_to_cs(filePath);
            //Console.WriteLine(q.question);
            //string userAnswer = Console.ReadLine();
            //if userAnswer == q.correctAnswer , write q.correctAnswerExplanation
            i++;
        }
    }
    public class quizQuestion()
    {
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public string correctAnswerExplanation { get; set; }
    }
    static void Convert_json_to_cs(string filePath)
    {
        string path = filePath;
        string convertStorage = File.ReadAllText(path);
        quizQuestion q = Newtonsoft.Json.JsonConvert.DeserializeObject<quizQuestion>(convertStorage);
    }
}