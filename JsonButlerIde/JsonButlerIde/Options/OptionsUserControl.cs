using System;
using System.Windows.Forms;



namespace Andeart.JsonButlerIde.Options
{

    public partial class OptionsUserControl : UserControl
    {
        internal OptionPageGeneral OptionPage { get; set; }

        public OptionsUserControl ()
        {
            InitializeComponent ();
        }

        public void Initialize ()
        {
            CheckBoxConfirmationAlerts.Checked = OptionPage.ShouldShowConfirmationAlerts;
            ComboBoxPropertySerialization.SelectedItem = PropertySerializationTypeConverter.GetString (OptionPage.SerializationType);
        }

        private void CheckBoxConfirmationAlerts_CheckedChanged (object sender, EventArgs e)
        {
            OptionPage.ShouldShowConfirmationAlerts = CheckBoxConfirmationAlerts.Checked;
        }

        private void ComboBoxPropertySerialization_SelectedIndexChanged (object sender, EventArgs e)
        {
            object selectedItem = ComboBoxPropertySerialization.SelectedItem;
            string selectedItemAsString = selectedItem.ToString ();
            OptionPage.SerializationType = PropertySerializationTypeConverter.GetSerializationType (selectedItemAsString);
        }
    }

}