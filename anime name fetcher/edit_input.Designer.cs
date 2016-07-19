namespace anime_name_fetcher
{
    partial class edit_input
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
            this.txt_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_txt
            // 
            this.txt_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_txt.Location = new System.Drawing.Point(0, 0);
            this.txt_txt.Name = "txt_txt";
            this.txt_txt.Size = new System.Drawing.Size(284, 20);
            this.txt_txt.TabIndex = 0;
            this.txt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_txt_KeyPress);
            // 
            // edit_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 23);
            this.ControlBox = false;
            this.Controls.Add(this.txt_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "edit_input";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.edit_input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_txt;
    }
}