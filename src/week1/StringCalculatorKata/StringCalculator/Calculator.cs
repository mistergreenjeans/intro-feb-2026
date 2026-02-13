
public class Calculator
{
    public int Add(string numbers)
    {
        char[] del = { ',', '\n'};
        var nums = numbers.Split(del);
        var sum = 0;

        foreach (var number in nums)
        {
            var current = 0;
            if (int.TryParse(number, out current))
            {
                sum += current; 
            }
        }
        
        return sum;
    }
}
