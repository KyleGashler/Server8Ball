using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client8Ball
{
    public partial class Form1 : Form
    {
        //initialize sync client
        SynchronousSocketClient synchronousSocketClient;
        public Form1()
        {
            InitializeComponent();
            //initialize an instance
            synchronousSocketClient = new SynchronousSocketClient();
        }

        /// <summary>
        /// button for get answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShake8_Click(object sender, EventArgs e)
        {
            //response load and reception to GUI
            txtboxResponse.Text = synchronousSocketClient.ContactServer(txtBoxQuestion.Text);
        }
    }
}
