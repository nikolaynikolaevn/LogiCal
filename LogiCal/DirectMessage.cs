using System.Windows.Forms;

namespace LogiCal
{
    public static class DirectMessage
    {
        public static void ShowError(string message)
        {
            string caption = "Error";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            DialogResult result = MessageBox.Show(message, caption, button, icon);
        }
        public static void ShowInfo(string message)
        {
            string caption = "Info";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            DialogResult result = MessageBox.Show(message, caption, button, icon);
        }
        public static void ShowWarning(string message)
        {
            string caption = "Warning";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, caption, button, icon);
        }
    }
}
