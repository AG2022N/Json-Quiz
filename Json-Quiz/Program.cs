class Program
{
    static void Main()
    {
        for (int i = 1; i <= 6;)
        {
            string Filepath = (@"Questions/Question" + i + ".json");
            string ConvertStorage = File.ReadAllText(Filepath);
            QuizQuestion CurrentQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(ConvertStorage);
            Console.WriteLine(CurrentQuestion.Question);
            Console.WriteLine(CurrentQuestion.AnswerOptions);
            Console.Write("\nIndtast: ");
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