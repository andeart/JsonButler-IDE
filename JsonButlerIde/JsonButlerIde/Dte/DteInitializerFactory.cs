using System;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;



namespace Andeart.JsonButlerIde.Dte
{

    internal class DteInitializerFactory
    {
        private static Action<DTE2> _onDteInitialized;

        private static Package _package;

        private static IServiceProvider ServiceProvider => _package;

        public static void Initialize (Package package, Action<DTE2> onDteInitialized)
        {
            _package = package ?? throw new ArgumentNullException (nameof(package));
            _onDteInitialized = onDteInitialized;
            Initialize ();
        }

        private static void Initialize ()
        {
            DTE2 dte = ServiceProvider.GetService (typeof(SDTE)) as DTE2;
            _onDteInitialized?.Invoke (dte);

            if (dte != null)
            {
                return;
            }

            IVsShell shellService = ServiceProvider.GetService (typeof(SVsShell)) as IVsShell;
            new DteInitializer (shellService, Initialize);
        }
    }

}