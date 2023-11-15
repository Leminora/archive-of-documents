using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pogarchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_docs_Click(object sender, EventArgs e)
        {
            doc docform = new doc();
            docform.Show();
            this.Hide();
        }

        private void button_workers_Click(object sender, EventArgs e)
        {
            Form_worker workerform = new Form_worker();
            workerform.Show();
            this.Hide();
        }

        private void button_docsnow_Click(object sender, EventArgs e)
        {
            Form_where nowform = new Form_where();
            nowform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login nowform = new login();
            nowform.Show();
            this.Hide();
        }
    }
}
