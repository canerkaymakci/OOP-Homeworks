using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Work_2._2
{
    public partial class ReadLogs : UserControl
    {
        public static RichTextBox rtbLog;
        public ReadLogs()
        {
            InitializeComponent();

            rtbLog = rtbMatrix;
        }
    }
}
