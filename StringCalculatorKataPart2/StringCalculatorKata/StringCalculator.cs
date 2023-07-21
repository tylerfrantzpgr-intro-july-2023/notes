

namespace StringCalculatorKata;

public class StringCalculator
{
    private readonly Logger _logger;
    public StringCalculator(Logger logger)
    {
        _logger = logger;
    }
    public int Add(string numbers) { 


        int result = 0;
        if (numbers == "")
        {
            return 0;
        }

        _logger.Log(result.ToString());

        return numbers.Split(',') // ["108"]
                .Select(int.Parse) // [ 108 ]
                .Sum(); // Sum them up!
    }

    public class Logger : ILogger
    {



        public void Log(string message)
        {
            // Your specific logging thing here
            Console.WriteLine(message);
        }
    }
}

