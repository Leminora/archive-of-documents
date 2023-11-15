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
    public partial class Form_ex3 : Form
    {
        Form_a form;
        database database = new database();
        public Form_ex3(Form_a form)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = form;
        }
        private void CreateColumns()
        {
            data1.Columns.Add("Did", String.Empty);
            data1.Columns["Did"].Visible = false;
            data1.Columns.Add("Title", "Название документа");
            data1.Columns.Add("Kindofdoc", "Тип документа");
            data1.Columns.Add("Departue", "Откуда поступил документ");
            data1.Columns.Add("Dated", "Время поступления документа");
            data1.Columns.Add("Timegate", "Срок хранения документа");
            data1.Columns.Add("Wid", String.Empty);
            data1.Columns["Wid"].Visible = false;
            data1.Columns.Add("Workers", "Сотрудник архива, принявшего документ");
            data1.Columns.Add("Status", "Статус документа");
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), record.GetInt32(6), record.GetString(7), record.GetString(8), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Document.Did, Document.Title, Kindofdoc.kind, Departue.point, Document.dated, timegate.Timegate, Workers.Wid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Workers, docwhere.Docwhere FROM Document, Kindofdoc, Departue, timegate, Workers, docwhere WHERE Document.kid = Kindofdoc.Kid AND Document.depid = Departue.Did AND Document.timegate = timegate.Timeid AND Document.stid = docwhere.ID AND Document.wid = Workers.Wid and not Document.stid = 2";
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
            string searchString = $"select Document.Did, Document.Title, Kindofdoc.kind, Departue.point, Document.dated, timegate.Timegate, Workers.Wid, Workers.Surname + ' ' + Workers.Wname + ' ' + Workers.Patr as Workers, docwhere.Docwhere FROM Document, Kindofdoc, Departue, timegate, Workers, docwhere WHERE Document.kid = Kindofdoc.Kid AND Document.depid = Departue.Did AND Document.timegate = timegate.Timeid AND Document.stid = docwhere.ID AND Document.wid = Workers.Wid and not Document.stid = 2 AND concat (Title, kind, point, dated, timegate, Surname, Wname, Patr, Docwhere) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }

        private void Form_ex3_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(data1);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(data1);
        }

        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = data1.Rows[Index];
                form.textBox_title.Text = row.Cells[0].Value.ToString();

            }
            this.Hide();
        }
    }
}
