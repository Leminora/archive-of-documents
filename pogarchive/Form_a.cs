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
    public partial class Form_a : Form
    {
        database database = new database();
        public Form_a()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_a_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var title = textBox_title.Text;
            DateTime date;
            DateTime datee;
            var worker = textBox_work.Text;
            var now = Convert.ToDateTime(textBox_etime.Text);
            var time = DateTime.Now.Date;
            if (DateTime.TryParse(textBox_stime.Text, out date) && DateTime.TryParse(textBox_etime.Text, out datee))
            {
                if (date <= time)
                {
                    var addQuery =
                $"insert into DocNow (dtid, dates, datee, oid, gid, tid) values ((select Did from Document where Did = '{title}'), '{date}', '{now}', (select Wid from Workers where Wid='{worker}'), (select Wid from Workers where Wid='{worker}'), (select Wid from Workers where Wid='{worker}'))";

                    var command = new SqlCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите дату, не превышающую текущую", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Не введён правильно формат даты в поля дат, попробуйте ГГГГ-ММ-ДД или ДД-ММ-ГГГГ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void button_person_Click(object sender, EventArgs e)
        {
            Form_ex4 list = new Form_ex4(this);
            list.ShowDialog();
        }

        private void button_doc_Click(object sender, EventArgs e)
        {
            Form_ex3 list = new Form_ex3(this);
            list.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
