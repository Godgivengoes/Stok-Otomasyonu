namespace StokOtomasyonu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Form_Info = new System.Windows.Forms.Label();
            this.label_Project_Name = new System.Windows.Forms.Label();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Windows_State = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.timer_Background = new System.Windows.Forms.Timer(this.components);
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.panel_Form_Show = new System.Windows.Forms.Panel();
            this.label_Clock = new System.Windows.Forms.Label();
            this.panel_Seperate = new System.Windows.Forms.Panel();
            this.label_Info = new System.Windows.Forms.Label();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Resize_Right = new System.Windows.Forms.Panel();
            this.panel_Resize_Left = new System.Windows.Forms.Panel();
            this.panel_Resize_Bottom = new System.Windows.Forms.Panel();
            this.panel_Resize_Top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Top.Controls.Add(this.pictureBox1);
            this.panel_Top.Controls.Add(this.label_Form_Info);
            this.panel_Top.Controls.Add(this.label_Project_Name);
            this.panel_Top.Controls.Add(this.button_Minimize);
            this.panel_Top.Controls.Add(this.button_Windows_State);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(800, 40);
            this.panel_Top.TabIndex = 0;
            // 
            // label_Form_Info
            // 
            this.label_Form_Info.AutoSize = true;
            this.label_Form_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Form_Info.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label_Form_Info.Location = new System.Drawing.Point(225, 8);
            this.label_Form_Info.Name = "label_Form_Info";
            this.label_Form_Info.Size = new System.Drawing.Size(98, 25);
            this.label_Form_Info.TabIndex = 4;
            this.label_Form_Info.Text = "FORM_INFO";
            // 
            // label_Project_Name
            // 
            this.label_Project_Name.AutoSize = true;
            this.label_Project_Name.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Name.Location = new System.Drawing.Point(37, 8);
            this.label_Project_Name.Name = "label_Project_Name";
            this.label_Project_Name.Size = new System.Drawing.Size(147, 23);
            this.label_Project_Name.TabIndex = 3;
            this.label_Project_Name.Text = "Stok Otomasyonu";
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackColor = System.Drawing.Color.White;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Minimize.Location = new System.Drawing.Point(570, 3);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(72, 34);
            this.button_Minimize.TabIndex = 0;
            this.button_Minimize.TabStop = false;
            this.button_Minimize.Text = "küçült";
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // button_Windows_State
            // 
            this.button_Windows_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Windows_State.BackColor = System.Drawing.Color.White;
            this.button_Windows_State.FlatAppearance.BorderSize = 0;
            this.button_Windows_State.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Windows_State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Windows_State.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Windows_State.Location = new System.Drawing.Point(648, 3);
            this.button_Windows_State.Name = "button_Windows_State";
            this.button_Windows_State.Size = new System.Drawing.Size(72, 34);
            this.button_Windows_State.TabIndex = 0;
            this.button_Windows_State.TabStop = false;
            this.button_Windows_State.Text = "genişlet";
            this.button_Windows_State.UseVisualStyleBackColor = false;
            this.button_Windows_State.Click += new System.EventHandler(this.Button_Windows_State_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.White;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(725, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(72, 34);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.Text = "kapat";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // timer_Background
            // 
            this.timer_Background.Enabled = true;
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 1000;
            this.timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // panel_Form_Show
            // 
            this.panel_Form_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Form_Show.BackColor = System.Drawing.Color.Transparent;
            this.panel_Form_Show.Location = new System.Drawing.Point(0, 40);
            this.panel_Form_Show.Name = "panel_Form_Show";
            this.panel_Form_Show.Size = new System.Drawing.Size(800, 520);
            this.panel_Form_Show.TabIndex = 1;
            // 
            // label_Clock
            // 
            this.label_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Clock.AutoSize = true;
            this.label_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clock.Location = new System.Drawing.Point(617, 7);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(180, 24);
            this.label_Clock.TabIndex = 0;
            this.label_Clock.Text = "31/12/9999  24:59:59";
            // 
            // panel_Seperate
            // 
            this.panel_Seperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Seperate.BackColor = System.Drawing.Color.LightBlue;
            this.panel_Seperate.Location = new System.Drawing.Point(606, 0);
            this.panel_Seperate.Name = "panel_Seperate";
            this.panel_Seperate.Size = new System.Drawing.Size(5, 40);
            this.panel_Seperate.TabIndex = 1;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(3, 10);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(47, 20);
            this.label_Info.TabIndex = 2;
            this.label_Info.Text = "INFO";
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_Bottom.Controls.Add(this.panel_Seperate);
            this.panel_Bottom.Controls.Add(this.label_Info);
            this.panel_Bottom.Controls.Add(this.label_Clock);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 560);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(800, 40);
            this.panel_Bottom.TabIndex = 2;
            // 
            // panel_Resize_Right
            // 
            this.panel_Resize_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Resize_Right.BackColor = System.Drawing.Color.Transparent;
            this.panel_Resize_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Resize_Right.Location = new System.Drawing.Point(799, 0);
            this.panel_Resize_Right.Name = "panel_Resize_Right";
            this.panel_Resize_Right.Size = new System.Drawing.Size(1, 600);
            this.panel_Resize_Right.TabIndex = 3;
            this.panel_Resize_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Right_MouseDown);
            this.panel_Resize_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Right_MouseMove);
            this.panel_Resize_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Right_MouseUp);
            // 
            // panel_Resize_Left
            // 
            this.panel_Resize_Left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Resize_Left.BackColor = System.Drawing.Color.Transparent;
            this.panel_Resize_Left.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Resize_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Resize_Left.Name = "panel_Resize_Left";
            this.panel_Resize_Left.Size = new System.Drawing.Size(1, 600);
            this.panel_Resize_Left.TabIndex = 4;
            this.panel_Resize_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Left_MouseDown);
            this.panel_Resize_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Left_MouseMove);
            this.panel_Resize_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Left_MouseUp);
            // 
            // panel_Resize_Bottom
            // 
            this.panel_Resize_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Resize_Bottom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_Resize_Bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_Resize_Bottom.Location = new System.Drawing.Point(0, 599);
            this.panel_Resize_Bottom.Name = "panel_Resize_Bottom";
            this.panel_Resize_Bottom.Size = new System.Drawing.Size(800, 1);
            this.panel_Resize_Bottom.TabIndex = 4;
            this.panel_Resize_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Bottom_MouseDown);
            this.panel_Resize_Bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Bottom_MouseMove);
            this.panel_Resize_Bottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Bottom_MouseUp);
            // 
            // panel_Resize_Top
            // 
            this.panel_Resize_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Resize_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Resize_Top.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_Resize_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Resize_Top.Name = "panel_Resize_Top";
            this.panel_Resize_Top.Size = new System.Drawing.Size(800, 1);
            this.panel_Resize_Top.TabIndex = 5;
            this.panel_Resize_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Top_MouseDown);
            this.panel_Resize_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Top_MouseMove);
            this.panel_Resize_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Resize_Top_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StokOtomasyonu.Properties.Resources.engineering;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel_Resize_Top);
            this.Controls.Add(this.panel_Resize_Bottom);
            this.Controls.Add(this.panel_Resize_Left);
            this.Controls.Add(this.panel_Resize_Right);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Form_Show);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Stok Otomasyonu";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Windows_State;
        private System.Windows.Forms.Label label_Project_Name;
        private System.Windows.Forms.Timer timer_Background;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Label label_Form_Info;
        private System.Windows.Forms.Panel panel_Form_Show;
        private System.Windows.Forms.Label label_Clock;
        private System.Windows.Forms.Panel panel_Seperate;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Resize_Right;
        private System.Windows.Forms.Panel panel_Resize_Left;
        private System.Windows.Forms.Panel panel_Resize_Bottom;
        private System.Windows.Forms.Panel panel_Resize_Top;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

