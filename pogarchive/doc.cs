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
    enum Rowstate
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class doc : Form
    {
        database database = new database();
        public doc()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void doc_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(data);
        }
        private void CreateColumns()
        {
            data.Columns.Add("Did", String.Empty);
            data.Columns["Did"].Visible = false;
            data.Columns.Add("Title", "Название документа");
            data.Columns.Add("Kindofdoc", "Тип документа");
            data.Columns.Add("Departue", "Откуда поступил документ");
            data.Columns.Add("Dated", "Время поступления документа");
            data.Columns.Add("Timegate", "Срок хранения документа");
            data.Columns.Add("Wid", String.Empty);
            data.Columns["Wid"].Visible = false;
            data.Columns.Add("Workers", "Сотрудник архива, принявшего документ");
            data.Columns.Add("Status", "Статус документа");
            data.Columns.Add("Isnew", String.Empty);
            data.Columns["Isnew"].Visible = false;

        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetInt32(6), record.GetString(7), record.GetString(8), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Document.Did, Document.Title, Kindofdoc.kind, Departue.point, Document.dated, timegate.Timegate, Workers.Wid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Workers, docwhere.Docwhere FROM Document, Kindofdoc, Departue, timegate, Workers, docwhere WHERE Document.kid = Kindofdoc.Kid AND Document.depid = Departue.Did AND Document.timegate = timegate.Timeid AND Document.stid = docwhere.ID AND Document.wid = Workers.Wid";
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
                data.Rows[Index].Cells[9].Value = Rowstate.Deleted;
                return;
            }
            data.Rows[Index].Cells[9].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < data.Rows.Count; index++)
            {
                var rowState = (Rowstate)data.Rows[index].Cells[9].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(data.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Document where Did = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = data.Rows[index].Cells[0].Value.ToString();
                    var title = data.Rows[index].Cells[1].Value.ToString();
                    var kindofdoc = data.Rows[index].Cells[2].Value.ToString();
                    var departue = data.Rows[index].Cells[3].Value.ToString();
                    var time = data.Rows[index].Cells[4].Value.ToString();
                    var gate = data.Rows[index].Cells[5].Value.ToString();
                    var worker = data.Rows[index].Cells[6].Value.ToString();
                    var status = data.Rows[index].Cells[8].Value.ToString();
                    var editQuery =
                    $"insert Departue (point) select '{departue}' where not exists (select 1 from Departue where point = '{departue}') \n" +
                    $"insert timegate (Timegate) select '{gate}' where not exists (select 1 from timegate where Timegate = '{gate}') \n" +
                    $"update Document set Title = '{title}', kid = (select Kid from Kindofdoc where kind = '{kindofdoc}'), depid = (select Did from Departue where point = '{departue}'), dated = '{time}', timegate = (select Timeid from timegate where Timegate = '{gate}'), wid = (select Wid from Workers where Wid = '{worker}'), stid = (select ID from docwhere where Docwhere = '{status}') where Did = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        public void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Document.Did, Document.Title, Kindofdoc.kind, Departue.point, Document.dated, timegate.Timegate, Workers.Wid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Workers, docwhere.Docwhere FROM Document, Kindofdoc, Departue, timegate, Workers, docwhere WHERE Document.kid = Kindofdoc.Kid AND Document.depid = Departue.Did AND Document.timegate = timegate.Timeid AND Document.stid = docwhere.ID AND Document.wid = Workers.Wid AND concat (Title, kind, point, dated, timegate, Surname, Wname, Patr, Docwhere) like '%" + textBox1.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }
       
        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(data);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void delete__Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Change__Click(object sender, EventArgs e)
        {
            Form_edit editform = new Form_edit(this);
            editform.ShowDialog();
        }

        private void new__Click(object sender, EventArgs e)
        {
            Form_add addform = new Form_add();
            addform.Show();
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(data);
        }
    }
}
