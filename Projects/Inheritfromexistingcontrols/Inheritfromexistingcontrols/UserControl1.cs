using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritfromexistingcontrols
{
    public partial class UserControl1 : Button
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                    return base.Text;
            }
            set
            {
                if (value == "UnwantedName")
                {
                    MessageBox.Show("Unauthorized to use that name.");
                    base.Text = "Usercontrol1";
                    return;
                }
                base.Text = value;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Hello");
            base.OnClick(e); //if this is deleted it wont perform any actions when the button is clicked expect from MessageBox.Show("Hello");
        }
    }
}
