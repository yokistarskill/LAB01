using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] str_start = new string[2]
            { "Are you ",
              " or " };

            string str_hello = "Hello, ";

            string user = "user";
            string admin = "admin";

            string n = ".\n";

            string str_password = "Please, enter your password.";

            string[] str_error = new string[2]
            { ("Your answer is not correct. Please, enter " + user + str_start[1] + admin + '.'),
              ("Your password is not correct.") };

            string[] str_disk_info = new string[3]
            { ("You access logical drives A, B and C as a "),
              ("You only have the ability to read the information."),
              ("You have the ability to read, edit, and save information on these disks.") };

            Console.WriteLine(str_start[0] + user + str_start[1] + admin + '?');
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string enter = Convert.ToString(Console.ReadLine());
            if (enter == user)
            {
                Console.WriteLine(str_hello + user + '!');
                Console.WriteLine(str_disk_info[0] + user + n + str_disk_info[1]);
            } else if (enter == admin)
            {
                Console.WriteLine(str_password);
                string correct_password = "admin1234"; // пароль к аккаунту администратора.
                string password = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                if (password == correct_password)
                {
                    Console.WriteLine(str_hello + admin + '!');
                    Console.WriteLine(str_disk_info[0] + admin + n + str_disk_info[2]);
                } else if (password != correct_password)
                {
                    Console.WriteLine(str_error[1]);
                }
            } else if (enter != user && enter != admin)
            {
                Console.WriteLine(str_error[0]);
                return;
            }

            Console.ReadKey();
        }
    }
}