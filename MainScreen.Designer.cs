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
            this.bntLaunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSvr = new System.Windows.Forms.Button();
            this.btnDeleteSrv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntLaunch
            // 
            this.bntLaunch.BackColor = System.Drawing.Color.Khaki;
            this.bntLaunch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntLaunch.Location = new System.Drawing.Point(364, 275);
            this.bntLaunch.Name = "bntLaunch";
            this.bntLaunch.Size = new System.Drawing.Size(112, 60);
            this.bntLaunch.TabIndex = 0;
            this.bntLaunch.Text = "Launch WOW";
            this.bntLaunch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "WOW 3.5.5a REALMLIST CHANGER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(334, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddSvr
            // 
            this.btnAddSvr.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddSvr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSvr.Location = new System.Drawing.Point(364, 55);
            this.btnAddSvr.Name = "btnAddSvr";
            this.btnAddSvr.Size = new System.Drawing.Size(112, 27);
            this.btnAddSvr.TabIndex = 3;
            this.btnAddSvr.Text = "Add a Server";
            this.btnAddSvr.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSrv
            // 
            this.btnDeleteSrv.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSrv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSrv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteSrv.Location = new System.Drawing.Point(364, 88);
            this.btnDeleteSrv.Name = "btnDeleteSrv";
            this.btnDeleteSrv.Size = new System.Drawing.Size(112, 27);
            this.btnDeleteSrv.TabIndex = 4;
            this.btnDeleteSrv.Text = "Delete Selected";
            this.btnDeleteSrv.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 347);
            this.Controls.Add(this.btnDeleteSrv);
            this.Controls.Add(this.btnAddSvr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntLaunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 386);
            this.MinimumSize = new System.Drawing.Size(503, 386);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoW Realmlist Changer - v1.0.0";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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