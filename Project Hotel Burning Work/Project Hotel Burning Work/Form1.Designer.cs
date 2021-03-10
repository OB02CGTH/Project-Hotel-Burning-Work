
namespace Project_Hotel_Burning_Work
{
    partial class home
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
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_regis = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.lb_mail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_room = new System.Windows.Forms.Button();
            this.bt_book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(883, 15);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(59, 13);
            this.lb_password.TabIndex = 0;
            this.lb_password.Text = "Password :";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(1054, 12);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 1;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // bt_regis
            // 
            this.bt_regis.Location = new System.Drawing.Point(1135, 12);
            this.bt_regis.Name = "bt_regis";
            this.bt_regis.Size = new System.Drawing.Size(75, 23);
            this.bt_regis.TabIndex = 2;
            this.bt_regis.Text = "Register";
            this.bt_regis.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(948, 12);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 3;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(777, 12);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(100, 20);
            this.tb_mail.TabIndex = 4;
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(739, 15);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(32, 13);
            this.lb_mail.TabIndex = 5;
            this.lb_mail.Text = "Mail :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_home
            // 
            this.bt_home.Location = new System.Drawing.Point(12, 12);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(300, 80);
            this.bt_home.TabIndex = 7;
            this.bt_home.Text = "หน้าหลัก";
            this.bt_home.UseVisualStyleBackColor = true;
            // 
            // bt_room
            // 
            this.bt_room.Location = new System.Drawing.Point(12, 98);
            this.bt_room.Name = "bt_room";
            this.bt_room.Size = new System.Drawing.Size(300, 80);
            this.bt_room.TabIndex = 8;
            this.bt_room.Text = "ห้องพัก";
            this.bt_room.UseVisualStyleBackColor = true;
            // 
            // bt_book
            // 
            this.bt_book.Location = new System.Drawing.Point(12, 184);
            this.bt_book.Name = "bt_book";
            this.bt_book.Size = new System.Drawing.Size(300, 80);
            this.bt_book.TabIndex = 9;
            this.bt_book.Text = "ประวัติการจอง";
            this.bt_book.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 638);
            this.Controls.Add(this.bt_book);
            this.Controls.Add(this.bt_room);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_mail);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.bt_regis);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_password);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_regis;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_room;
        private System.Windows.Forms.Button bt_book;
    }
}

