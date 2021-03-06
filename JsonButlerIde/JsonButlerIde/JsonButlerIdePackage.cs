﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using Andeart.JsonButlerIde.Commands;
using Andeart.JsonButlerIde.Dte;
using Andeart.JsonButlerIde.Forms;
using Andeart.JsonButlerIde.Options;
using EnvDTE80;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;



namespace Andeart.JsonButlerIde
{

    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    [PackageRegistration (UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration ("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [Guid (PackageGuidString)]
    [SuppressMessage ("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideAutoLoad (VSConstants.UICONTEXT.NoSolution_string)]
    [ProvideAutoLoad (VSConstants.UICONTEXT.SolutionExists_string)]
    [ProvideMenuResource ("Menus.ctmenu", 1)]
    [ProvideOptionPage (typeof(OptionPageGeneral), "JsonButler", "General", 0, 0, true)]
    public sealed class JsonButlerIdePackage : AsyncPackage
    {
        /// <summary>
        /// JsonButlerIdePackage GUID string.
        /// </summary>
        public const string PackageGuidString = "e4969f46-af48-4106-a5ce-8660e39251d1";

        private OptionPageGeneral _optionPage;
        private IVsStatusbar _statusBar;

        internal PropertySerializationType SerializationType => _optionPage.SerializationType;
        internal DTE2 Dte { get; private set; }


        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to monitor for initialization cancellation, which can occur when VS is shutting down.</param>
        /// <param name="progress">A provider for progress updates.</param>
        /// <returns>A task representing the async work of package initialization, or an already completed task if there is none. Do not return null from this method.</returns>
        protected override async Task InitializeAsync (CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            // When initialized asynchronously, the current thread may be a background thread at this point.
            // Do any initialization that requires the UI thread after switching to the UI thread.
            await JoinableTaskFactory.SwitchToMainThreadAsync (cancellationToken);
            DteInitializerFactory.Initialize (this, OnDteInitialized);

            _optionPage = (OptionPageGeneral) GetDialogPage (typeof(OptionPageGeneral));

            SerializeTypeCommand.Initialize (this);
            GenerateTypeCommand.Initialize (this);

            ConvertCamelCaseCommand.Initialize (this);
            ConvertLowerSnakeCaseCommand.Initialize (this);
            ConvertPascalCaseCommand.Initialize (this);
            ConvertUnderscoreCamelCaseCommand.Initialize (this);
        }

        private void OnDteInitialized (DTE2 dte)
        {
            Dte = dte;
        }

        public void DoAlert (string alertMessage)
        {
            _statusBar = _statusBar ?? (_statusBar = GetService (typeof(SVsStatusbar)) as IVsStatusbar);
            if (_statusBar != null)
            {
                _statusBar.IsFrozen (out int frozen);
                if (frozen == 0)
                {
                    _statusBar.SetText ($"JsonButler: {alertMessage}");
                }
            }

            if (_optionPage.ShouldShowConfirmationAlerts)
            {
                AlertWindow alertWindow = new AlertWindow ();
                alertWindow.ShowDialogWithMessage (alertMessage);
            }
        }

        #endregion
    }

}