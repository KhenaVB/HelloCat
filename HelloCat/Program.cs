internal class Program
{
    private static void Main(string[] args)
    {
        var questions = new List<Question>
        {
            new Question("question 1", "hoe oud is moesie in katten jaren?", "80"),
            new Question("question 2", "welk soort kat is moesie?", "cymric")
        };
        var correct = 0;
        foreach (var question in questions)
        {
            if (question.Ask())
            {
                correct++;
            }
            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine($"{correct} / {2}");
    }
}

internal class Question
{
    public string title, message, correct_antwoord;
    public Question(string title, string message, string correct_antwoord)
    {
        this.title = title;
        this.message = message;
        this.correct_antwoord = correct_antwoord;
    }
    public bool Ask()
    {
        Console.WriteLine(title);
        Console.WriteLine(message);

        if (Console.ReadKey().Equals(null))
        {

        }

        var answer = Console.ReadLine();

        if (string.Equals(answer, correct_antwoord, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("correct");
            return true;
        }
        else
        {
            Console.WriteLine("incorrect");
            return false;
        }
    }
}