namespace CoreLibrary;

public class StarSquare
{
    /// Формирует квадрат из звёздочек со стороной N без центрального элемента.
    /// <param name="n">Нечётное положительное целое число.</param>
    public static string Generate(int n)
    {
        if (n <= 0 || n % 2 == 0)
        {
            throw new ArgumentException("Число N должно быть положительным и нечётным.");
        }

        var lines = new string[n];
        int center = n / 2; // Индекс центральной строки/столбца

        for (int i = 0; i < n; i++)
        {
            var chars = new char[n];
            for (int j = 0; j < n; j++)
            {
                // Проверяем, является ли текущая точка центральной
                if (i == center && j == center)
                {
                    chars[j] = ' '; // Пустота в центре
                }
                else
                {
                    chars[j] = '*';
                }
            }
            lines[i] = new string(chars);
        }

        return string.Join(Environment.NewLine, lines);
    }
}