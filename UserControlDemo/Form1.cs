using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlDemo.Properties;

namespace UserControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ClickCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<ListItemInstrument> instruments = new List<ListItemInstrument>();

            //ListItemInstrument li1 = new ListItemInstrument();
            //ListItemInstrument li2 = new ListItemInstrument();

            //instruments.Add(li1);
            //instruments.Add(li2);

            //this.pnlInstruments.Controls.Add(li1);
            //this.pnlInstruments.Controls.Add(li2);

            List<string> instruments = new List<string>();
            instruments.Add("electric_guitar");
            instruments.Add("harp");
            instruments.Add("piano");

            pnlInstruments.FlowDirection = FlowDirection.TopDown;

            foreach (string instrument in instruments)
            {
                ListItemInstrument x = new ListItemInstrument();

                x.Title = instrument;
                x.Description = $"The {instrument} is an example of a perfect..";
                x.Image = Properties.Resources.ResourceManager.GetObject(instrument) as Bitmap;

                pnlInstruments.Controls.Add(x);

                x.OnWeirdClick += clickOnButtonInUserControl;
            }
        }
        private void clickOnButtonInUserControl(ListItemInstrument sender, EventArgs e)
        {
            ClickCount++;
            ListItemInstrument instrument = sender;
            MessageBox.Show($"[Form] You clicked on: {instrument.Title}.");
            MessageBox.Show($"[Form] Total clicks: {ClickCount}");
        }
    }
}
