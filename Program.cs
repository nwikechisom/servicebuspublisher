using System;
using Newtonsoft.Json;

namespace publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var bodyObject = new SignUpBusinessRequest {
                BusinessName = "Test Business Publisher",
                Email = "testBusiness@mailer.ru",
                PhoneNumber = "090777898866",
                FirstName = "Oge",
                LastName = "Credrailer",
                ProfileId ="222",
                AgreedToTerms = true,
                DateAgreedToTerms = DateTime.UtcNow,
                Address = "55 Yetunde Brown",
                RegistrationNumber = "5577777",
                City = "Lagos",
                State = "Lagos",
                Lga = "Kosofe",
                Country = "Nigeria"
            };
            ServiceBusEngine.SendMessageToTopicAsync(JsonConvert.SerializeObject(bodyObject), "usercreation");
        }
    }


    public class SignUpBusinessRequest
    {
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileId { get; set; }
        public bool AgreedToTerms { get; set; } = true;
        public DateTime DateAgreedToTerms { get; set; } = DateTime.UtcNow;
        public string Address { get; set; }
        public string RegistrationNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public string Country { get; set; }
    }
}
