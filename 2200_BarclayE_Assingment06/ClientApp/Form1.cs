using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        SynchronousSocketClient client = new SynchronousSocketClient();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible)
            {
                textBox2.ScrollToCaret();
            }
            textBox2.AppendText(client.ContactServer(textBox1.Text));
            textBox2.AppendText(Environment.NewLine);
            textBox2.AppendText(Environment.NewLine);
        }
    }
}
