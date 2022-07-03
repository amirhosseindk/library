using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Libary;Integrated Security=True");

        private void Login_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if ((User_txt.Text == "") || (Pass_txt.Text == ""))
            {
                MessageBox.Show("empty filds");
            }

            SqlCommand command = new SqlCommand("select count(*) from logins where username='" + User_txt.Text + "' and pass='" + Pass_txt.Text + "'", connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                i = (int)command.ExecuteScalar();
            }
            connection.Close();

            if (i > 0)
            {
                Panel newfrm = new Panel();
                newfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("not correct");
            }

            i = 0;
            connection.Close();
        }
    }
}
