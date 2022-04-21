using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDLL
{
    public partial class UC1 : UserControl,IUserControl
    {
        public event Action<Exception> OnError;
        public event Action<string> OnLog;
        public UC1()
        {
            InitializeComponent();
        }
        private void UC1_Load(object sender, EventArgs e)
        {
            try
            {
                int a = 11;
                int b = 1;
                int c = a / b;
                OnLog?.Invoke("test");
            }catch(Exception ex)
            {
                OnError?.Invoke(ex);
            }
        }
    }
}
