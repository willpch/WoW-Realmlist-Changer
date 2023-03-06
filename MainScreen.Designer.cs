namespace WoW_Realmlist_Changer
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            bntLaunch = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnAddSvr = new Button();
            btnDeleteSrv = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bntLaunch
            // 
            bntLaunch.BackColor = Color.Khaki;
            bntLaunch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntLaunch.Location = new Point(364, 275);
            bntLaunch.Name = "bntLaunch";
            bntLaunch.Size = new Size(112, 60);
            bntLaunch.TabIndex = 0;
            bntLaunch.Text = "Launch WOW";
            bntLaunch.UseVisualStyleBackColor = false;
            bntLaunch.Click += bntLaunch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 21);
            label1.TabIndex = 1;
            label1.Text = "WOW 3.5.5a REALMLIST CHANGER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 302);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servers";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(334, 274);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddSvr
            // 
            btnAddSvr.BackColor = Color.LimeGreen;
            btnAddSvr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSvr.Location = new Point(364, 55);
            btnAddSvr.Name = "btnAddSvr";
            btnAddSvr.Size = new Size(112, 27);
            btnAddSvr.TabIndex = 3;
            btnAddSvr.Text = "Add a Server";
            btnAddSvr.UseVisualStyleBackColor = false;
            btnAddSvr.Click += btnAddSvr_Click;
            // 
            // btnDeleteSrv
            // 
            btnDeleteSrv.BackColor = Color.Red;
            btnDeleteSrv.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteSrv.ForeColor = SystemColors.ButtonFace;
            btnDeleteSrv.Location = new Point(364, 88);
            btnDeleteSrv.Name = "btnDeleteSrv";
            btnDeleteSrv.Size = new Size(112, 27);
            btnDeleteSrv.TabIndex = 4;
            btnDeleteSrv.Text = "Delete Selected";
            btnDeleteSrv.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(487, 347);
            Controls.Add(btnDeleteSrv);
            Controls.Add(btnAddSvr);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(bntLaunch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(503, 386);
            MinimumSize = new Size(503, 386);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WoW Realmlist Changer - v1.0.0";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntLaunch;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnAddSvr;
        private Button btnDeleteSrv;
    }
}