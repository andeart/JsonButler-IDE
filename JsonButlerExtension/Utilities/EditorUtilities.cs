using System;
using EnvDTE;
using Microsoft.VisualStudio.TextManager.Interop;



namespace Andeart.JsonButlerIde.Utilities
{

    internal static class EditorUtilities
    {
        /// <summary>
        /// Gets the code element at the point of the text-selection.
        /// </summary>
        /// <param name="textSelection">The text-selection.</param>
        public static CodeElement GetCodeElement (TextSelection textSelection)
        {
            CodeElement codeElement = textSelection?.ActivePoint.CodeElement[vsCMElement.vsCMElementClass];
            if (codeElement != null)
            {
                return codeElement;
            }

            codeElement = textSelection?.ActivePoint.CodeElement[vsCMElement.vsCMElementStruct];
            return codeElement;
        }

        public static string GetHighlightedText (IVsTextManager2 textManager)
        {
            if (textManager == null)
            {
                throw new Exception ("Could not locate the TextManager service.");
            }

            textManager.GetActiveView2 (1, null, (uint) _VIEWFRAMETYPE.vftCodeWindow, out IVsTextView view);

            view.GetSelectedText (out string selectedText);

            return selectedText;
        }
    }

}