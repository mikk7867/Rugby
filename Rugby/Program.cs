namespace Rugby
{
    internal class Rugby
    {
        public static void Main(string[] args)
        {
            //opretter array og henter indhold fra metode 
            string[] s = RugbyPlayers.AddRugbyPlayers();
            //giver metode information fra arrayet
            Tools.PrintArray(s);
        }
    }
}