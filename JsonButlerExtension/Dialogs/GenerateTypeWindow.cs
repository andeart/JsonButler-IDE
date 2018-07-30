using System;
using System.Drawing;
using System.Windows.Forms;



namespace Andeart.JsonButlerIde.Dialogs
{

    public partial class GenerateTypeWindow : Form
    {
        public string TypeNamespace { get; private set; }
        public string TypeName { get; private set; }

        public GenerateTypeWindow ()
        {
            InitializeComponent ();
        }

        private void ButtonGenerate_Click (object sender, EventArgs e)
        {
            TypeNamespace = textNamespace.Text;
            TypeName = textName.Text;
            DialogResult = DialogResult.OK;
            Close ();
        }

        private void TextNamespace_GotFocus (object sender, EventArgs e)
        {
            textNamespace.Text = string.Empty;
            textNamespace.ForeColor = SystemColors.WindowText;
        }

        private void TextName_GotFocus (object sender, EventArgs e)
        {
            textName.Text = string.Empty;
            textName.ForeColor = SystemColors.WindowText;
        }
    }

}