using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontendApp.Classes
{
    public class Dialogs
    {
        public delegate void OnContinue(bool sender);
        public static event OnContinue ContinueOperation;

        /// <summary>
        /// Auto close dialog by specified seconds
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="Icon">icon to present</param>
        /// <param name="seconds">seconds to timeout</param>
        /// <param name="text">What to display</param>
        /// <param name="heading">header text</param>
        public static void AutoCloseDialog(Control owner, Icon Icon, int seconds, string text, string heading = "")
        {

            var remaining = seconds * 10;

            TaskDialogButton continueButton = new("OK");

            TaskDialogPage page = new()
            {
                Heading = heading,
                Text = text,
                Icon = new TaskDialogIcon(Icon),
                Buttons = new TaskDialogButtonCollection() { continueButton },
                Caption = "Auto-close"
            };

            using Timer timer = new()
            {
                Enabled = true,
                Interval = 100
            };

            timer.Tick += (_, _) =>
            {
                remaining -= 1;

                if (remaining != 0) return;
                timer.Enabled = false;
                if (continueButton.BoundPage is not null)
                {
                    continueButton.PerformClick();
                }
            };

            TaskDialogButton result = TaskDialog.ShowDialog(owner, page);

            ContinueOperation?.Invoke(result == continueButton);

        }


    }
}
