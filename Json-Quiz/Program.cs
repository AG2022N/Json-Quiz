class Program
{
    static void Main()
    {
        string Filepath = (@"Questions");
        DirectoryInfo Directory = new DirectoryInfo(Filepath);
        FileInfo[] FileSearch = Directory.GetFiles("*", SearchOption.TopDirectoryOnly); //Could be more specific, i.e count only .json files
        for (int i = 1; i <= FileSearch.Length;)
        {
            string ReadJson = File.ReadAllText(Filepath + "/Question" + i + ".json");
            QuizQuestion CurrentQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(ReadJson);
            Console.Write(CurrentQuestion.Question + CurrentQuestion.AnswerOptions + CurrentQuestion.AnswerPrompt);
            string UserAnswer = Console.ReadLine(); Console.Write("\n");
            if (UserAnswer == CurrentQuestion.CorrectAnswer) 
            { 
                Console.WriteLine(CurrentQuestion.CorrectAnswerCongratulation); 
            }
            Console.Write(CurrentQuestion.CorrectAnswerExplanation);
            Console.ReadKey(); Console.WriteLine("\n");
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