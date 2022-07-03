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
    public partial class Panel : Form
    {
        public Panel()
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (information.SelectedRows.Count != 0)
            {
                BookInfo.CurrentBook = Convert.ToInt32(information.CurrentCell.RowIndex);
                EditBook newfrm = new EditBook();
                newfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("select book");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddBook newfrm = new AddBook();
            newfrm.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (information.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.information.SelectedRows[0];
                int delbook = int.Parse(information[0, information.CurrentRow.Index].Value.ToString());
                DialogResult myResult;
                myResult = MessageBox.Show("Sure To Delete Book ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (myResult == DialogResult.Yes)
                {
                    Book deletebook = new Book();
                    deletebook.num = delbook;
                    deletebook.DeleteBook();
                    MessageBox.Show("Deleted");
                    Panel_Load(null, null);
                }

            }
            else
            {
                MessageBox.Show("Choose Book to Delete");
            }
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            Book mybook = new Book();
            information.DataSource = mybook.SelectBook();
            information.Columns[0].HeaderText = "Num";
            information.Columns[1].HeaderText = "Name";
            information.Columns[2].HeaderText = "Writer";
            information.Columns[3].HeaderText = "Category";
            information.Columns[4].HeaderText = "Borrowed";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main newfrm = new Main();
            newfrm.Show();
            this.Close();
        }
    }
}
