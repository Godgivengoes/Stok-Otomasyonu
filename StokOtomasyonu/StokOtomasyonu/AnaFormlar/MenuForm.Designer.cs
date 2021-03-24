
namespace StokOtomasyonu
{
    partial class MenuForm
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
            this.panel_Button_Container = new System.Windows.Forms.Panel();
            this.panel_Form_Show = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Button_Container
            // 
            this.panel_Button_Container.AutoScroll = true;
            this.panel_Button_Container.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Button_Container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Button_Container.Location = new System.Drawing.Point(0, 0);
            this.panel_Button_Container.Name = "panel_Button_Container";
            this.panel_Button_Container.Size = new System.Drawing.Size(150, 640);
            this.panel_Button_Container.TabIndex = 0;
            // 
            // panel_Form_Show
            // 
            this.panel_Form_Show.AutoScroll = true;
            this.panel_Form_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Show.Location = new System.Drawing.Point(150, 0);
            this.panel_Form_Show.Name = "panel_Form_Show";
            this.panel_Form_Show.Size = new System.Drawing.Size(1130, 640);
            this.panel_Form_Show.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 640);
            this.Controls.Add(this.panel_Form_Show);
            this.Controls.Add(this.panel_Button_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Button_Container;
        private System.Windows.Forms.Panel panel_Form_Show;
    }
}