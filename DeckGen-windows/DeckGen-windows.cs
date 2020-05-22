using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckGen_windows
{
    public partial class formDeckGenWindows : Form
    {
        public formDeckGenWindows()
        {
            this.InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            bgWorker.RunWorkerAsync();
        }

        private void Dg_OnConsoleWrite(object sender, string e)
        {
            status.Text = e;
        }

        private void formDeckGenWindows_Load(object sender, EventArgs e)
        {
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DeckGen dg = new DeckGen();
            dg.OnConsoleWrite += this.Dg_OnConsoleWrite;
            dg.Gen(new string[] {
                txtCdb.Text,
                txtLfList.Text,
                numMain.Value.ToString(),
                numEx.Value.ToString(),
                numYdkMain.Value.ToString(),
                numYdkEx.Value.ToString(),
                numYdkNum.Value.ToString()
            });
        }

        private void Global_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Global_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                ((TextBox)sender).Text = files[0];
            }
            catch { }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
        }
    }
}
