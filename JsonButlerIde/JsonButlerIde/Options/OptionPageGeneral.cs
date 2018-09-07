using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;



namespace Andeart.JsonButlerIde.Options
{

    [Guid ("FDD2B9FD-D15E-4D78-9ACA-199F805F4AE8")]
    internal class OptionPageGeneral : DialogPage
    {
        private bool _shouldShowConfirmationAlerts;

        private PropertySerializationType _serializationType;

        public bool ShouldShowConfirmationAlerts
        {
            get => _shouldShowConfirmationAlerts;
            set => _shouldShowConfirmationAlerts = value;
        }

        public PropertySerializationType SerializationType
        {
            get => _serializationType;
            set => _serializationType = value;
        }

        protected override IWin32Window Window
        {
            get
            {
                OptionsUserControl page = new OptionsUserControl ();
                page.OptionPage = this;
                page.Initialize ();
                return page;
            }
        }
    }

}