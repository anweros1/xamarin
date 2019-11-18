namespace App1.Models
{
    class payment
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
            public Inscription inscription { get; set; }
            public int montant { get; set; }
            public string date { get; set; }
            public int reste { get; set; }
            public string type_payment { get; set; }
        }
    }
}
