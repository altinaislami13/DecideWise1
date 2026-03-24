public class ConsoleUI
{
    private DecisionService service;

    public ConsoleUI(DecisionService service)
    {
        this.service = service;
    }

    public void Start()
    {
        var option1 = new Option(1, "Job A");
        var option2 = new Option(2, "Job B");

        service.AddScore(option1, 8);
        service.AddScore(option2, 6);

        var best = service.ChooseBest(new List<Option> { option1, option2 });

        Console.WriteLine($"Best choice is: {best.Name}");
    }
}