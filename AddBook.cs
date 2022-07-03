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
    public partial class AddBook : Form
    {
        public AddBook()
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
            newbook.AddBook();
            MessageBox.Show("Book Added");
            Panel newfrm = new Panel();
            newfrm.Show();
            this.Hide();
        }
    }
}
