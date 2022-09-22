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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

            lb_login.Parent = pb_bg;
            lb_login.BackColor = Color.Transparent;
            lb_password.Parent = pb_bg;
            lb_password.BackColor = Color.Transparent;
            lb_capture.Parent = pb_bg;
            lb_capture.BackColor = Color.Transparent;
            lb_reg.Parent = pb_bg;
            lb_reg.BackColor = Color.Transparent;

            btn_auth.Parent = pb_bg;
            btn_auth.BackColor = Color.Transparent;
        }

        MainMenu mainMenu;
        MenuForCustomers menuForCustomers;
        Register register;
        MenuForAdministrators menuForAdministrators;

        SqlCmd SqlCmd = new SqlCmd();
        Connect connect = new Connect();

        static private string login;

        public string log()
        {
            return login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = tb_login.Text;
            var password = tb_password.Text;

            try
            {
                connect.StartSQLconnection();
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");

            }

            try
            {
                SqlCmd.LoginAsStaff(login, password);
                SqlCmd.Login(login, password);
                SqlCmd.LoginAsAdministrator(login,password);
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");
            }

            try
            {
                connect.CloseSQLconnection();
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");
            }

            if (SqlCmd.Cstmr() == true)
            {
                menuForCustomers = new MenuForCustomers();
                this.Hide();
                menuForCustomers.Show();
            }

            if (SqlCmd.Stf() == true && SqlCmd.Adm() != true)
            {
                mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }

            if (SqlCmd.Adm() == true)
            {
                menuForAdministrators = new MenuForAdministrators();
                this.Hide();
                menuForAdministrators.Show();
            }

            //if(SqlCmd.Cstmr() != true && SqlCmd.Stf() != true && SqlCmd.Adm() != true)
            //{
            //    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lb_reg_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.ShowDialog();
        }

        private void lb_capture_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                connect.CheckSQLconnection();
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");

            }
        }
    }
}
