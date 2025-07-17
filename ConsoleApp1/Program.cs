using oop3.question2;
using oop3.question3;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question2

            //IAuthenticationService authenticationService = new BasicAuthenticationService();

            //Console.WriteLine(authenticationService.AuthenticateUser("admin", "password"));

            //Console.WriteLine(authenticationService.AuthenticateUser("admin", "pasword"));

            //Console.WriteLine(authenticationService.AuthorizeUser("admin", "Administrator"));

            //Console.WriteLine(authenticationService.AuthorizeUser("admin", "user"));

            #endregion

            #region question3

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string message = "Your verification code is 123456";

            emailService.SendNotification("hana.abuauf@example.com", message);
            smsService.SendNotification("+1097261273", message);
            pushService.SendNotification("device_token", message);


            #endregion



        }
    }
}
