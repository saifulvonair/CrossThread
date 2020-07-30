using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossThread
{
    public partial class FormMain : Form
    {
        Model model = new Model();
        //
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            if(this.btnThread.Text == "Cancel")
            {
                model.Cancel = true;
                this.btnThread.Text = "StartThread";
                return;
            }

           
            model.executeAsync(this.txtStatus.Text, delegate (object p)
            {
                string s = (string)p;
                uodateStatus(s);
            });

            this.btnThread.Text = "Cancel";
        }

        //
        protected void uodateStatus(String message)
        {
            if (this.txtStatus.InvokeRequired)
            {
                this.txtStatus.BeginInvoke((MethodInvoker)delegate
                {
                    this.txtStatus.Text = message;
                    return;
                });
            }
            else
            {
                this.txtStatus.Text = message;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Cancel = true;
        }
    }
}
