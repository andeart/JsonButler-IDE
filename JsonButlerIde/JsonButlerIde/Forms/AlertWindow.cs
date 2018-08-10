using System;
using System.Windows.Forms;



namespace Andeart.JsonButlerIde.Forms
{

    public partial class AlertWindow : Form
    {
        public AlertWindow ()
        {
            InitializeComponent ();
        }

        private void ButtonOk_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close ();
        }

        public void ShowDialogWithMessage (string message)
        {
            labelMessage.Text = message;
            ShowDialog ();
        }
    }

}