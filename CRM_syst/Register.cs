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

namespace CRM_syst
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            lb_lastname.Parent = pb_bg;
            lb_lastname.BackColor = Color.Transparent;
            lb_name.Parent = pb_bg;
            lb_name.BackColor = Color.Transparent;
            lb_middlename.Parent = pb_bg;
            lb_middlename.BackColor = Color.Transparent;
            lb_login.Parent = pb_bg;
            lb_login.BackColor = Color.Transparent;
            lb_password.Parent = pb_bg;
            lb_password.BackColor = Color.Transparent;
            lb_phone.Parent = pb_bg;
            lb_phone.BackColor = Color.Transparent;
            button1.Parent = pb_bg;
            button1.BackColor = Color.Transparent;
        }

        Connect connect = new Connect();
        SqlCmd cmd = new SqlCmd();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.RegisterAsCustomer(lastname.Text,name.Text,tb_middlename.Text,tb_phone.Text,tb_login.Text,tb_password.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");
            }
        }
    }
}
