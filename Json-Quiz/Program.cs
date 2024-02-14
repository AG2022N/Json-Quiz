class Program
{
    static void Main()
    {
        string Filepath = (@"Questions");
        DirectoryInfo Directory = new DirectoryInfo(Filepath);
        FileInfo[] FileSearch = Directory.GetFiles("*", SearchOption.TopDirectoryOnly);
        for (int i = 1; i <= FileSearch.Length;)
        {
            string ReadJson = File.ReadAllText(Filepath + "/Question" + i + ".json");
            QuizQuestion CurrentQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(ReadJson);
            Console.WriteLine(CurrentQuestion.Question + " \n" + CurrentQuestion.AnswerOptions);
            Console.Write("\n" + CurrentQuestion.AnswerPrompt);
            string UserAnswer = Console.ReadLine();
            if (UserAnswer == CurrentQuestion.CorrectAnswer) 
            {
                Console.WriteLine(CurrentQuestion.CorrectAnswerCongratulation);
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
        public string AnswerPrompt { get; set; }
        public string CorrectAnswer { get; set; }
        public string CorrectAnswerCongratulation { get; set; }
        public string CorrectAnswerExplanation { get; set; }
    }
}