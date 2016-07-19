using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anime_name_fetcher
{
    public partial class edit_input : Form
    {
        public edit_input()
        {
            InitializeComponent();
        }

        private void edit_input_Load(object sender, EventArgs e)
        {
            txt_txt.Text = main.edit_txt;
        }

        private void txt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                main.edit_txt = txt_txt.Text;
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
