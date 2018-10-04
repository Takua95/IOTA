using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class IOTA : Form
    {
        public IOTA()
        {
            InitializeComponent();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<AboutForm>().FirstOrDefault();
            if (form != null)
                form.Activate();
            else
            {
                form = new AboutForm();
                form.Show();
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<HelpForm>().FirstOrDefault();
            if (form != null)
                form.Activate();
            else
            {
                form = new HelpForm();
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<AddForm>().FirstOrDefault();
            if (form != null)
                form.Activate();
            else
            {
                form = new AddForm();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }



    public class itemObj
    {
        string itemName = null;
        string itemDescription = null;
        DateTime itemUseBy;
        DateTime itemDateAdded;
        double itemQuantity = 0.0;
        bool itemTypeCan = false;
        bool itemTypeContainer = false;
        bool itemTypePound = false;


    }
}
