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
            txtSvrName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRealmlist = new TextBox();
            label3 = new Label();
            txtAbout = new TextBox();
            btnAddSvr = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtSvrName
            // 
            txtSvrName.Location = new Point(105, 55);
            txtSvrName.Name = "txtSvrName";
            txtSvrName.PlaceholderText = "Example: Warmane";
            txtSvrName.Size = new Size(215, 25);
            txtSvrName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 1;
            label1.Text = "Server Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 104);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 3;
            label2.Text = "Realmlist:";
            // 
            // txtRealmlist
            // 
            txtRealmlist.Location = new Point(105, 101);
            txtRealmlist.Name = "txtRealmlist";
            txtRealmlist.PlaceholderText = "set realmlist logon.warmane.com";
            txtRealmlist.Size = new Size(215, 25);
            txtRealmlist.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 5;
            label3.Text = "About:";
            // 
            // txtAbout
            // 
            txtAbout.Location = new Point(105, 146);
            txtAbout.Name = "txtAbout";
            txtAbout.PlaceholderText = "7x Exp, good population.";
            txtAbout.Size = new Size(215, 25);
            txtAbout.TabIndex = 4;
            // 
            // btnAddSvr
            // 
            btnAddSvr.BackColor = Color.LimeGreen;
            btnAddSvr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSvr.Location = new Point(102, 199);
            btnAddSvr.Name = "btnAddSvr";
            btnAddSvr.Size = new Size(140, 37);
            btnAddSvr.TabIndex = 6;
            btnAddSvr.Text = "Save Realmlist";
            btnAddSvr.UseVisualStyleBackColor = false;
            btnAddSvr.Click += btnAddSvr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 9);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 7;
            label4.Text = "Adding a Server";
            // 
            // AddServer
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 248);
            Controls.Add(label4);
            Controls.Add(btnAddSvr);
            Controls.Add(label3);
            Controls.Add(txtAbout);
            Controls.Add(label2);
            Controls.Add(txtRealmlist);
            Controls.Add(label1);
            Controls.Add(txtSvrName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(345, 287);
            MinimumSize = new Size(345, 287);
            Name = "AddServer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add a Realmlist";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
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