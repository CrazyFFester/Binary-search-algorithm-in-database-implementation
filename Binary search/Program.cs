using System;

namespace Account
{
    public enum UserNames {Frank, Mike, Stacy, Marvin, Toni, Emir, Elita, Khart, Alex, Jane, Margo};

    class HelperClass
    {
        //Method that simplifies the method PasswordCalculation
        protected int PasswordCalculation2(int searchvalue2)
        {
            int searchvalue, left, mid, right;
            int[] array = new int[11];
            array[0] = 51;
            array[1] = 52;
            array[2] = 61;
            array[3] = 62;
            array[4] = 64;
            array[5] = 90;
            array[6] = 101;
            array[7] = 104;
            array[8] = 201;
            array[9] = 304;
            array[10] = 445;

            searchvalue = searchvalue2;
            left = array[0];
            right = array[10];
            //The action will be performed until the left part approaches the left
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (searchvalue == mid)
                {
                    return mid;
                }
                else if (searchvalue > mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
        //Method that simplifies the method User
        protected int SearchPassword2(UserNames username)
        {
            Console.Write("----------");
            Console.WriteLine($"\nHello, {username}");
            Console.WriteLine("You have successfully logged into your account");
            Console.Read();
            Environment.Exit(0);

            return -1;
        }
    }
    class MainClass : HelperClass
    {
        private static string _email;
        private static int _iD;
        private static int _password;

        //Password calculating method
        private int PasswordCalculation()
        {
            //if id is equal to this id
            if (_iD == 445)
            {
                PasswordCalculation2(51);
            }
            if (_iD == 541)
            {
                PasswordCalculation2(52);
            }
            if (_iD == 781)
            {
                PasswordCalculation2(61);
            }
            if (_iD == 800)
            {
                PasswordCalculation2(62);
            }
            if (_iD == 900)
            {
                PasswordCalculation2(64);
            }
            if (_iD == 100)
            {
                PasswordCalculation2(90);
            }
            if (_iD == 200)
            {
                PasswordCalculation2(101);
            }
            if (_iD == 300)
            {
                PasswordCalculation2(104);
            }
            if (_iD == 1024)
            {
                PasswordCalculation2(201);
            }
            if (_iD == 2048)
            {
                PasswordCalculation2(304);
            }
            if (_iD == 567)
            {
                PasswordCalculation2(445);
            }
            else 
            {
                throw new Exception("\n[ERROR]: This ID isn't real");
            }

            return -1;
        }
        private int User()
        {
            //If the identifier and password are correct, a message will appear stating that the user has successfully logged into his account
            if (_iD == 100 && _password == 90)
            {
                SearchPassword2(UserNames.Frank);
            }
            if (_iD == 200 && _password == 101)
            {
                SearchPassword2(UserNames.Mike);
            }
            if (_iD == 300 && _password == 104)
            {
                SearchPassword2(UserNames.Stacy);
            }
            if (_iD == 445 && _password == 51)
            {
                SearchPassword2(UserNames.Marvin);
            }
            if (_iD == 541 && _password == 52)
            {
                SearchPassword2(UserNames.Toni);
            }
            if (_iD == 567 && _password == 445)
            {
                SearchPassword2(UserNames.Emir);
            }
            if (_iD == 781 && _password == 61)
            {
                SearchPassword2(UserNames.Elita);
            }
            if (_iD == 800 && _password == 62)
            {
                SearchPassword2(UserNames.Khart);
            }
            if (_iD == 900 && _password == 64)
            {
                SearchPassword2(UserNames.Alex);
            }
            if (_iD == 1024 && _password == 201)
            {
                SearchPassword2(UserNames.Jane);
            }
            if (_iD == 2048 && _password == 304)
            {
                SearchPassword2(UserNames.Margo);
            }
            else
            {
                throw new Exception("\n[ERROR]: Wrong ID or password" + "\nIf you forgot your password, enter “forgot password”(0)");
            }

            return -1;
        }
        //Method looking for password using email
        private int PasswordSearchUsingEmail()
        {
            Console.Write("\nEmail: ");
            _email = Console.ReadLine();
            if (_email == "Frank100@o5mail.com")
            {
                PasswordSearchUsingEmail2(90);
            }
            if(_email == "Mike200@o5mail.com")
            {
                PasswordSearchUsingEmail2(101);
            }
            if (_email == "Stacy300@o5mail.com")
            {
                PasswordSearchUsingEmail2(104);
            }
            if (_email == "Marvin445@o5mail.com")
            {
                PasswordSearchUsingEmail2(51);
            }
            if (_email == "Toni541@o5mail.com")
            {
                PasswordSearchUsingEmail2(52);
            }
            if (_email == "Emir567@o5mail.com")
            {
                PasswordSearchUsingEmail2(445);
            }
            if (_email == "Elita781@o5mail.com")
            {
                PasswordSearchUsingEmail2(61);
            }
            if (_email == "Kharon800@o5mail.com")
            {
                PasswordSearchUsingEmail2(62);
            }
            if (_email == "Alex900@o5mail.com")
            {
                PasswordSearchUsingEmail2(64);
            }
            if (_email == "Jane1024@o5mail.com")
            {
                PasswordSearchUsingEmail2(201);
            }
            if (_email == "Margo2048@o5mail.com")
            {
                PasswordSearchUsingEmail2(304);
            }
            else
            {
                throw new Exception("\n[ERROR]: There is no such email");
            }

            return -1;
        }
        //Method that simplifies the method PasswordSearchUsingEmail
        private int PasswordSearchUsingEmail2(int email2)
        {
            _password = email2;
            Console.WriteLine($"----------" + $"\n{_password} - your password");
            Console.Read();
            Environment.Exit(0);

            return -1;
        }
        private static void Main()
        {
            MainClass account = new MainClass();

            Console.WriteLine("O5 Games");
            Console.WriteLine();
            Console.Write("ID: ");
            try
            {
                _iD = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPassword: ");
                _password = Convert.ToInt32(Console.ReadLine());
                //If in the column "password" entered "forgot password" (0), then an email will be requested
                if (_password == 0)
                {
                    account.PasswordSearchUsingEmail();
                }
                else
                {
                    Console.WriteLine(account.User());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}