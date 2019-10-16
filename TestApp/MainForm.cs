using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnTest.Click += TestButtonClicked;
        }

        void TestButtonClicked(object sender, EventArgs eventArgs)
        {
            txtTest.TextAlign = HorizontalAlignment.Center;
            txtTest.Text = txtTest.Text == "" ?  "Test" : "";
        }
    }
}
