using System.Net;

namespace Pulsive_Crack
{
    public partial class Pulsive_Patcher : Form
    {
        public Pulsive_Patcher()
        {
            InitializeComponent();
        }
        string Path = string.Empty;            
                                
        private void Patch_BTN_Click(object sender, EventArgs e)
        {
            File.Delete(Path);
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1002667118094975026/1003035868711362710/Pulsive.exe", Path);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lol:

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog.SafeFileName != "Pulsive.exe")
                {
                    MessageBox.Show("You didnt select Pulsive idiot");
                    goto lol;
                }

                Path = openFileDialog.FileName;
                Patch_BTN.Enabled = true;

            }
        }

        private void Pulsive_Patcher_Load(object sender, EventArgs e)
        {

        }
    }
}