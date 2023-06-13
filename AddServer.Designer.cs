namespace WoW_Realmlist_Changer
{
    partial class AddServer
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
            this.txtSvrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRealmlist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.btnAddSvr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSvrName
            // 
            this.txtSvrName.Location = new System.Drawing.Point(105, 55);
            this.txtSvrName.Name = "txtSvrName";
            this.txtSvrName.PlaceholderText = "Example: Warmane";
            this.txtSvrName.Size = new System.Drawing.Size(215, 25);
            this.txtSvrName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realmlist:";
            // 
            // txtRealmlist
            // 
            this.txtRealmlist.Location = new System.Drawing.Point(105, 101);
            this.txtRealmlist.Name = "txtRealmlist";
            this.txtRealmlist.PlaceholderText = "set realmlist logon.warmane.com";
            this.txtRealmlist.Size = new System.Drawing.Size(215, 25);
            this.txtRealmlist.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "About:";
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(105, 146);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.PlaceholderText = "7x Exp, good population.";
            this.txtAbout.Size = new System.Drawing.Size(215, 25);
            this.txtAbout.TabIndex = 4;
            // 
            // btnAddSvr
            // 
            this.btnAddSvr.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddSvr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSvr.Location = new System.Drawing.Point(102, 199);
            this.btnAddSvr.Name = "btnAddSvr";
            this.btnAddSvr.Size = new System.Drawing.Size(140, 37);
            this.btnAddSvr.TabIndex = 6;
            this.btnAddSvr.Text = "Save Realmlist";
            this.btnAddSvr.UseVisualStyleBackColor = false;
            this.btnAddSvr.Click += new System.EventHandler(this.btnAddSvr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adding a Server";
            // 
            // AddServer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddSvr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRealmlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSvrName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(345, 287);
            this.MinimumSize = new System.Drawing.Size(345, 287);
            this.Name = "AddServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Realmlist";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSvrName;
        private Label label1;
        private Label label2;
        private TextBox txtRealmlist;
        private Label label3;
        private TextBox txtAbout;
        private Button btnAddSvr;
        private Label label4;
    }
}