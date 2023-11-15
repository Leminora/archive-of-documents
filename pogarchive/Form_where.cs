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
    public partial class Form_where : Form
    {
        database database = new database();
        public Form_where()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_where_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(data3);
        }
        private void CreateColumns()
        {
            data3.Columns.Add("DNid", String.Empty);
            data3.Columns["DNid"].Visible = false;
            data3.Columns.Add("Title", "Название документа");
            data3.Columns.Add("TimeB", "Время получения документа");
            data3.Columns.Add("TimeE", "Время сдачи документа");
            data3.Columns.Add("Work", "Ответственный за документ");
            data3.Columns.Add("Work2", "Выдавший сотрудник");
            data3.Columns.Add("Work3", "Принявший сотрудник");
            data3.Columns.Add("Isnew", String.Empty);
            data3.Columns["Isnew"].Visible = false;

        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), record.GetDateTime(3), record.GetString(4), record.GetString(5), record.GetString(6), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select DocNow.DNid, Document.Title, DocNow.dates, DocNow.datee, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Work, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Work2, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Work3 FROM DocNow, Document, Workers WHERE DocNow.dtid = Document.Did AND DocNow.oid = Workers.Wid AND DocNow.gid = Workers.Wid AND DocNow.tid = Workers.Wid ";
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
            int Index = data3.CurrentCell.RowIndex;
            data3.Rows[Index].Visible = false;
            if (data3.Rows[Index].Cells[0].Value.ToString() == string.Empty)
            {
                data3.Rows[Index].Cells[7].Value = Rowstate.Deleted;
                return;
            }
            data3.Rows[Index].Cells[7].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < data3.Rows.Count; index++)
            {
                var rowState = (Rowstate)data3.Rows[index].Cells[7].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(data3.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from DocNow where DNid = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = data3.Rows[index].Cells[0].Value.ToString();
                    var times = data3.Rows[index].Cells[2].Value.ToString();
                    var timee = data3.Rows[index].Cells[3].Value.ToString();
                    var editQuery =
                    $"update DocNow set date_s = '{times}', date_e = '{timee}' where DNid = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        public void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select DocNow.DNid, Document.Title, DocNow.dates, DocNow.datee, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as oid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as gid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as tid FROM DocNow, Document, Workers WHERE DocNow.dtid = Document.Did AND DocNow.oid = Workers.Wid AND DocNow.gid = Workers.Wid AND DocNow.tid = Workers.Wid AND concat (Title, dates, datee, Surname, Wname, Patr) like '%" + textBox_s.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }
       
        private void reftesh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(data3);
        }

        private void whyyyyupdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void del_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void changee_Click(object sender, EventArgs e)
        {
            Form_f editform = new Form_f(this);
            editform.ShowDialog();
        }

        private void newthing_Click(object sender, EventArgs e)
        {
            Form_a addform = new Form_a();
            addform.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
            this.Hide();
        }

        private void textBox_s_TextChanged(object sender, EventArgs e)
        {
            Search(data3);
        }


        private void data3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DateTime time = DateTime.Now.Date;
            DateTime time_p = Convert.ToDateTime(data3.Rows[e.RowIndex].Cells[3].Value);
            string type = Convert.ToString(data3.Rows[e.RowIndex].Cells[6].Value);
            if (type == "В архиве")
            {
                data3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MediumSpringGreen;
            }
            else if ((type == "На руках") && time_p < time)
            {
                data3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }
    }
}
