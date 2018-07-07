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
using System.Runtime.InteropServices;

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


        public void CreateExcel(string save_dir, FolderData folder_data)
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            object misValue = System.Reflection.Missing.Value;
            var xlWorkBook = xlApp.Workbooks.Add(misValue);
            var xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            string file_content = folder_data.ConvertToSTR();
            string[] lines = file_content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            var i = 1;
            foreach (var line in lines)
            {
                xlWorkSheet.Cells[i, 1] = line;
                i++;
            }

            xlWorkBook.SaveAs(save_dir,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                misValue, misValue, misValue, misValue,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show(string.Format("Excel file created , you can find the file {0}", save_dir));
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var save_file_name = this.textBox1.Text;
            if (string.IsNullOrEmpty(save_file_name))
            {
                System.Windows.Forms.MessageBox.Show("please pick a name for your file");
                return;
            }
            var save_file_path = this.textBox2.Text;
            if (string.IsNullOrEmpty(save_file_path))
            {
                System.Windows.Forms.MessageBox.Show("please pick a directory to save the file in");
                return;
            }

            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();

            DialogResult result = openFolderDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog1.SelectedPath))
            {
                root = set_json(openFolderDialog1.SelectedPath);
                Console.Write(root);
                var save_full_name = string.Format(@"{0}\{1}.xls", save_file_path, save_file_name);
                CreateExcel(save_full_name, root);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();

            DialogResult result = openFolderDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog1.SelectedPath))
            {
                this.textBox2.Text = openFolderDialog1.SelectedPath;
            }
        }
    }
}
