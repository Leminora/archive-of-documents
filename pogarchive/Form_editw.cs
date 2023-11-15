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
    public partial class Form_editw : Form
    {
        Form_worker form;
        public Form_editw(Form_worker form)
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
                textBox_sur.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_pat.Text = row.Cells[3].Value.ToString();
                textBox_phone.Text = row.Cells[4].Value.ToString();
            }
        }

        public void Change()
        {

            int Index = form.data.CurrentCell.RowIndex;
            var id = form.data.Rows[Index].Cells[0].Value.ToString();
            var surname = textBox_sur.Text;
            var name = textBox_name.Text;
            var patr = textBox_pat.Text;
            var phone = textBox_phone.Text;
            form.data.Rows[Index].SetValues(id, surname, name, patr, phone);
                    form.data.Rows[Index].Cells[5].Value = Rowstate.Modified;
                    MessageBox.Show("Запись отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();


               


        }

        private void Form_editw_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void label_add_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
