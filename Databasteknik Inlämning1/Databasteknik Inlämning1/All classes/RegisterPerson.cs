namespace Databasteknik_Inlämning1.All_classes
{
    public class RegisterPerson
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int MailingAddress { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInto
        {
            get
            {
                return $"{ Firstname } { LastName } { Address } {MailingAddress} { City } { Mail } { PhoneNumber }";
            }
        }
    }
}
