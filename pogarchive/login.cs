using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pogarchive
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox1.MaxLength = 100;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_in_Click(object sender, EventArgs e)
        {
            database database = new database();
            var login = textBox_login.Text;
            var password = md5.hashPassword(textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querryString = $"select id, login_reg, password_reg from register where login_reg = '{login}' and password_reg = '{password}'";
            SqlCommand command = new SqlCommand(querryString, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешли вошли.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 mainad = new Form1();
                this.Hide();
                mainad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

       
    }
}
