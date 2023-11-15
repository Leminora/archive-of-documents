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
    public partial class Form_f : Form
    {
        Form_where form;
        public Form_f(Form_where form)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = form;
        }
        private void Showdata()
        {

            int Index = form.data3.CurrentCell.RowIndex;

            if (Index >= 0)
            {
                DataGridViewRow row = form.data3.Rows[Index];
                textBox_stime.Text = row.Cells[2].Value.ToString();
                textBox_etime.Text = row.Cells[3].Value.ToString();
               
            }
        }

        public void Change()
        {

            int Index = form.data3.CurrentCell.RowIndex;
            var id = form.data3.Rows[Index].Cells[0].Value.ToString();
            var title = form.data3.Rows[Index].Cells[1].Value.ToString();
            DateTime date;
            DateTime datee;
            var worker1 = form.data3.Rows[Index].Cells[4].Value.ToString();
            var worker2 = form.data3.Rows[Index].Cells[5].Value.ToString();
            var worker3 = form.data3.Rows[Index].Cells[8].Value.ToString();
            var now = Convert.ToDateTime(textBox_etime.Text);
            var time = DateTime.Now.Date;
            if (DateTime.TryParse(textBox_stime.Text, out date) && DateTime.TryParse(textBox_etime.Text, out datee))
            {
                if (date <= time)
                {

                    form.data3.Rows[Index].SetValues(id, title, date, now, worker1, worker2, worker3);
                    form.data3.Rows[Index].Cells[7].Value = Rowstate.Modified;
                    MessageBox.Show("Запись отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();


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
            

        }

        private void Form_f_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
