namespace pogarchive
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_docsnow = new System.Windows.Forms.Button();
            this.button_workers = new System.Windows.Forms.Button();
            this.button_docs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_docsnow
            // 
            this.button_docsnow.BackColor = System.Drawing.Color.Thistle;
            this.button_docsnow.Location = new System.Drawing.Point(158, 219);
            this.button_docsnow.Name = "button_docsnow";
            this.button_docsnow.Size = new System.Drawing.Size(169, 36);
            this.button_docsnow.TabIndex = 10;
            this.button_docsnow.Text = "База данных отслеживания документов";
            this.button_docsnow.UseVisualStyleBackColor = false;
            this.button_docsnow.Click += new System.EventHandler(this.button_docsnow_Click);
            // 
            // button_workers
            // 
            this.button_workers.BackColor = System.Drawing.Color.Thistle;
            this.button_workers.Location = new System.Drawing.Point(158, 166);
            this.button_workers.Name = "button_workers";
            this.button_workers.Size = new System.Drawing.Size(169, 36);
            this.button_workers.TabIndex = 9;
            this.button_workers.Text = "База данных работников";
            this.button_workers.UseVisualStyleBackColor = false;
            this.button_workers.Click += new System.EventHandler(this.button_workers_Click);
            // 
            // button_docs
            // 
            this.button_docs.BackColor = System.Drawing.Color.Thistle;
            this.button_docs.Location = new System.Drawing.Point(158, 115);
            this.button_docs.Name = "button_docs";
            this.button_docs.Size = new System.Drawing.Size(169, 36);
            this.button_docs.TabIndex = 8;
            this.button_docs.Text = "База данных документов";
            this.button_docs.UseVisualStyleBackColor = false;
            this.button_docs.Click += new System.EventHandler(this.button_docs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 79);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Архив документов отдела";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(158, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_docsnow);
            this.Controls.Add(this.button_workers);
            this.Controls.Add(this.button_docs);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_docsnow;
        private System.Windows.Forms.Button button_workers;
        private System.Windows.Forms.Button button_docs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

