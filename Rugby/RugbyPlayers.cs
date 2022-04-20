namespace Rugby
{
    internal class RugbyPlayers
    {
        public static string[] AddRugbyPlayers()
        {
            //oprætter et tomt array
            string[] s = new string[5];
            //lægger information i arrayet (gentagne gange)
            s[0] = "Antoine Dupont";
            s[1] = "Maro Itjoe";
            s[2] = "Beauden Barrett";
            s[3] = "Jonah Lomu";
            s[4] = "Owen Farrell";
            //returnerer fyldt array
            return s;
        }
    }
}
