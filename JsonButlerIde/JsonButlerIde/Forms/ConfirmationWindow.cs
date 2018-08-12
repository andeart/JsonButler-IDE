using System;
using System.Windows.Forms;



namespace Andeart.JsonButlerIde.Forms
{

    public partial class ConfirmationWindow : Form
    {
        public ConfirmationWindow ()
        {
            InitializeComponent ();
        }

        private void ButtonOk_Click (object sender, EventArgs args)
        {
            DialogResult = DialogResult.OK;
            Close ();
        }

        private void ButtonCancel_Click (object sender, EventArgs args)
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        public DialogResult ShowDialogWithMessage (string message)
        {
            labelMessage.Text = message;
            return ShowDialog ();
        }
    }

}