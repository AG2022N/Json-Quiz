class Program
{
    static void Main()
    {
        for (int i = 1; i < 5;)
        {
            string filePath = (@"Questions/Question.json");
            //string filePath = (@"Questions/Question{0}.json", i.ToString());
            Convert_json_to_object(filePath);
            //Console.WriteLine(q.question);
            //string userAnswer = Console.ReadLine();
            //if (userAnswer == q.correctAnswer)
            //{
            //    Console.WriteLine("Correct!");
            //}
            //console.writeline(q.correctAnswerExplanation)
            Console.ReadKey();
            Console.Clear();
            i++;
        }
    }
    public class QuizQuestion()
    {
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public string correctAnswerExplanation { get; set; }
    }
    static void Convert_json_to_object(string filePath)
    {
        string path = filePath;
        string convertStorage = File.ReadAllText(path);
        QuizQuestion q = Newtonsoft.Json.JsonConvert.DeserializeObject<QuizQuestion>(convertStorage);
    }
}