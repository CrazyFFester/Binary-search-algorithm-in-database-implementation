using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsearch
{
    class MainClass
    {
        public static int ID;
        //Method that performs binary search
        public int bsearch()
        {
            int searchvalue, left, mid, right;
            //if id is equal to this id
            if (ID == 445)
            {
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

                searchvalue = 51;
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
            }
            //if id is equal to this id
            if ( ID == 541)
            {
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

                searchvalue = 52;
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
            }
            //if id is equal to this id
            if (ID == 781)
            {
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

                searchvalue = 61;
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
            }
            //if id is equal to this id
            if (ID == 800)
            {
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

                searchvalue = 62;
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
            }
            //if id is equal to this id
            if (ID == 900)
            {
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

                searchvalue = 64;
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
            }
            //if id is equal to this id
            if (ID == 100)
            {
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

                searchvalue = 90;
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
            }
            //if id is equal to this id
            if (ID == 200)
            {
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

                searchvalue = 101;
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
            }
            //if id is equal to this id
            if (ID == 300)
            {
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

                searchvalue = 104;
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
            }
            //if id is equal to this id
            if (ID == 1024)
            {
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

                searchvalue = 201;
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
            }
            //if id is equal to this id
            if (ID == 2048)
            {
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

                searchvalue = 304;
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
            }
            //if id is equal to this id
            if (ID == 567)
            {
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

                searchvalue = 445;
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
            }
            else
            {
                Console.WriteLine("This ID isn't real");
                //Ends the program
                Environment.Exit(0);
            }
            return -1;
        }
        public static void Main()
        {
            MainClass password = new MainClass();
            Console.WriteLine("Enter your ID");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"----------" + $"\n{password.bsearch()} - your password");
        }
    }
}