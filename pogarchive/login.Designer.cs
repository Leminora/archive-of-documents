namespace pogarchive
{
    partial class login
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_up = new System.Windows.Forms.Panel();
            this.label_add = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_in = new System.Windows.Forms.Button();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Логин";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Пароль";
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.label_add);
            this.panel_up.Location = new System.Drawing.Point(12, 12);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(462, 58);
            this.panel_up.TabIndex = 59;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.Location = new System.Drawing.Point(168, 16);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(141, 25);
            this.label_add.TabIndex = 16;
            this.label_add.Text = "Авторизация";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(153, 76);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(187, 20);
            this.textBox_login.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 62;
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.Color.Thistle;
            this.button_in.Location = new System.Drawing.Point(208, 154);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(75, 23);
            this.button_in.TabIndex = 63;
            this.button_in.Text = "Войти";
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.button_in);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.textBox_login);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_in;
    }
}