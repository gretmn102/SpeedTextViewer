using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Core.Prog p = new Core.Prog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (p.Next() == true) { label1.Text = p.Current; } else label1.Text = "end";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (p.Prev() == true) { label1.Text = p.Current; } else label1.Text = "end";
        }

        void Print(string str)
        {
            if (this.InvokeRequired)
            {
                Core.D d = new Core.D(Print);
                this.Invoke(d, str);
            }
            else
                label1.Text = str;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //let rec print s = 
            //    if this.InvokeRequired then
            //        let d = SetTextCallback print
            //        this.Invoke(d, [| box s |]) |> ignore
            //    else 
            //        this.textBox2.AppendText (s + Environment.NewLine)
            
            //Core.D d = new Core.D(x => label1.Text = x );
            Core.D d = new Core.D(Print);
            p.AutoStart(d);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (p.Auto)
                p.AutoStop();
            else
                MessageBox.Show("not started");
        }
    }
}
