namespace Rugby
{
    internal class Rugby
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Array:");
            //opretter array og henter indhold fra metode 
            string[] s = RugbyPlayers.AddRugbyPlayers();
            //giver metode information fra arrayet
            Tools.PrintArray(s);
            Console.WriteLine("\nList:");
            //opretter list og henter indhold fra metode 
            List<string> l = RugbyPlayers.AddRugbyPlayersList();
            //giver metode information fra listen
            Tools.PrintList(l);
        }
    }
}