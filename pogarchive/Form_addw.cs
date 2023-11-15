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
    public partial class Form_addw : Form
    {
        database database = new database();
        public Form_addw()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_addw_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var surname = textBox_sur.Text;
            var name = textBox_name.Text;
            var patr = textBox_pat.Text;
            var phone = textBox_phone.Text;
                    var addQuery =
                $"insert into Workers (Surname, Wname, Patr, phone) values ('{surname}', '{name}', '{patr}', '{phone}')";

                    var command = new SqlCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            database.closeConnection();
        }
    }
}
