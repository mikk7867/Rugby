namespace Rugby
{
    internal class Tools
    {
        public static void PrintArray(string[] s)
        {
            Console.WriteLine("\nWhile loop:");
            int c = 0;
            while (c < s.Length)
            {
                Console.WriteLine($"{c + 1}) {s[c]}");
                c++;
            }
            Console.WriteLine("\nForeach loop:");
            foreach (var v in s)
            {
                Console.WriteLine($"{Array.IndexOf(s, v) + 1}) {v}");
            }
            Console.WriteLine("\nFor loop:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {s[i]}");
            }
        }
    }
}
