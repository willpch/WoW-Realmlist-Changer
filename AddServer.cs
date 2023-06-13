using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW_Realmlist_Changer
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }

        string dbFile = @"Servers.cfg";

        private void btnAddSvr_Click(object sender, EventArgs e)
        {
            string[] data = new string[3];
            data[0] = txtSvrName.Text;
            data[1] = txtRealmlist.Text;
            data[2] = txtAbout.Text;

            try
            {
                StreamReader sr = new StreamReader(dbFile);

                string oldData = sr.ReadToEnd();
                sr.Close();

                StreamWriter sw = new StreamWriter(dbFile);

                sw.WriteLine(data[0] + "," + data[1] + "," + data[2]);
                sw.WriteAsync(oldData);
                sw.Close();
                this.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
