
namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        
        if (numbers == "")
        {
            return 0;
        }
        
        char[] delims = {  ',' , '\n'};

        return numbers.Split(delims).Select(int.Parse).Sum(); // Sum them up!
    }

    
}

