using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EncDec_UniqueKey;

namespace EncDllconsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtText.Text.Trim()))
                {
                    UniqueKey Ob = new UniqueKey();

                    string Encrypt = Ob.Encrypt(TxtText.Text);
                    TxtText.Text = Encrypt; 
                    MessageBox.Show(Encrypt);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fail: " + Ex.Message);
            }
        }
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtText.Text.Trim()))
                {
                    UniqueKey Ob = new UniqueKey();

                    string Decrypt = Ob.Decrypt(TxtText.Text);
                    TxtText.Text = Decrypt;
                    MessageBox.Show(Decrypt);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fail: " + Ex.Message);
            }
        }

    }
}
