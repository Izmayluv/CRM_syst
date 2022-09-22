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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            Auth auth = new Auth();
            lb_user.Text = auth.log();
        }

        private void SwitchToReports()
        {
            p_reports.BorderStyle = BorderStyle.FixedSingle;

            Reports reports = new Reports();
            reports.ShowDialog();

            p_reports.BorderStyle = BorderStyle.None;
        }

        private void Exit()
        {
            p_exit.BorderStyle = BorderStyle.FixedSingle;

            this.Close();

            p_exit.BorderStyle = BorderStyle.None;
        }

        private void lb_reports_Click(object sender, EventArgs e)
        {
            SwitchToReports();
        }

        private void pb_reports_Click(object sender, EventArgs e)
        {
            SwitchToReports();
        }

        private void p_reports_Click(object sender, EventArgs e)
        {
            SwitchToReports();
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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
