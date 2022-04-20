namespace Rugby
{
    internal class RugbyPlayers
    {
        public static string[] AddRugbyPlayers()
        {
            //oprætter et tomt array
            string[] s = new string[5];
            //lægger information i arrayet
            s[0] = "Antoine Dupont";
            s[1] = "Maro Itjoe";
            s[2] = "Beauden Barrett";
            s[3] = "Jonah Lomu";
            s[4] = "Owen Farrell";
            //returnerer fyldt array
            return s;
        }
        public static List<string> AddRugbyPlayersList()
        {
            //opretter en tom liste
            List<string> l = new();
            //lægger information i listen
            l.Add("Cheslin Kolbe");
            l.Add("Eben Etzebeth");
            l.Add("Faf de Klerk");
            l.Add("Michael Hooper");
            l.Add("Brian O'Driscoll");
            //returnerer liste med info
            return l;
        }
    }
}
