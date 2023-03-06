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

        private void btnAddSvr_Click(object sender, EventArgs e)
        {
            string[] data = new string[3];
            data[0] = txtSvrName.Text;
            data[1] = txtRealmlist.Text;
            data[2] = txtAbout.Text;

            StreamReader sr = new StreamReader(@"Config.ini");

            string oldData = sr.ReadLine();
            sr.Close();

            StreamWriter sw = new StreamWriter(@"Config.ini");

            sw.WriteLine(data[0] + "," + data[1] + "," + data[2] + Environment.NewLine + oldData);
            sw.Close();
            this.Close();
        }
    }
}
