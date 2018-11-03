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
            string path = conduitePath.Text + "\\" + conduitesList.SelectedItem.ToString() + "\\conduite.json";

            try
            {
                List<Record> records = JsonConvert.DeserializeObject<List<Record>>(File.ReadAllText(path));
                Form1 studioForm = new Form1(records);
                studioForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Pas de fichier de conduite valide " + path, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
