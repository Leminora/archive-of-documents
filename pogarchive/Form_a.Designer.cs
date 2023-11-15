namespace pogarchive
{
    partial class Form_a
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_person = new System.Windows.Forms.Button();
            this.textBox_work = new System.Windows.Forms.TextBox();
            this.textBox_etime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_up = new System.Windows.Forms.Panel();
            this.label_add = new System.Windows.Forms.Label();
            this.textBox_stime = new System.Windows.Forms.TextBox();
            this.button_doc = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_person
            // 
            this.button_person.Location = new System.Drawing.Point(542, 154);
            this.button_person.Name = "button_person";
            this.button_person.Size = new System.Drawing.Size(30, 20);
            this.button_person.TabIndex = 97;
            this.button_person.Text = "...";
            this.button_person.UseVisualStyleBackColor = true;
            this.button_person.Click += new System.EventHandler(this.button_person_Click);
            // 
            // textBox_work
            // 
            this.textBox_work.Location = new System.Drawing.Point(152, 154);
            this.textBox_work.Name = "textBox_work";
            this.textBox_work.Size = new System.Drawing.Size(384, 20);
            this.textBox_work.TabIndex = 96;
            // 
            // textBox_etime
            // 
            this.textBox_etime.Location = new System.Drawing.Point(152, 128);
            this.textBox_etime.Name = "textBox_etime";
            this.textBox_etime.Size = new System.Drawing.Size(420, 20);
            this.textBox_etime.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Время сдачи";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Thistle;
            this.button_save.Location = new System.Drawing.Point(255, 231);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 90;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Ответственный/-ая";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Название документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Время получения";
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.label_add);
            this.panel_up.Location = new System.Drawing.Point(12, 12);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(562, 58);
            this.panel_up.TabIndex = 85;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.Location = new System.Drawing.Point(161, 16);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(251, 25);
            this.label_add.TabIndex = 16;
            this.label_add.Text = "Создание новой записи";
            // 
            // textBox_stime
            // 
            this.textBox_stime.Location = new System.Drawing.Point(152, 102);
            this.textBox_stime.Name = "textBox_stime";
            this.textBox_stime.Size = new System.Drawing.Size(420, 20);
            this.textBox_stime.TabIndex = 98;
            // 
            // button_doc
            // 
            this.button_doc.Location = new System.Drawing.Point(542, 76);
            this.button_doc.Name = "button_doc";
            this.button_doc.Size = new System.Drawing.Size(30, 20);
            this.button_doc.TabIndex = 100;
            this.button_doc.Text = "...";
            this.button_doc.UseVisualStyleBackColor = true;
            this.button_doc.Click += new System.EventHandler(this.button_doc_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(152, 76);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(384, 20);
            this.textBox_title.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 103;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Отдавший/-ая";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 20);
            this.button2.TabIndex = 106;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Принявший/-ая";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_doc);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_stime);
            this.Controls.Add(this.button_person);
            this.Controls.Add(this.textBox_work);
            this.Controls.Add(this.textBox_etime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_up);
            this.Name = "Form_a";
            this.Text = "Form_a";
            this.Load += new System.EventHandler(this.Form_a_Load);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_person;
        public System.Windows.Forms.TextBox textBox_work;
        public System.Windows.Forms.TextBox textBox_etime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Label label_add;
        public System.Windows.Forms.TextBox textBox_stime;
        private System.Windows.Forms.Button button_doc;
        public System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}