using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie3
{
    class PhoneBookLoader
    {
        public static void Load (PhoneBook phoneBook, string fileName) 
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string l in lines)
                {
                    string[] a = l.Split(';');
                    if (a.Length == 2)
                    {
                        phoneBook.Addcon(new Contact { Name = a[0].Trim(), Phone = a[1].Trim() });

                    }
                }
            }
                
        }

        internal static void Load (PhoneBook phoneBook)
        {
            throw new NotImplementedException();
        }
    }
}
