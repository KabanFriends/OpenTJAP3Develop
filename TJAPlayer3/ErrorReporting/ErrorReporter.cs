using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;

namespace TJAPlayer3.ErrorReporting
{
    public static class ErrorReporter
    {
        private const string EnvironmentAlpha = "alpha";
        private const string EnvironmentBeta = "beta";
        private const string EnvironmentDevelopment = "development";
        private const string EnvironmentProduction = "production";

        public const string GetCurrentSkinNameOrNullFallbackForNullSkin = "[GetCurrentSkinNameOrNull null skin]";
        public const string GetCurrentSkinNameOrNullFallbackForExceptionEncountered = "[GetCurrentSkinNameOrNull exception encountered]";

        public static void WithErrorReporting(Action action)
        {
            var appInformationalVersion = TJAPlayer3.AppInformationalVersion;

                try
                {
                    action();
                }
                catch (Exception e)
                {
                    NotifyUserOfError(e);
                }
        }

        private static void ReportError(Exception e)
        {
            Trace.WriteLine("");
            Trace.WriteLine(e);
            Trace.WriteLine("");
            Trace.WriteLine("エラーだゴメン！（涙");
        }

        private static string GetCurrentSkinNameOrNull()
        {
            try
            {
                var skin = TJAPlayer3.Skin;
                if (skin == null)
                {
                    return GetCurrentSkinNameOrNullFallbackForNullSkin;
                }

                return skin.GetCurrentSkinName();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unexpected exception encountered when attempting to get the current skin name: " + e);

                return GetCurrentSkinNameOrNullFallbackForExceptionEncountered;
            }
        }

        private static void NotifyUserOfError(Exception exception)
        {
            var messageBoxText =
                "An error has occurred and was automatically reported.\n\n" +
                "If you wish, you can provide additional information, look for similar issues, etc. by visiting our GitHub Issues page.\n\n" +
                "Would you like the error details copied to the clipboard and your browser opened?\n\n" +
                exception;
            var dialogResult = MessageBox.Show(
                messageBoxText,
                $"{TJAPlayer3.AppDisplayNameWithThreePartVersion} Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}