using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        // Регулярное выражение для поиска IP-адреса
        string ipPattern = @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";

        // Поиск совпадений в строке
        MatchCollection matches = Regex.Matches(inputString, ipPattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Найденные IP-адреса:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("IP-адреса не найдены.");
        }

        Console.ReadLine();
    }
}
