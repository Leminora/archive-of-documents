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
    public partial class Form_edit : Form
    {
        doc form;
        public Form_edit(doc form)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = form;
        }
        private void Showdata()
        {

            int Index = form.data.CurrentCell.RowIndex;

            if (Index >= 0)
            {
                DataGridViewRow row = form.data.Rows[Index];
                textBox_title.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                textBox_place.Text = row.Cells[3].Value.ToString();
                textBox_time.Text = row.Cells[4].Value.ToString();
                textBox2.Text = row.Cells[5].Value.ToString();
                comboBox2.Text = row.Cells[8].Value.ToString();
                textBox1.Text = row.Cells[6].Value.ToString();
            }
        }

        public void Change()
        {

            int Index = form.data.CurrentCell.RowIndex;
            var id = form.data.Rows[Index].Cells[0].Value.ToString();
            var title = textBox_title.Text;
            var type = comboBox1.Text;
            var place = textBox_place.Text;
            DateTime date;
            var status = comboBox2.Text;
            var worker = textBox1.Text;
            var wor = form.data.Rows[Index].Cells[7].Value.ToString();
            var gate = textBox2.Text;
            var time = DateTime.Now.Date;
            if (DateTime.TryParse(textBox_time.Text, out date))
            {
                if (date <= time)
                {
                   
                        form.data.Rows[Index].SetValues(id, title, type, place, date, gate, worker, wor, status);
                        form.data.Rows[Index].Cells[9].Value = Rowstate.Modified;
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
        private void Form_edit_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button_person_Click(object sender, EventArgs e)
        {
            Form_ex list = new Form_ex(this);
            list.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
