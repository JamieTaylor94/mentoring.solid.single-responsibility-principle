using System;

namespace Mentoring.Solid.SingleResponsibility
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please enter the follow details to sign up for the 2021 Christmas Party");
            Console.WriteLine("Email Address");
            var emailAddress = Console.ReadLine();
            Console.WriteLine("First and Last name");
            var name = Console.ReadLine();

            var registration = new PartyRegistrationService(new Repository());

            var message= registration.Register(emailAddress, name);
            
            Console.WriteLine(message);
        }
    }
}
