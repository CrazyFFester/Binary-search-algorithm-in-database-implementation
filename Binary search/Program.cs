using System;
using System.Collections;
using System.Net.Mail;

namespace Account
{
    class AccountLogin 
    {
        public enum UserNames { Frank, Mike, Stacy };
        private static int _iD;
        private static int _password;

        private void User()
        {
            //If the identifier and password are correct, a message will appear stating that the user has successfully logged into his account
            if (_iD == 100 && _password == 90) { User(UserNames.Frank); }
            if (_iD == 200 && _password == 101) { User(UserNames.Mike); }
            if (_iD == 300 && _password == 104) { User(UserNames.Stacy); }
            else throw new Exception("\n[ERROR]: Wrong ID or password" + "\nIf you forgot your password, enter “forgot password”(0)");
        }
        //Method that simplifies the method User
        private void User(UserNames username)
        {
            Console.Write("----------");
            Console.WriteLine($"\nHello, {username}");
            Console.WriteLine("You have successfully logged into your account");
            Console.Read();
            Environment.Exit(0);
        }
        //Method looking for password using email
        private void PasswordSearchUsingEmail()
        {
            Console.Write("\nEmail: ");
            var email = Console.ReadLine();
            //If the email matches id
            if (email == "Frank100@o5mail.com" && _iD == 100) { PasswordSearchUsingEmail(email); }
            if (email == "Mike200@o5mail.com" && _iD == 200) { PasswordSearchUsingEmail(email); }
            if (email == "Stacy300@o5mail.com" && _iD == 300) { PasswordSearchUsingEmail(email); }
            else if (email == null) { throw new Exception("\n[ERROR]: Such mail does not exist"); }
            else throw new Exception("\n[ERROR]: Id does not match email");
        }
        //Method that simplifies the method PasswordSearchUsingEmail
        private void PasswordSearchUsingEmail(string x)
        {
            Hashtable IDAndPassoword = new Hashtable();
            IDAndPassoword["Frank100@o5mail.com"] = 90; //Frank
            IDAndPassoword["Mike200@o5mail.com"] = 101; //Mike
            IDAndPassoword["Stacy300@o5mail.com"] = 104; //Stacy

            var password = IDAndPassoword[x];
            Console.WriteLine($"----------" + $"\n{password} - your password");
            Console.Read();
        }
        public void Main()
        {
            AccountLogin account = new AccountLogin();

            Console.WriteLine("O5 Games");
            Console.WriteLine();
            Console.Write("ID: ");
            try
            {
                _iD = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPassword: ");
                _password = Convert.ToInt32(Console.ReadLine());
                //If in the column "password" entered "forgot password" (0), then an email will be requested
                if (_password == 0) account.PasswordSearchUsingEmail();
                else account.User();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
    class MainClass 
    {
        private static void Main()
        {
            AccountLogin accountlogin = new AccountLogin();

            accountlogin.Main();
        }
    }
}
