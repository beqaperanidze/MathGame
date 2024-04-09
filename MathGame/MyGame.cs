namespace MathGame;

public class MyGame
{
    private static int _gameScore;

    public static void PlayGame()
    {
        _gameScore = 0;
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("____________________________________________________");
            Console.WriteLine($"Question {i + 1}:");
            Operation();
        }

        Console.WriteLine($"\n\nYour score is: {_gameScore}");
    }

    private static void Operation()
    {
        // 1 +
        // 2 -
        // 3 *
        // 4 /

        var op = new Random().Next(4);
        var a = new Random().Next(1, 10);
        var b = new Random().Next(1, 10);
        int realResult;

        switch (op)
        {
            case 0:
                realResult = a + b;
                Console.Write($"What is {a} + {b}? \t");
                
                Evaluate(realResult);
                
                break;
            case 1:
                realResult = a - b;
                Console.Write($"What is {a} - {b}? \t");
                
                Evaluate(realResult);
                
                break;
            case 2:
                realResult = a * b;
                Console.Write($"What is {a} * {b}? \t");

                Evaluate(realResult);

                break;
            case 3:
                realResult = a / b;
                Console.Write($"What is {a} / {b}? \t");

                Evaluate(realResult);

                break;
        }
    }

    private static void Evaluate(int realResult)
    {
        var input = Console.ReadLine();
        var parsed = int.TryParse(input, out var temp);
        while (!parsed)
        {
            Console.Write("Wrong input, please re-enter the answer.\t");
            input = Console.ReadLine();
            parsed = int.TryParse(input, out temp);
        }

        var playerResult = temp;

        if (realResult == playerResult)
        {
            _gameScore++;
        }
    }
}