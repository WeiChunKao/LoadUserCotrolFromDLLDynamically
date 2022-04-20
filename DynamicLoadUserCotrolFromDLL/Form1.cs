using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlDLL;

namespace DynamicLoadUserCotrolFromDLL
{
    public partial class Form1 : Form
    {
        public UC1 uC = new UC1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC.OnError += HandleError;
            uC.OnLog += HandleLog;
            this.panel1.Controls.Add(uC);
        }
        private void HandleError(Exception e)
        {
            MessageBox.Show(e.Message);
        }

        private void HandleLog(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
