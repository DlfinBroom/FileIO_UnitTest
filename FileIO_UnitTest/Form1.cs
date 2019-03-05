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

namespace FileIO_UnitTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaveData_Click(object sender, EventArgs e) {
            string text = tbxUserInput.Text;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Contents|*.txt";
            dialog.FileName = "Test";

            if(dialog.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(dialog.FileName, text);
                MessageBox.Show("Data was saved");
            }
        }
    }
}
