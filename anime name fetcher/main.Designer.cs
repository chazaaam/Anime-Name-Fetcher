namespace anime_name_fetcher
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btn_fetch = new System.Windows.Forms.Button();
            this.contextEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_profile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_create = new System.Windows.Forms.Button();
            this.lst_names = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_location = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.contextEdit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fetch
            // 
            this.btn_fetch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_fetch.Location = new System.Drawing.Point(0, 0);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(301, 38);
            this.btn_fetch.TabIndex = 0;
            this.btn_fetch.Text = "Fetch names";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // contextEdit
            // 
            this.contextEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextEdit.Name = "contextEdit";
            this.contextEdit.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "All Anime",
            "Currently Watching",
            "Completed",
            "On Hold",
            "Dropped",
            "Plan to Watch"});
            this.cmb_status.Location = new System.Drawing.Point(137, 3);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(138, 21);
            this.cmb_status.TabIndex = 4;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txt_profile);
            this.flowLayoutPanel1.Controls.Add(this.cmb_status);
            this.flowLayoutPanel1.Controls.Add(this.txt_location);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 27);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // txt_profile
            // 
            this.txt_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_profile.Location = new System.Drawing.Point(6, 3);
            this.txt_profile.Name = "txt_profile";
            this.txt_profile.Size = new System.Drawing.Size(125, 20);
            this.txt_profile.TabIndex = 0;
            this.txt_profile.TextChanged += new System.EventHandler(this.txt_profile_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lst_names);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 405);
            this.panel1.TabIndex = 6;
            // 
            // btn_create
            // 
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_create.Location = new System.Drawing.Point(0, 363);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(603, 42);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create Folders";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lst_names
            // 
            this.lst_names.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lst_names.ContextMenuStrip = this.contextEdit;
            this.lst_names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_names.Location = new System.Drawing.Point(0, 65);
            this.lst_names.Name = "lst_names";
            this.lst_names.Size = new System.Drawing.Size(603, 298);
            this.lst_names.TabIndex = 7;
            this.lst_names.UseCompatibleStateImageBehavior = false;
            this.lst_names.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Anime names:";
            this.columnHeader1.Width = 539;
            // 
            // txt_location
            // 
            this.txt_location.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_location.Location = new System.Drawing.Point(281, 3);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(319, 20);
            this.txt_location.TabIndex = 8;
            this.txt_location.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_location_MouseClick);
            this.txt_location.TextChanged += new System.EventHandler(this.txt_location_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_remove);
            this.panel2.Controls.Add(this.btn_fetch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 38);
            this.panel2.TabIndex = 8;
            // 
            // btn_remove
            // 
            this.btn_remove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_remove.Location = new System.Drawing.Point(301, 0);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(301, 38);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Clean up names";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 405);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_Load);
            this.contextEdit.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_profile;
        private System.Windows.Forms.ContextMenuStrip contextEdit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ListView lst_names;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_remove;
    }
}

