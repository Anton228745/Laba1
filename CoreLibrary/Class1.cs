namespace CoreLibrary;

public class NumberSequence
{
    /// <summary>
    /// Формирует строку из чисел от 1 до N, разделенных запятыми.
    /// </summary>
    public static string Generate(int n)
    {
        if (n <= 0) return string.Empty;
        // Собираем числа через запятую
        var numbers = new string[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = (i + 1).ToString();
        }
        return string.Join(", ", numbers);
    }
}