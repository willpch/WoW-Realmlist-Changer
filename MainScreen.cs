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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Realmlist", "Realmlist");
            dataGridView1.Columns.Add("About", "About");

            dataGridView1.Columns[2].Visible= false;

            using (StreamReader sr = new StreamReader(@"Config.ini"))
            {
                int row = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add();
                    string[] columns = line.Split(',');
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