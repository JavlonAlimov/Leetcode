public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public int[] PlusOne(int[] digits)
    {
        // Array'ni oxiridan boshlab yurgazamiz
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits; // Increment qilingandan keyin natijani qaytaramiz
            }
            digits[i] = 0; // 9 bo'lsa, 0 ga aylantiramiz va oldingi raqamga o'tamiz
        }

        // Agar hamma raqamlar 9 bo'lsa, yangi array yaratamiz
        int[] newNumber = new int[digits.Length + 1];
        newNumber[0] = 1; // Birinchi raqam 1 bo'ladi
        return newNumber; // Barcha boshqa raqamlar 0 bo'lib qoladi
    }
}
