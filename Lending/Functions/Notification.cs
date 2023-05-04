using System.Windows.Forms;

namespace Lending.Functions
{
    public static class Notification
    {
        public static void Invalid(string message)
        {
            MessageBox.Show(message, " Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Error(string message)
        {
            MessageBox.Show(message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Success(string message)
        {
            MessageBox.Show(message, " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
