using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    class Contact
    {
        public string Name;
        public string Phone; 
        private bool a = true;

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value != "" && value.Length > 0)
                {
                    Name = value;
                    a = true;
                }
                else
                {
                    MessageBox.Show("Введены неверные данные для имени", "Ошибка", MessageBoxButtons.OK);
                    a = false;
                }
            }
        }

        public string phone
        {
            get
            {
                return Phone;
            }
            set
            {
                if (value != "")
                {
                    Phone = value;
                    a = true;
                }
                else
                {
                    MessageBox.Show("Введены неверные данные для телефона", "Ошибка", MessageBoxButtons.OK);
                    a = false;
                }
            }
        }

        public bool b
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
}
