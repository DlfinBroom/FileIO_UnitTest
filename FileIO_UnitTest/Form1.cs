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
        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            string data = tbxUserInput.Text;

            byte[] b = Encoding.ASCII.GetBytes(data);
            string newData = "";
            foreach ( byte bElem in b)
            {
                if ( newData.Equals(""))
                {
                    newData += Convert.ToString(bElem);
                }
                else
                {
                    newData += " " + Convert.ToString(bElem);
                }
            }
            tbxUserInput.Text = newData;
        }
    }
}
