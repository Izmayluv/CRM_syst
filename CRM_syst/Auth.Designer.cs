namespace CRM_syst
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_winName = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.lb_reg = new System.Windows.Forms.Label();
            this.lb_capture = new System.Windows.Forms.Label();
            this.tb_capture = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.Controls.Add(this.lb_winName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 42);
            this.panel6.TabIndex = 4;
            // 
            // lb_winName
            // 
            this.lb_winName.AutoSize = true;
            this.lb_winName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_winName.Font = new System.Drawing.Font("Segoe UI", 10.14286F, System.Drawing.FontStyle.Bold);
            this.lb_winName.Location = new System.Drawing.Point(195, 5);
            this.lb_winName.Name = "lb_winName";
            this.lb_winName.Size = new System.Drawing.Size(171, 32);
            this.lb_winName.TabIndex = 0;
            this.lb_winName.Text = "Авторизация";
            this.lb_winName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(64, 89);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(160, 29);
            this.tb_login.TabIndex = 5;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Location = new System.Drawing.Point(59, 61);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(79, 25);
            this.lb_login.TabIndex = 6;
            this.lb_login.Text = "Логин: ";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(59, 135);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(91, 25);
            this.lb_password.TabIndex = 8;
            this.lb_password.Text = "Пароль: ";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(64, 163);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(160, 29);
            this.tb_password.TabIndex = 7;
            // 
            // btn_auth
            // 
            this.btn_auth.BackColor = System.Drawing.Color.Transparent;
            this.btn_auth.Location = new System.Drawing.Point(85, 211);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(133, 44);
            this.btn_auth.TabIndex = 9;
            this.btn_auth.Text = "Войти";
            this.btn_auth.UseVisualStyleBackColor = false;
            this.btn_auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_reg
            // 
            this.lb_reg.AutoSize = true;
            this.lb_reg.Font = new System.Drawing.Font("Segoe UI Variable Small", 6.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reg.Location = new System.Drawing.Point(71, 263);
            this.lb_reg.Name = "lb_reg";
            this.lb_reg.Size = new System.Drawing.Size(158, 20);
            this.lb_reg.TabIndex = 10;
            this.lb_reg.Text = "Зарегистрироваться?";
            this.lb_reg.Click += new System.EventHandler(this.lb_reg_Click);
            // 
            // lb_capture
            // 
            this.lb_capture.AutoSize = true;
            this.lb_capture.Location = new System.Drawing.Point(326, 188);
            this.lb_capture.Name = "lb_capture";
            this.lb_capture.Size = new System.Drawing.Size(158, 25);
            this.lb_capture.TabIndex = 12;
            this.lb_capture.Text = "Введите капчу: ";
            this.lb_capture.DoubleClick += new System.EventHandler(this.lb_capture_DoubleClick);
            // 
            // tb_capture
            // 
            this.tb_capture.Location = new System.Drawing.Point(331, 216);
            this.tb_capture.Name = "tb_capture";
            this.tb_capture.Size = new System.Drawing.Size(160, 29);
            this.tb_capture.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(313, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 124);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pb_bg
            // 
            this.pb_bg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_bg.Image = ((System.Drawing.Image)(resources.GetObject("pb_bg.Image")));
            this.pb_bg.Location = new System.Drawing.Point(0, 3);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(530, 295);
            this.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bg.TabIndex = 14;
            this.pb_bg.TabStop = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_capture);
            this.Controls.Add(this.tb_capture);
            this.Controls.Add(this.lb_reg);
            this.Controls.Add(this.btn_auth);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pb_bg);
            this.Name = "Auth";
            this.Text = "Auth";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_winName;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Label lb_reg;
        private System.Windows.Forms.Label lb_capture;
        private System.Windows.Forms.TextBox tb_capture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_bg;
    }
}