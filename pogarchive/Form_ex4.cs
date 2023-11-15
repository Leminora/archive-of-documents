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
    public partial class Form_ex4 : Form
    {
        Form_a form;
        database database = new database();
        public Form_ex4(Form_a form)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = form;
        }
        private void CreateColumns()
        {
            data1.Columns.Add("Wid", String.Empty);
            data1.Columns["Wid"].Visible = false;
            data1.Columns.Add("Surname", "Фамилия сотрудника/-цы");
            data1.Columns.Add("Name", "Имя сотрудника/-цы");
            data1.Columns.Add("Patronymic", "Отчество сотрудника/-цы");
            data1.Columns.Add("Phone", "Номер телефона сотрудника/-цы");
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Workers.Wid, Workers.Surname, Workers.Wname, Workers.Patr, Workers.Phone FROM Workers";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(wha, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Workers.Wid, Workers.Surname, Workers.Wname, Workers.Patr, Workers.Phone FROM Workers WHERE concat (Wid, Surname, Wname, Patr, Phone) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }

        private void Form_ex4_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(data1);
        }

        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = data1.Rows[Index];
                form.textBox_work.Text = row.Cells[0].Value.ToString();

            }
            this.Hide();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(data1);
        }
    }
}
