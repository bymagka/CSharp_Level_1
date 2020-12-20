using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework_Lesson8_Task6_TininA
{
    public partial class Form1 : Form, IView
    {

        public string XMLFilename { get => tbXML.Text; }
        public string CSVFilename { get => tbCSV.Text; }

        Adapter adapter;

        public Form1()
        {
            InitializeComponent();
            adapter = new Adapter(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adapter.ToXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter.ToCSV();
        }

        private void btnChoseXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog
            {
                CheckFileExists = false,
                Filter = "xml files (*.xml)|*.xml"
            };
  

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tbXML.Text = sfd.FileName;
            }
        }

        private void btnChoseCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog
            {
                CheckFileExists = false,
                Filter = "csv files (*.csv)|*.csv"
            };


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tbCSV.Text = sfd.FileName;
            }
        }
    }
}
