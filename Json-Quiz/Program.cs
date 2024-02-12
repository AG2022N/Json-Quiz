class Program
{
    static void Main()
    {
        for (int i = 1; i <= 6;)
        {
            string ReadJson = File.ReadAllText(@"Questions/Question" + i + ".json");
            QuizQuestion CurrentQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(ReadJson);
            Console.WriteLine(CurrentQuestion.Question + " \n" + CurrentQuestion.AnswerOptions);
            Console.Write("\nVælg: ");
            string UserAnswer = Console.ReadLine();
            if (UserAnswer == CurrentQuestion.CorrectAnswer)
            {
                Console.WriteLine("Korrekt!");
            }
            Console.Write(CurrentQuestion.CorrectAnswerExplanation);
            Console.ReadKey();
            Console.WriteLine("\n");
            i++;
        }
    }
    public class QuizQuestion()
    {
        public string Question { get; set; }
        public string AnswerOptions { get; set; }
        public string CorrectAnswer { get; set; }
        public string CorrectAnswerExplanation { get; set; }
    }
}