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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        internal class BookInfo
        {
            public static int CurrentBook
            {
                get;
                set;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login newfrm = new Login();
            newfrm.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Book mybook = new Book();
            information.DataSource = mybook.SelectBook();
            information.Columns[0].HeaderText = "Num";
            information.Columns[1].HeaderText = "Name";
            information.Columns[2].HeaderText = "Writer";
            information.Columns[3].HeaderText = "Category";
            information.Columns[4].HeaderText = "Borrowed";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (information.SelectedRows.Count != 0)
            {
                BookInfo.CurrentBook = Convert.ToInt32(information.CurrentCell.RowIndex);
                Borrow newfrm = new Borrow();
                newfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("select book");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (information.SelectedRows.Count != 0)
            {
                BookInfo.CurrentBook = Convert.ToInt32(information.CurrentCell.RowIndex);
                Lend newfrm = new Lend();
                newfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("select book");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Book mybook = new Book();
            if (textBox1.Text == "")
            {
                information.DataSource = mybook.SelectBook();
                information.Columns[0].HeaderText = "Num";
                information.Columns[1].HeaderText = "Name";
                information.Columns[2].HeaderText = "Writer";
                information.Columns[3].HeaderText = "Category";
                information.Columns[4].HeaderText = "Borrowed";
            }
            else
            {
                information.DataSource = mybook.SearchBook(textBox1.Text);
            }
            
        }
    }
}
