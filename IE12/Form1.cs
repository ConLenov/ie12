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

namespace IE12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string myFile = Path.Combine(applicationDirectory, "web/index.html");
            webBrowser1.Url = new Uri(String.Format("file:///" + myFile));
        }
    }
}
