
using System.Collections.Generic;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            bool go = true;

            while (go = true)
            {
                Console.WriteLine("Write 1 to add contact");
                Console.WriteLine("Write 2 delete contact");
                Console.WriteLine("Write 3 to search contact");
                Console.WriteLine("Write 4 to exit");
                Console.WriteLine("Write 5 to view all contacts");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter the name you want to add");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the phone number of that");
                        string phonenumber = Console.ReadLine();
                        contacts[name] = phonenumber;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Contact was succesfully added");
                        Console.ResetColor();
                        break;

                    case 2:
                        bool go2 = true;
                        while (go2 = true)
                        {
                            Console.WriteLine("Enter the name you want to delete");
                            string deletename = Console.ReadLine();
                            if (contacts.ContainsKey(deletename))
                            {
                                contacts.Remove(deletename);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Contact was succesfully deletted ");
                                Console.ResetColor();
                            }
                            else
                            {

                                Console.WriteLine("User not found");
                                Console.WriteLine("Write 1 to go back to the main menu");
                                Console.WriteLine("Write 2 to try deleting a user again");
                                int answer = int.Parse(Console.ReadLine());
                                if (answer == 1)
                                {
                                    break;
                                }
                                else
                                {
                                    go2 = true;
                                }

                            }
                        }
                        break;

                    case 3:
                        bool go3 = true;
                        while (go3 = true)
                        {
                            Console.WriteLine("Enter the name you search");
                            string searchname = Console.ReadLine();
                            if (contacts.ContainsKey(searchname))
                            {
                                Console.WriteLine(contacts[searchname]);
                            }
                            else
                            {

                                Console.WriteLine("User not found");
                                Console.WriteLine("Write 1 to go back to the main menu");
                                Console.WriteLine("Write 2 to try searching a user again");
                                int answer = int.Parse(Console.ReadLine());
                                if (answer == 1)
                                {
                                    break;
                                }
                                else
                                {
                                    go3 = true;
                                }

                            }
                        }
                        break;
                    case 4:
                        go = false;
                        break;
                    case 5:
                        Console.WriteLine("These are all of contacts:");
                        foreach (var item in contacts)
                        {
                            Console.WriteLine($"The person{item.Key} phone number is {item.Value}");
                        }
                        break;



                }
            }
        }
    }
}

