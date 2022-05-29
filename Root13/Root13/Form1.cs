using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root13
{
    public partial class Form1 : Form
    {
        public char[] arrayRoot = {' ','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
        public char [] arrayRootOne={' ','N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public String stringText;
        public String stringEncrypting;
        public char[] arrayStringText;
        public char[] arrayEncrypting;
        public char[] arrayTextDesencrypting;
        public char[] arrayDesencrypting;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypting_Click(object sender, EventArgs e)
        {
            encrypting();
            textEncrypting();
        }

        public void encrypting()
        {
            stringText = txtB_String.Text.ToUpper();
            arrayStringText = stringText.ToArray();
            arrayEncrypting = new char[arrayStringText.Length];
            for (int j = 0; j < arrayStringText.Length; j++)
            {
                for (int i = 0; i < arrayRoot.Length; i++)
                {
                    if (arrayStringText[j]==arrayRoot[i])
                    {
                        arrayEncrypting[j] = arrayRootOne[i];
                    }else if (arrayStringText[j] == arrayRootOne[i])
                    {
                        arrayEncrypting[j] = arrayRoot[i];
                    }
                } 
            }
        }

        public void textEncrypting()
        {
            txtB_TextEngrypting.Text = "";
            for (int i = 0; i < arrayEncrypting.Length; i++)
            {
                txtB_TextEngrypting.Text += arrayEncrypting[i];
            }
        }

        private void btn_Desencrypting_Click(object sender, EventArgs e)
        {
            desencrypting();
            textDesencrypting();

        }

        public void desencrypting()
        {
            stringEncrypting = txtB_StringEncrypting.Text.ToUpper();
            arrayTextDesencrypting = stringEncrypting.ToCharArray();
            arrayDesencrypting = new char[arrayTextDesencrypting.Length];
            for (int j = 0; j < arrayTextDesencrypting.Length; j++)
            {
                for (int i = 0; i < arrayRoot.Length; i++)
                {
                    if (arrayTextDesencrypting[j] == arrayRoot[i])
                    {
                        arrayDesencrypting[j] = arrayRootOne[i];
                    }
                    else if (arrayTextDesencrypting[j] == arrayRootOne[i])
                    {
                        arrayDesencrypting[j] = arrayRoot[i];
                    }
                }
            }
        }
        public void textDesencrypting()
        {
            txtB_TextDesencrypting.Text = "";
            for (int i = 0; i < arrayDesencrypting.Length; i++)
            {
                txtB_TextDesencrypting.Text += arrayDesencrypting[i];
            }
        }
    }
}
