namespace CRM_syst
{
    partial class Reports
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_winName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.lb_winName);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.lb_user);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(837, 42);
            this.panel6.TabIndex = 3;
            // 
            // lb_winName
            // 
            this.lb_winName.AutoSize = true;
            this.lb_winName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_winName.Font = new System.Drawing.Font("Segoe UI", 10.14286F, System.Drawing.FontStyle.Bold);
            this.lb_winName.Location = new System.Drawing.Point(328, 5);
            this.lb_winName.Name = "lb_winName";
            this.lb_winName.Size = new System.Drawing.Size(101, 32);
            this.lb_winName.TabIndex = 0;
            this.lb_winName.Text = "Отчёты";
            this.lb_winName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Перечень руководителей отделов",
            "Проекты выполняемые в данный момент",
            "Данные о стоимости выполненных договоров",
            "Участие сотрудника в проектах"});
            this.comboBox1.Location = new System.Drawing.Point(12, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Выберите отчёт";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(584, 10);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(205, 25);
            this.lb_user.TabIndex = 9;
            this.lb_user.Text = "Логин пользователя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(825, 534);
            this.dataGridView1.TabIndex = 5;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_winName;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}