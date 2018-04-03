using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib1;
using NodaTime;
using NodaTime.Text;

namespace DotNetCoreExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.BackColor == Control.DefaultBackColor)
                this.button1.BackColor = ColorManager.SpecialColor;
            else
                this.button1.BackColor = Control.DefaultBackColor;
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            var redval = this.button1.BackColor.R;
            var blueval = this.button1.BackColor.B;
            var sumval = Adder.Add(redval, blueval);
            this.label1.Text = $"{redval} + {blueval} = {sumval}";

            var now = SystemClock.Instance.GetCurrentInstant();
            var now_local = now.InZone(DateTimeZoneProviders.Tzdb.GetSystemDefault());
            this.label2.Text = $"{now_local}";
        }
    }
}
