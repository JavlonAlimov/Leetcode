public class Solution
{
    public int[] PlusOne(int[] digits)
    {

        string result = string.Join(string.Empty, digits);

        int numbers = int.Parse(result);

        numbers += 1;

        string numberString = numbers.ToString();


        int[] resultArray = numberString.Select(digit => int.Parse(digit.ToString())).ToArray();
        return resultArray;
    }
}