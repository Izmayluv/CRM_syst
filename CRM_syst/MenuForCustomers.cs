using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_syst
{
    public partial class MenuForCustomers : Form
    {
        public MenuForCustomers()
        {
            InitializeComponent();
            SqlCmd cmd = new SqlCmd();

        }

        private void Exit()
        {
            p_exit.BorderStyle = BorderStyle.FixedSingle;

            this.Close();

            p_exit.BorderStyle = BorderStyle.None;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void p_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть?", "Выход", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void MenuForCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}