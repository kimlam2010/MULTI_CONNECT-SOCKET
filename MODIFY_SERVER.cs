using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MODIFY_SERVER : Form
    {
        public event EventHandler Event;

        public MODIFY_SERVER()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Status_form(object sender, EventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
