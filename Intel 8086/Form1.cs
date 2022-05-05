using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MOVEAXBX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxBX.Text;
        }
        private void MOVEAXCX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text= textBoxCX.Text;
        }

        private void MOVEAXDX_Click(object sender, EventArgs e)
        {
            textBoxAX.Text = textBoxDX.Text;
        }

        private void MOVEBXAX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxAX.Text;
        }

        private void MOVEBXCX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxCX.Text;
        }

        private void MOVEBXDX_Click(object sender, EventArgs e)
        {
            textBoxBX.Text = textBoxDX.Text;
        }

        private void MOVECXAX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxAX.Text;
        }

        private void MOVECXBX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxBX.Text;
        }

        private void MOVECXDX_Click(object sender, EventArgs e)
        {
            textBoxCX.Text = textBoxDX.Text;
        }

        private void MOVEDXAX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxAX.Text;
        }

        private void MOVEDXBX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxBX.Text;
        }

        private void MOVEDXCX_Click(object sender, EventArgs e)
        {
            textBoxDX.Text = textBoxCX.Text;
        }

        private void textBoxAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f'))) 
            {
                e.Handled = true;
            }
        }

        private void textBoxBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
            {
                e.Handled = true;
            }

        }

        private void textBoxCX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
            {
                e.Handled = true;
            }

        }

        private void textBoxDX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
            {
                e.Handled = true;
            }
        }

        private void XCHGAXBX_Click(object sender, EventArgs e)
        {
            string i = textBoxAX.Text;
            textBoxAX.Text =textBoxBX.Text;
            textBoxBX.Text = i;
        }

        private void XCHGAXCX_Click(object sender, EventArgs e)
        {
            string i = textBoxAX.Text;
            textBoxAX.Text = textBoxCX.Text;
            textBoxCX.Text = i;
        }

        private void XCHGAXDX_Click(object sender, EventArgs e)
        {
            string i = textBoxAX.Text;
            textBoxAX.Text = textBoxDX.Text;
            textBoxDX.Text = i;
        }

        private void XCHGBXCX_Click(object sender, EventArgs e)
        {
            string i = textBoxBX.Text;
            textBoxBX.Text = textBoxCX.Text;
            textBoxCX.Text = i;
        }

        private void XCHGBXDX_Click(object sender, EventArgs e)
        {
            string i = textBoxBX.Text;
            textBoxBX.Text = textBoxDX.Text;
            textBoxDX.Text = i;
        }

        private void XCHGCXDX_Click(object sender, EventArgs e)
        {
            string i = textBoxCX.Text;
            textBoxCX.Text = textBoxDX.Text;
            textBoxDX.Text = i;
        }
    }
}
