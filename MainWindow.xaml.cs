using System.Windows;

namespace Uplift
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Opens application
            // Set up message box
            string messageBoxText = "Have a great day!";
            string caption = "Message";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.None;
            MessageBoxResult result;

            // Shows message box
            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            switch (result)
            {
                // When OK is pressed
                case MessageBoxResult.OK:
                    //close application
                    Close();
                    break;
            }
        }
    }
}
