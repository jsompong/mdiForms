using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void winAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinApp objWA = new WinApp();
            objWA.MdiParent = this;
            objWA.Show();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo objUI = new UserInfo();
            objUI.MdiParent = this;
            objUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            string input = "STX\"sp\"\nsp,\"ID\",\"+66817558892\",,\"12/06/29,13:04:26+07\"\n13,10,EOS";
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = input;                     // "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                //this.Close();
                var matches = Regex.Matches(
                    input,
                    @"\""(?<msisdn>\+\d*)\"",.*,\""(?<date>\d{2}\/\d{2}/\d{2},\d{2}:\d{2}:\d{2}\+\d{2})\"".*\n+(?<cr>[^,]*),(?<lf>\d*),(?<eos>\w*)"
                    , RegexOptions.Multiline);
                foreach (Match m in matches)
                {
                    //Console.WriteLine(m.Groups["msisdn"].Value);
                    // MessageBox.Show((m.Groups["msisdn"].Value), caption, buttons);
                    //Console.WriteLine(m.Groups["date"].Value);
                   // MessageBox.Show((m.Groups["date"].Value), caption, buttons);
                    //Console.WriteLine(m.Groups["passwd"].Value);
                    MessageBox.Show((m.Groups["cr"].Value), caption, buttons);
                    //Console.WriteLine(m.Groups["itemno"].Value);
                    // MessageBox.Show((m.Groups["lf"].Value), caption, buttons);
                    //Console.WriteLine(m.Groups["command"].Value);
                   // MessageBox.Show((m.Groups["eos"].Value), caption, buttons);
                }
               // Console.ReadKey();
            }
        }
    }
}
