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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

        }

        Connect connect;
        SqlCmd cmd;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect = new Connect();
            cmd = new SqlCmd();

            try
            {
                connect.StartSQLconnection();
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");
            }

            switch (comboBox1.SelectedIndex)
            {
                default:
                    break;

                case -1:
                    MessageBox.Show("Выберите запрос");
                    break;

                case 0:
                    try
                    {
                        cmd.showAllManagers(dataGridView1);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 2:
                    try
                    {
                        cmd.showAllNotEndedProjects(dataGridView1);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 3:
                    try
                    {
                        
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 1:
                    try
                    {
                        cmd.showAllManagers(dataGridView1);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Encorrect query", "Error");
                    }
                    break;
            }

            try
            {
                connect.CloseSQLconnection();
            }
            catch (SqlException)
            {
                MessageBox.Show("SqlExeption - Error");
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
