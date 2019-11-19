namespace App1.Models
{
    class payment
    {


        public Inscription inscription { get; set; }
        public int montant { get; set; }
        public string date { get; set; }
        public int reste { get; set; }
        public string type_payment { get; set; }
    }
}
