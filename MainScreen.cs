using static System.Windows.Forms.LinkLabel;
using System.Data;

namespace WoW_Realmlist_Changer
{
    public partial class MainScreen : Form
    {

        string dbfile = @"Servers.cfg";
        string wowPathFile = @"Config.ini";

        public MainScreen()
        {
            InitializeComponent();
            ShowServers();
        }

        private void bntLaunch_Click(object sender, EventArgs e)
        {
            if (!File.Exists(wowPathFile))
            {
                File.Create(wowPathFile).Close();
                SetFolder();
            }
            else
            {
                try
                {
                    string[] wowPathRow = File.ReadAllLines(wowPathFile);
                    string? selServer = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                    using (StreamWriter sw = new StreamWriter(wowPathRow[1]))
                    {
                        sw.WriteLine(selServer);
                    }

                    dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    System.Diagnostics.Process.Start(wowPathRow[0]);

                }
                catch
                {
                    throw;
                }
            }
        }

        private void ShowServers()
        {
            checkIfFileExists(dbfile);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Realmlist", "Realmlist");
            dataGridView1.Columns.Add("About", "About");

            dataGridView1.Columns[1].Visible= false;

            try
            {
                using (StreamReader sr = new StreamReader(dbfile))
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddSvr_Click(object sender, EventArgs e)
        {
            AddServer addSvrWindow = new AddServer();
            addSvrWindow.ShowDialog();

            ShowServers();
        }

        private void RemoveSvr()
        {
            try
            {
                string serverToBeDeleted = dataGridView1.CurrentRow.Cells[0].Value.ToString() + "," + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "," + dataGridView1.CurrentRow.Cells[2].Value.ToString();

                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(dbfile).Where(l => l != serverToBeDeleted);

                File.WriteAllLines(tempFile, linesToKeep);

                File.Delete(dbfile);
                File.Move(tempFile, dbfile);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("You need to select a server to delete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkIfFileExists(string file)
        {
            if (!File.Exists(file))
                File.Create(file).Close();
        }

        private void SetFolder()
        {
            try
            {
                MessageBox.Show(
                    "Please select where your game is installed.", "Important!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button4
                    );

                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "WoW.exe (*.exe)|WoW.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        using (StreamWriter sw = new StreamWriter(wowPathFile))
                        {
                            sw.WriteLine(filePath);

                            string? wowPath = Path.GetDirectoryName(filePath);
                            string realmlistFile = wowPath += "\\addons\\realmlist.wtf";

                            sw.WriteLine(realmlistFile);
                        }

                        MessageBox.Show(
                            "Success! Executing WoW.exe...", "Success!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1
                            );
                    }
                }

                //System.Diagnostics.Process.Start("E:\\Downloads\\World of Warcraft 3.3.5a\\wow.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }  

        private void btnDeleteSrv_Click(object sender, EventArgs e)
        {
            RemoveSvr();
            ShowServers();
        }
    }
}