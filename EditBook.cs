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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Book newbook = new Book();
            newbook.num = Convert.ToInt32(txtnum.Text);
            newbook.cat = txtcat.Text;
            newbook.name = txtname.Text;
            newbook.writer = txtwriter.Text;
            newbook.EditBook();
            MessageBox.Show("Book edited");
            Panel newfrm = new Panel();
            newfrm.Show();
            this.Hide();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            txtnum.Text = Convert.ToString(Panel.BookInfo.CurrentBook+1);
        }
    }
}
