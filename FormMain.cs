using Svg;
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

namespace svg2icons
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += @" V" + System.Windows.Forms.Application.ProductVersion.ToString();
            InitCheckedList(CheckedListBoxDPI);
        }

        private void InitCheckedList(CheckedListBox checkedList)
        {
            int[] dpis = new int[] { 12, 16, 24, 32, 48, 64, 72, 96, 128, 192, 256, 512 };
            List<int> selectDpis = new List<int>(new int[] { 16, 32, 48, 64, 128, 256 });
            checkedList.Items.Clear();
            checkedList.CheckOnClick = true;
            checkedList.MultiColumn = true;
            checkedList.ColumnWidth = 100;
            foreach (int dpi in dpis)
            {
                checkedList.Items.Add(dpi.ToString() + "x" + dpi.ToString(), selectDpis.Contains(dpi));
            }
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SVG文件(*.svg)|*.svg";
            openFileDialog.Title = "选择SVG文件";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxInput.Text = openFileDialog.FileName;
            }
        }

        private int[] GetSelectDpi(CheckedListBox checkedList)
        {
            List<int> dpis = new List<int>();
            for (int i = 0; i < checkedList.CheckedItems.Count; i++)
            {
                string name = checkedList.CheckedItems[i].ToString().Trim();
                dpis.Add(Convert.ToInt32(name.Split('x')[0]));
            }
            return dpis.ToArray();
        }

        private void ButtonOutput_Click(object sender, EventArgs e)
        {
            GetSelectDpi(CheckedListBoxDPI);
            string inputPath = TextBoxInput.Text.Trim();
            if (File.Exists(inputPath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "保存ICO文件";
                saveFileDialog.Filter = "图标文件(*.ico)|*.ico";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string outputPath = saveFileDialog.FileName;
                        if (File.Exists(outputPath))
                        {
                            File.Delete(outputPath);
                        }
                        SvgDocument svg = SvgDocument.Open(inputPath);
                        IconFile file = new IconFile();
                        foreach (int dpi in GetSelectDpi(CheckedListBoxDPI))
                        {
                            file.AddImage(svg, dpi);
                        }
                        file.Save(outputPath);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
    }
}
