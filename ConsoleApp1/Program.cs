using oop3.question2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IAuthenticationService authenticationService = new BasicAuthenticationService();

            Console.WriteLine(authenticationService.AuthenticateUser("admin", "password"));

            Console.WriteLine(authenticationService.AuthenticateUser("admin", "pasword"));

            Console.WriteLine(authenticationService.AuthorizeUser("admin", "Administrator"));

            Console.WriteLine(authenticationService.AuthorizeUser("admin", "user"));

        }
    }
}
