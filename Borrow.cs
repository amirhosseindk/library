using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libary
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Main.BookInfo.CurrentBook+1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.num = Convert.ToInt32(textBox1.Text);
            book.BorrowBook(textBox2.Text, dateTimePicker1.Text);
            MessageBox.Show("book borrowd");
            Main newfrm = new Main();
            newfrm.Show();
            this.Close();
        }
    }
}
