using static System.Windows.Forms.LinkLabel;
using System.Data;

namespace WoW_Realmlist_Changer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            ShowServers();
        }

        private void bntLaunch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\Downloads\\World of Warcraft 3.3.5a\\wow.exe");
        }

        private void btnAddSvr_Click(object sender, EventArgs e)
        {

            AddServer addSvrWindow = new AddServer();
            addSvrWindow.ShowDialog();
            ShowServers();
        }

        private void ShowServers()
        {
            //1st you must create columns to dgv, like:
            dataGridView1.Columns.Add("Name", "Name1");
            dataGridView1.Columns.Add("About", "About1");
            dataGridView1.Columns.Add("Realmlist", "Realmlist1");
            //and so on...
            using (StreamReader sr = new StreamReader(@"Config.ini"))
            {
                int row = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < columns.Length; i++)
                    {
                        dataGridView1[i, row].Value = columns[i];
                    }
                    row++;
                }
            }
        }
    }
}