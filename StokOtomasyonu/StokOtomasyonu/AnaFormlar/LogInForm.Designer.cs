
namespace StokOtomasyonu
{
    partial class LogInForm
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
            this.components = new System.ComponentModel.Container();
            this.label_User_Log_In = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Log_In = new System.Windows.Forms.Button();
            this.checkBox_Remember_Me = new System.Windows.Forms.CheckBox();
            this.timer_Label_MainForm_Info = new System.Windows.Forms.Timer(this.components);
            this.button_Show = new System.Windows.Forms.Button();
            this.pictureBox_User_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_User_Log_In
            // 
            this.label_User_Log_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_User_Log_In.AutoSize = true;
            this.label_User_Log_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User_Log_In.Location = new System.Drawing.Point(312, 225);
            this.label_User_Log_In.Name = "label_User_Log_In";
            this.label_User_Log_In.Size = new System.Drawing.Size(184, 31);
            this.label_User_Log_In.TabIndex = 5;
            this.label_User_Log_In.Text = "Kullanıcı Girişi";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Username.Location = new System.Drawing.Point(250, 300);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Username.Size = new System.Drawing.Size(300, 31);
            this.textBox_Username.TabIndex = 1;
            this.textBox_Username.Text = "Kullanıcı Adı";
            this.textBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Username.Enter += new System.EventHandler(this.TextBox_Username_Enter);
            this.textBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyLogIn);
            this.textBox_Username.Leave += new System.EventHandler(this.TextBox_Username_Leave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Password.Location = new System.Drawing.Point(250, 350);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(300, 31);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "Parola";
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyLogIn);
            this.textBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // button_Log_In
            // 
            this.button_Log_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Log_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Log_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Log_In.Location = new System.Drawing.Point(250, 411);
            this.button_Log_In.Name = "button_Log_In";
            this.button_Log_In.Size = new System.Drawing.Size(300, 32);
            this.button_Log_In.TabIndex = 3;
            this.button_Log_In.Text = "Giriş";
            this.button_Log_In.UseVisualStyleBackColor = true;
            this.button_Log_In.Click += new System.EventHandler(this.Button_Log_In_Click);
            // 
            // checkBox_Remember_Me
            // 
            this.checkBox_Remember_Me.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Remember_Me.AutoSize = true;
            this.checkBox_Remember_Me.Location = new System.Drawing.Point(250, 388);
            this.checkBox_Remember_Me.Name = "checkBox_Remember_Me";
            this.checkBox_Remember_Me.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Remember_Me.TabIndex = 9;
            this.checkBox_Remember_Me.TabStop = false;
            this.checkBox_Remember_Me.Text = "Beni hatırla";
            this.checkBox_Remember_Me.UseVisualStyleBackColor = true;
            this.checkBox_Remember_Me.CheckStateChanged += new System.EventHandler(this.CheckBox_Remember_Me_CheckStateChanged);
            // 
            // timer_Label_MainForm_Info
            // 
            this.timer_Label_MainForm_Info.Enabled = true;
            this.timer_Label_MainForm_Info.Interval = 175;
            this.timer_Label_MainForm_Info.Tick += new System.EventHandler(this.Timer_Label_MainForm_Info_Tick);
            // 
            // button_Show
            // 
            this.button_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Show.BackgroundImage = global::StokOtomasyonu.Properties.Resources.eye_outline;
            this.button_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show.Location = new System.Drawing.Point(556, 350);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(31, 31);
            this.button_Show.TabIndex = 10;
            this.button_Show.TabStop = false;
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Show_MouseDown);
            this.button_Show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Show_MouseUp);
            // 
            // pictureBox_User_Icon
            // 
            this.pictureBox_User_Icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_User_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_User_Icon.Image = global::StokOtomasyonu.Properties.Resources.user_icon;
            this.pictureBox_User_Icon.Location = new System.Drawing.Point(325, 50);
            this.pictureBox_User_Icon.Name = "pictureBox_User_Icon";
            this.pictureBox_User_Icon.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_User_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User_Icon.TabIndex = 4;
            this.pictureBox_User_Icon.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.checkBox_Remember_Me);
            this.Controls.Add(this.button_Log_In);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_User_Log_In);
            this.Controls.Add(this.pictureBox_User_Icon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_User_Icon;
        private System.Windows.Forms.Label label_User_Log_In;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Log_In;
        private System.Windows.Forms.CheckBox checkBox_Remember_Me;
        private System.Windows.Forms.Timer timer_Label_MainForm_Info;
        private System.Windows.Forms.Button button_Show;
    }
}