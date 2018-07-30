using System;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;



namespace Andeart.JsonButlerIde.Dte
{

    internal class DteInitializer : IVsShellPropertyEvents
    {
        private readonly IVsShell _shellService;
        private uint _cookie;
        private readonly Action _callback;

        public DteInitializer (IVsShell shellService, Action callback)
        {
            _shellService = shellService;
            _callback = callback;

            // Set an event handler to detect when the IDE is fully initialized
            int handlerResult = _shellService.AdviseShellPropertyChanges (this, out _cookie);

            ErrorHandler.ThrowOnFailure (handlerResult);
        }

        int IVsShellPropertyEvents.OnShellPropertyChange (int propid, object var)
        {
            if (propid != (int) __VSSPROPID.VSSPROPID_Zombie)
            {
                return VSConstants.S_OK;
            }

            bool isZombie = (bool) var;

            if (isZombie)
            {
                return VSConstants.S_OK;
            }

            // Release the event handler to detect when the IDE is fully initialized
            int handlerResult = _shellService.UnadviseShellPropertyChanges (_cookie);

            ErrorHandler.ThrowOnFailure (handlerResult);

            _cookie = 0;
            _callback.Invoke ();

            return VSConstants.S_OK;
        }
    }

}