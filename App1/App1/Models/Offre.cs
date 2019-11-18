namespace App1.Models
{
    class Offre
    {

        public class Rootobject
        {
            public string name { get; set; }
            public string _base { get; set; }
            public bool idInjection { get; set; }
            public Options options { get; set; }
            public Properties properties { get; set; }
            public object[] validations { get; set; }
            public Relations relations { get; set; }
            public object[] acls { get; set; }
            public Methods methods { get; set; }
        }

        public class Options
        {
            public bool validateUpsert { get; set; }
        }

        public class Properties
        {
            public string service { get; set; }
            public int horaire_total { get; set; }
            public char unite_horaire { get; set; }
            public int prix_unitaire { get; set; }
            public int remise { get; set; }
        }
    }
}
