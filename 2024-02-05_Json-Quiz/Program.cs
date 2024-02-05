class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5;)
        {
            string Filepath = (@"Questions/Question" + i + ".json");
            JsonToObject(Filepath);
            //Console.WriteLine(q.Question);
            //string UserAnswer = Console.ReadLine();
            //if (UserAnswer == q.CorrectAnswer)
            //{
            //    Console.WriteLine("Correct!");
            //}
            //Console.WriteLine(q.CorrectAnswerExplanation)
            Console.ReadKey();
            Console.Clear();
            i++;
        }
    }
    public class QuizQuestion()
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string CorrectAnswerExplanation { get; set; }
    }
    static void JsonToObject(string Filepath)
    {
        string Path = Filepath;
        string ConvertStorage = File.ReadAllText(Path);
        QuizQuestion q = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(ConvertStorage);
    }
}