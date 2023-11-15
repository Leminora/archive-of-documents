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
   
    public partial class Form_add : Form
    {
        database database = new database();
        public Form_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void button_person_Click(object sender, EventArgs e)
        {
            Form_ex2 list = new Form_ex2(this);
            list.ShowDialog();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var title = textBox_title.Text;
            var type = comboBox1.Text;
            var place = textBox_place.Text;
            DateTime date;
            var gate = textBox2.Text;
            var status = comboBox2.Text;
            var worker = textBox1.Text;
            var time = DateTime.Now.Date;
            if (DateTime.TryParse(textBox_time.Text, out date))
            {
                if (date <= time)
                {
                    var addQuery =
                $"insert Departue (point) select '{place}' where not exists (select 1 from Departue where point = '{place}') \n" +
                $"insert timegate (Timegate) select '{gate}' where not exists (select 1 from timegate where Timegate = '{gate}') \n" +
                $"insert into Document (Title, kid, depid, dated, timegate, wid, stid) values ('{title}', (select Kid from Kindofdoc where kind='{type}'), (select Did from Departue where point='{place}'), '{date}', (select Timeid from timegate where Timegate='{gate}'), (select Wid from Workers where Wid='{worker}'), (select ID from docwhere where Docwhere ='{status}'))";

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
                MessageBox.Show("Не введён правильно формат даты в поля дат, попробуйте ГГГГ-ММ-ДД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_add_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
