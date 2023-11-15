namespace pogarchive
{
    partial class doc
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
            this.data = new System.Windows.Forms.DataGridView();
            this.panel_down = new System.Windows.Forms.Panel();
            this.delete_ = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_ = new System.Windows.Forms.Button();
            this.new_ = new System.Windows.Forms.Button();
            this.panel_up = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel_down.SuspendLayout();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(6, 61);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(998, 287);
            this.data.TabIndex = 25;
            // 
            // panel_down
            // 
            this.panel_down.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_down.Controls.Add(this.delete_);
            this.panel_down.Controls.Add(this.button_refresh);
            this.panel_down.Controls.Add(this.button_search);
            this.panel_down.Controls.Add(this.label2);
            this.panel_down.Controls.Add(this.Change_);
            this.panel_down.Controls.Add(this.new_);
            this.panel_down.Location = new System.Drawing.Point(6, 347);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(998, 100);
            this.panel_down.TabIndex = 24;
            // 
            // delete_
            // 
            this.delete_.BackColor = System.Drawing.Color.Thistle;
            this.delete_.Location = new System.Drawing.Point(431, 45);
            this.delete_.Name = "delete_";
            this.delete_.Size = new System.Drawing.Size(146, 24);
            this.delete_.TabIndex = 14;
            this.delete_.Text = "Удаление записи";
            this.delete_.UseVisualStyleBackColor = false;
            this.delete_.Click += new System.EventHandler(this.delete__Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Thistle;
            this.button_refresh.Location = new System.Drawing.Point(818, 45);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(155, 23);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "Обновление базы данных";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Thistle;
            this.button_search.Location = new System.Drawing.Point(626, 45);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(142, 23);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Сохранить изменения";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Управление записями";
            // 
            // Change_
            // 
            this.Change_.BackColor = System.Drawing.Color.Thistle;
            this.Change_.Location = new System.Drawing.Point(216, 46);
            this.Change_.Name = "Change_";
            this.Change_.Size = new System.Drawing.Size(146, 23);
            this.Change_.TabIndex = 2;
            this.Change_.Text = "Изменение записи";
            this.Change_.UseVisualStyleBackColor = false;
            this.Change_.Click += new System.EventHandler(this.Change__Click);
            // 
            // new_
            // 
            this.new_.BackColor = System.Drawing.Color.Thistle;
            this.new_.Location = new System.Drawing.Point(25, 46);
            this.new_.Name = "new_";
            this.new_.Size = new System.Drawing.Size(141, 23);
            this.new_.TabIndex = 0;
            this.new_.Text = "Новая запись";
            this.new_.UseVisualStyleBackColor = false;
            this.new_.Click += new System.EventHandler(this.new__Click);
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.textBox1);
            this.panel_up.Controls.Add(this.main);
            this.panel_up.Controls.Add(this.label1);
            this.panel_up.Location = new System.Drawing.Point(6, 2);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(998, 62);
            this.panel_up.TabIndex = 23;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.Thistle;
            this.main.Location = new System.Drawing.Point(884, 19);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(89, 23);
            this.main.TabIndex = 13;
            this.main.Text = "Назад";
            this.main.UseVisualStyleBackColor = false;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "База данных документов";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 448);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_up);
            this.Name = "doc";
            this.Text = "doc";
            this.Load += new System.EventHandler(this.doc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel_down.ResumeLayout(false);
            this.panel_down.PerformLayout();
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Button delete_;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change_;
        private System.Windows.Forms.Button new_;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}