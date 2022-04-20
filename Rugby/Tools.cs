namespace Rugby
{
    internal class Tools
    {
        public static void PrintArray(string[] s)
        {
            Console.WriteLine("While loop:");
            //counter til while loopet, sammenlignes med array length
            int c = 0;
            while (c < s.Length)
            {
                //printer index fra arrayet svarende til counter
                Console.WriteLine($"{c + 1}) {s[c]}");
                //øger counteren med én for at finde næste index i arrayet
                c++;
            }
            Console.WriteLine("\nForeach loop:");
            //for hver variabel i arrayet
            foreach (var v in s)
            {
                //finder index til print via variabel, printer desuden variabel
                Console.WriteLine($"{Array.IndexOf(s, v) + 1}) {v}");
            }
            Console.WriteLine("\nFor loop:");
            //for loop der sammenligner med array length
            for (int i = 0; i < s.Length; i++)
            {
                //printer index for arrayet svarende til for loop counter
                Console.WriteLine($"{i + 1}) {s[i]}");
            }
        }
        public static void PrintList(List<string> l)
        {
            Console.WriteLine("While loop:");
            //counter til while loopet, sammenlignes med list count
            int c = 0;
            while (c < l.Count)
            {
                //printer index fra listen svarende til counter
                Console.WriteLine($"{c + 1}) {l[c]}");
                //øger counteren med én for at finde næste index i listen
                c++;
            }
            Console.WriteLine("\nForeach loop:");
            //for hver variabel i listen
            foreach (var v in l)
            {
                //finder index til print via variabel, printer desuden variabel
                Console.WriteLine($"{l.FindIndex(a => a == v) + 1}) {v}");
            }
            Console.WriteLine("\nFor loop:");
            //for loop der sammenligner med list count
            for (int i = 0; i < l.Count; i++)
            {
                //printer index for listen svarende til for loop counter
                Console.WriteLine($"{i + 1}) {l[i]}");
            }
        }
    }
}
