using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CegalaStudio.Model;
using System.IO;
using WMPLib;

namespace CegalaStudio
{
    public partial class SelectConduite : Form
    {
        public SelectConduite()
        {
            InitializeComponent();
            loadConduite.Enabled = false;
        }

        private void loadConduite_Click(object sender, EventArgs e)
        {
            string rootPath = conduitePath.Text + "\\" + conduitesList.SelectedItem.ToString();

            try
            {
                List<Record> records = JsonConvert.DeserializeObject<List<Record>>(File.ReadAllText(rootPath + "\\conduite.json"));

                foreach (Record record in records)
                {
                    string musicPath = rootPath + "\\" + record.Musique;
                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                    IWMPMedia mediaInformation = wmp.newMedia(musicPath);
                    record.Duree = mediaInformation.duration;
                }
                Form1 studioForm = new Form1(rootPath, records);
                studioForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Pas de fichier de conduite valide " + rootPath, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void conduitePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadConduitesButton_Click(object sender, EventArgs e)
        {
            loadConduiteList(conduitePath.Text);
        }

        private void loadConduiteList(string conduitePath)
        {
            string[] conduiteFolders = Directory.GetDirectories(conduitePath);

            if (conduiteFolders.Length > 0)
            {
                conduitesList.Items.Clear();
                foreach (string conduiteFolder in conduiteFolders)
                {
                    conduitesList.Items.Add(Path.GetFileName(conduiteFolder));
                }
                conduitesList.SelectedIndex = 0;
                loadConduite.Enabled = true;
            }
        }
    }
}
