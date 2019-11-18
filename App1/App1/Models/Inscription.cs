namespace App1.Models
{
    class Inscription
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
            public int Proprietere { get; set; }
            public int Client { get; set; }
            public int Offre { get; set; }
            public int Prix_achat { get; set; }
            public string Date_achat { get; set; }
        }

    }
}
