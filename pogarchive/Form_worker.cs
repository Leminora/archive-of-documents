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
   

    public partial class Form_worker : Form
    {
        database database = new database();
        public Form_worker()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void Form_worker_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(data);
        }
        private void CreateColumns()
        {
            data.Columns.Add("Wid", String.Empty);
            data.Columns["Wid"].Visible = false;
            data.Columns.Add("Surname", "Фамилия работника/-цы");
            data.Columns.Add("Name", "Имя работника/-цы");
            data.Columns.Add("Patronymic", "Отчество работника/-цы");
            data.Columns.Add("Phone", "Номер телефона работника/-цы");
            data.Columns.Add("Isnew", String.Empty);
            data.Columns["Isnew"].Visible = false;

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


        private void deleteRow()
        {
            int Index = data.CurrentCell.RowIndex;
            data.Rows[Index].Visible = false;
            if (data.Rows[Index].Cells[0].Value.ToString() == string.Empty)
            {
                data.Rows[Index].Cells[5].Value = Rowstate.Deleted;
                return;
            }
            data.Rows[Index].Cells[5].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < data.Rows.Count; index++)
            {
                var rowState = (Rowstate)data.Rows[index].Cells[5].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(data.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Workers where Wid = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = data.Rows[index].Cells[0].Value.ToString();
                    var surname = data.Rows[index].Cells[1].Value.ToString();
                    var name = data.Rows[index].Cells[2].Value.ToString();
                    var patronymic = data.Rows[index].Cells[3].Value.ToString();
                    var phone = data.Rows[index].Cells[4].Value.ToString();
                    var editQuery =
                    $"update Workers set Surname = '{surname}', Wname = '{name}', Patr = '{patronymic}', phone = '{phone}' where Wid = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        public void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Workers.Wid, Workers.Surname, Workers.Wname, Workers.Patr, Workers.Phone FROM Workers WHERE concat (Wid, Surname, Wname, Patr, Phone) like '%" + textBox_s.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }
           
        private void back_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
            this.Hide();
        }

        private void textBox_s_TextChanged(object sender, EventArgs e)
        {
            Search(data);
        }

        private void newthing_Click(object sender, EventArgs e)
        {
            Form_addw addform = new Form_addw();
            addform.Show();
        }

        private void changee_Click(object sender, EventArgs e)
        {
            Form_editw editform = new Form_editw(this);
            editform.ShowDialog();
        }

        private void del_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void reftesh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(data);
        }

        private void whyyyyupdate_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
