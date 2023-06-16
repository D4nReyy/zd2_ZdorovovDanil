using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zadanie3
{
    public partial class Form1 :Form
    {
        Contact kon = new Contact();
        PhoneBook book;
        private PhoneBook phoneBook;

        public Form1 ()
        {
            InitializeComponent();
            book = new PhoneBook(listBox1);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            //Добавление контакта
            kon.name = textBox1.Text;
            kon.phone = textBox2.Text;
            if (kon.b == true)
            {
                book.Addcon(kon.name, kon.phone);
                listBox1.Items.Clear();
                book.Conn();
                MessageBox.Show("Вы добавили контакт");
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            //Поиск контакта
            if (textBox3.Text != "")
            {
                book.Poiskcon(textBox3.Text);
                book.Conn();
            }
            else
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK);
            
        }

        private void button3_Click (object sender, EventArgs e)
        {
            //Удаление контакта
            if (textBox4.Text != "")
            {
                listBox1.Items.Clear();
                book.Deletecon(textBox4.Text);
                listBox1.Items.Clear();
                book.Conn();
            } else
                MessageBox.Show("Введите данные для удаления", "Ошибка", MessageBoxButtons.OK);
        }

        private void button4_Click (object sender, EventArgs e)
        {
            //Сохранение в файл
            using (StreamWriter wr = new StreamWriter("2.txt"))
            {
                foreach (var i in listBox1.Items)
                {
                    wr.WriteLine(i.ToString());
                }
            }
            MessageBox.Show("Данные сохранены в файл 2.txt");
        }

        private void button6_Click (object sender, EventArgs e)
        {
            //Выход
            MessageBoxButtons bt = MessageBoxButtons.YesNo;
            string m = "Вы действительно хотите выйти?";
            string m2 = "Выход";
            if (MessageBox.Show(m, m2,bt)== DialogResult.Yes)
                this.Close();
        }

    }
}
