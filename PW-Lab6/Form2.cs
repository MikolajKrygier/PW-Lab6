using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PW_Lab6
{
    public partial class Form2 : Form
    {
        public static int IDtext = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Book book1 = new Book();
            book1.Tytul = textBox1.Text;
            book1.Wydawnictwo = textBox2.Text;
            book1.Rok_wydania = Int32.Parse(textBox3.Text);
            book1.Autor = textBox4.Text;
            book1.Miasto = textBox5.Text;
            book1.Status_wypozyczenia = textBox6.Text;
            book1.ID = IDtext;
            IDtext++;

            Form1.form1Instance.dataGridView1.Rows.Add(book1.Tytul, book1.Autor, book1.Wydawnictwo, book1.Miasto, book1.Rok_wydania, book1.Status_wypozyczenia, book1.ID);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}