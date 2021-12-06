using System;

namespace Mentoring.Solid.SingleResponsibility
{
    public class Repository
    {
        public void StoreRegisteredUser(string emailAddress, string name)
        {
            Console.WriteLine($"User {name} has been successfully stored to db");
        }
    }
}