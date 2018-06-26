using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web.Script.Serialization;

namespace list_dir
{
    public partial class Form1 : Form
    {

        public FolderData root { set; get; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private FolderData set_json(string folder_path)
        {
            var folder_name = Path.GetFileName(folder_path);
            var folder_data = new FolderData(folder_name);
            folder_data.files = Directory.GetFiles(folder_path).Select(o => Path.GetFileName(o)).ToList();

            string[] folders = Directory.GetDirectories(folder_path);
            foreach (var folder in folders)
            {
               folder_data.folders.Add(set_json(folder));
            }
            return folder_data;
        }

        private void save_to_file(string json, string file_name, string file_path)
        {
            TextWriter writer;
            var save_full_name = string.Format(@"{0}\{1}.txt", file_path, file_name);
            try
            {
                using (writer = new StreamWriter(save_full_name, append: false))
                {
                    writer.WriteLine(json);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(string.Format("you dont have permission to write to {0}", file_path));
                throw new Exception();
            }         
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var save_file_name = this.textBox1.Text;
            if (string.IsNullOrEmpty(save_file_name)){
                System.Windows.Forms.MessageBox.Show("please pick a name for your file");
                return;
            }
            var save_file_path = this.textBox2.Text;
            if (string.IsNullOrEmpty(save_file_path))
            {
                System.Windows.Forms.MessageBox.Show("please pick a directory to save the file in");
                return;
            }

            Stream myStream = null;
            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();

            DialogResult result = openFolderDialog1.ShowDialog();

             if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog1.SelectedPath))
             {
                 root = set_json(openFolderDialog1.SelectedPath);
                 Console.Write(root);
                 var jsonSerialiser = new JavaScriptSerializer();
                 try {
                     var json = jsonSerialiser.Serialize(root);
                     var json_pretty = JSON_PrettyPrinter.Process(json);
                     try
                     {
                        save_to_file(json_pretty, save_file_name, save_file_path);
                        System.Windows.Forms.MessageBox.Show(
                        string.Format("Save Successfully!,\n preview '{0}'....",
                        json_pretty.Substring(0, (int)(json_pretty.Length * 0.02))));
                     }
                     catch
                     {
                         System.Windows.Forms.MessageBox.Show("failed to save file");
                     }
                 }
                 catch
                 {
                     System.Windows.Forms.MessageBox.Show("overflow json format: use a smaller directory");
                 }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();

                DialogResult result = openFolderDialog1.ShowDialog();

                 if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog1.SelectedPath))
                 {
                    this.textBox2.Text =  openFolderDialog1.SelectedPath;
                 }
            }
        }

    }
