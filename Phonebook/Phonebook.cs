using System;
using System.Collections.Generic; // for List
using System.IO; // for StreamReader, StreamWriter
using System.Runtime.CompilerServices;

namespace Phonebook
{
    public class Phonebook
    {
        private const int LOAD_CONTACTS_FILE = 1;
        private const int SHOW_CONTACTS = 2;
        private const int ADD_CONTACTS = 3;
        private const int EDIT_CONTACTS = 4;
        private const int DELETE_CONTACTS = 5;
        private const int MERGE_CONTACTS = 6;
        private const int SAVE_CONTACTS_FILE = 7;
        private const int EXIT_PROGRAM = 8;

        List<Contacts> cnts = new List<Contacts>();

        public static void Main(string[] args)
        {
            Phonebook phb = new Phonebook();
            phb.Start();
        }

        public Phonebook()
        { 
        }

        public void Start()
        {
            int input;
            do
            {
                do
                {
                    ShowMainMenu();
                    input = GetInput();
                } while (!IsValidInput(input));
                ProcessInput(input);
            } while (input != EXIT_PROGRAM);


        }

        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to your phonebook.\n\nChoose an option:");
            Console.WriteLine($"[{LOAD_CONTACTS_FILE}] Load contacts from a file.");
            Console.WriteLine($"[{SHOW_CONTACTS}] Show all contacts.");
            Console.WriteLine($"[{ADD_CONTACTS}] Add a contact.");
            Console.WriteLine($"[{EDIT_CONTACTS}] Edit an existing contact.");
            Console.WriteLine($"[{DELETE_CONTACTS}] Delete a contact.");
            Console.WriteLine($"[{MERGE_CONTACTS}] Merge duplicated contacts.");
            Console.WriteLine($"[{SAVE_CONTACTS_FILE}] Save all contacts in a file.");
            Console.WriteLine($"[{EXIT_PROGRAM}] Exit.\n");
            Console.Write("Input: ");
        }

        public int GetInput()
        {
            try
            {
                string inputToStringToInt = Console.ReadLine().Trim();
                
                return Convert.ToInt16(inputToStringToInt);
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public bool IsValidInput(int input)
        {
            if (input >= 1 && input <= 8)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input\nPlease enter a number from 1 to 8.");
                return false;
            }
        }

        public void ProcessInput(int x)
        {
            if (x == LOAD_CONTACTS_FILE)
            {

            }
            else if(x == SHOW_CONTACTS)
            {

            }
            else if (x == ADD_CONTACTS)
            {
                AddContacts();
            }
            else if (x == EDIT_CONTACTS)
            {

            }
            else if (x == MERGE_CONTACTS)
            {

            }
            else if (x == SAVE_CONTACTS_FILE)
            {

            }
        }

        public void LoadContactsFile()
        {

        }

        public void ShowConctacts()
        {
            return ;
        }

        public void AddContacts()
        {
            Console.Clear();
            Contacts contacts = new Contacts(null,null,null,null);

            Console.SetCursorPosition(4, 2);
            Console.WriteLine("NAME");


            Console.SetCursorPosition(24, 2);
            Console.WriteLine("LAST NAME");

            Console.SetCursorPosition(44, 2);
            Console.WriteLine("PHONE");

            Console.SetCursorPosition(64, 2);
            Console.WriteLine("E-MAIL");

            Console.Write("\n\nEnter the name: ");
            contacts.SetName(Console.ReadLine());
            Console.SetCursorPosition(4, 3);
            Console.WriteLine(contacts.GetName());

            //Menu Refresh            

            Console.Clear();

            Console.SetCursorPosition(4, 2);
            Console.WriteLine("NAME");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine(contacts.GetName());

            Console.SetCursorPosition(24, 2);
            Console.WriteLine("LAST NAME");


            Console.SetCursorPosition(44, 2);
            Console.WriteLine("PHONE");

            Console.SetCursorPosition(64, 2);
            Console.WriteLine("E-MAIL");

            Console.Write("\n\nEnter the last name: ");
            contacts.SetLastName(Console.ReadLine());
            Console.SetCursorPosition(24, 3);
            Console.WriteLine(contacts.GetLastName());

            //Menu Refresh

            Console.Clear();
            
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("NAME");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine(contacts.GetName());

            Console.SetCursorPosition(24, 2);
            Console.WriteLine("LAST NAME");
            Console.SetCursorPosition(24, 3);
            Console.WriteLine(contacts.GetLastName());

            Console.SetCursorPosition(44, 2);
            Console.WriteLine("PHONE");


            Console.SetCursorPosition(64, 2);
            Console.WriteLine("E-MAIL");

            Console.Write("\n\nEnter the phone number: ");
            contacts.SetPhone(Console.ReadLine());
            Console.SetCursorPosition(44, 3);
            Console.WriteLine(contacts.GetPhone());

            //Menu Refresh

            Console.Clear();
            
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("NAME");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine(contacts.GetName());

            Console.SetCursorPosition(24, 2);
            Console.WriteLine("LAST NAME");
            Console.SetCursorPosition(24, 3);
            Console.WriteLine(contacts.GetLastName());

            Console.SetCursorPosition(44, 2);
            Console.WriteLine("PHONE");
            Console.SetCursorPosition(44, 3);
            Console.WriteLine(contacts.GetPhone());

            Console.SetCursorPosition(64, 2);
            Console.WriteLine("E-MAIL");

            Console.Write("\n\nEnter the e-mail: ");
            contacts.SetEmail(Console.ReadLine());
            Console.SetCursorPosition(64, 3);
            Console.WriteLine(contacts.GetEmail());

            cnts.Add(contacts);


            Console.Clear();
            Console.WriteLine(cnts.Count); //Checks how many contacts are on the list. REMOVE WHEN EVERYTHING IS FUNCTIONAL.
        }

        public void EditContacts()
        {

        }

        public void MergeContacts()
        {

        }

        public void SaveContactsFile()
        {


        }
    }
}


