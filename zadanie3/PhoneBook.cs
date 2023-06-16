using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    class PhoneBook
    {
        private ListBox listBox;
        private Dictionary<string, string> contact;
        bool c = false;
        public PhoneBook (ListBox listBox)
        {
            contact = new Dictionary<string, string>();
            this.listBox = listBox;
        }

        public void Conn ()
        {
            if (contact.Count > 0)
            {
                foreach (var con in contact)
                {
                    listBox.Items.Add(con.Value + " " + con.Key);
                }
            }
            else
            {
                MessageBox.Show("Пустота");
            }
        }

        internal void Addcon (Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Poiskcon (string name)
        {
            listBox.Items.Clear();
            c = false;
            foreach (var con in contact)
            {
                string n = con.Value;
                string nomer = con.Key;
                if (n.ToLower().Contains(name.ToLower()))
                {
                    MessageBox.Show($"Контакт найден: Имя: {n} Номер телефона: {nomer}");
                    c = true;
                }
            }
            if (!c)
            {
                MessageBox.Show("Контакт не найден");
            }

        }

        public void Addcon (string name, string nomer)
        {
            if (contact.ContainsKey(nomer))
            {
                MessageBox.Show("Такой контакт уже есть");
            }
            else
            {
                contact[nomer] = name;
            }
        }

        public void Deletecon (string name)
        {
            if (contact.ContainsKey(name))
            {
                contact.Remove(name);
                MessageBox.Show($"Контакт {name} удален" );
            }
            else
            {
                MessageBox.Show("Контакт не существует");
            }
        }
    }
}
