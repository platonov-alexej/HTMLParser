using HTMLParser.Core;
using HTMLParser.Core.Joy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLParser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new JoyParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listResult.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Done!");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new JoySettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
