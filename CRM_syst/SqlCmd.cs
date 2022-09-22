using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRM_syst
{
    class SqlCmd
    {
        private bool customer;
        private bool staff;
        private bool administrator;

        public string login;

        public void Login(string logintext, string passwordtext) //войти как обычный пользователь
        {
            login = logintext;

            string loginCmdTxt = "SELECT * FROM customers WHERE login = '" + logintext + "' and password = '" + passwordtext + "'";
            SqlCommand loginCmd = new SqlCommand(loginCmdTxt, Connect.sqlConnection);

            var reader = loginCmd.ExecuteReader();

            if (reader.HasRows)
            {
                customer = true;
            }
            //else
            //{
            //    reader.Close();
            //    LoginAsAdministrator(logintext, passwordtext);
            //}
            reader.Close();
        }

        public void LoginAsAdministrator(string logintext, string passwordtext) //войти как администратор
        {
            login = logintext;

            string loginAsAdmCmdTxt = "SELECT p.login AS login, p.password AS password, u.job_title AS job_title FROM staff AS p LEFT JOIN roles AS u ON p.id_staff = u.id_role WHERE login = '" + logintext + "' and password = '" + passwordtext + "' and job_title = 'Administrator'";
            SqlCommand loginAsAdmCmd = new SqlCommand(loginAsAdmCmdTxt, Connect.sqlConnection);

            var reader = loginAsAdmCmd.ExecuteReader();

            if (reader.HasRows)
            {
                administrator = true;
            }
            //else
            //{
            //    reader.Close();
            //    LoginAsStaff(logintext, passwordtext);
            //}
            reader.Close();
        }

        public void LoginAsStaff(string logintext, string passwordtext) //войти как сотрудник
        {
            login = logintext;

            string loginAsStfCmdTxt = "	SELECT * FROM staff WHERE login = '" + logintext + "' and password = '" + passwordtext + "'";
            SqlCommand loginAsStfCmd = new SqlCommand(loginAsStfCmdTxt, Connect.sqlConnection);

            var reader = loginAsStfCmd.ExecuteReader();

            if (reader.HasRows)
            {
                staff = true;
            }
            //else
            //{
            //    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            reader.Close();
        }


        public bool Cstmr()
        {
            return customer;
        }

        public bool Stf()
        {
            return staff;
        }

        public bool Adm()
        {
            return administrator;
        }


        public void RegisterAsCustomer(string lastnametext, string nametext, string middlenametext, string phonenumtext, string logintext, string passwordtext) //регистрация для клиента
        {
            string registCmdTxt = "insert into customers(lastname, name, middlename, phone, login, password)" +
                " values('" + lastnametext + "', '" + nametext + "', '" + middlenametext + "', '" + phonenumtext + "', '" + logintext + "', '" + passwordtext + "')";

            SqlCommand registCmd = new SqlCommand(registCmdTxt, Connect.sqlConnection);

            var dataReader = registCmd.ExecuteReader();
            dataReader.Close();
        }

        public void FillCB(ComboBox comboBox, string nameofcolumn, string nameoftable, string condition)
        {
            string query = "SELECT " + nameofcolumn + " FROM " + nameoftable + " WHERE " + condition;
            SqlCommand command = new SqlCommand(query, Connect.sqlConnection);
            DataTable table_p = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table_p);

            comboBox.DataSource = table_p;
        }

        public void showAllManagers(DataGridView dataGrid)
        {
            string _cmd = "select * from departments";
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connect.sqlConnection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Staff");
            dataGrid.DataSource = _ds.Tables["Staff"];
            dataGrid.DataSource = _ds.Tables[0];
        }

        public void showAllNotEndedProjects(DataGridView dataGrid)
        {
            string _cmd = "select * from projects where expiration_date > GETDATE() ";
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connect.sqlConnection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Projects");
            dataGrid.DataSource = _ds.Tables["Projects"];
            dataGrid.DataSource = _ds.Tables[0];
        }

    }
}
