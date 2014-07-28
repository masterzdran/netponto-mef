using System.Windows;
using Television.Contracts;
using Television.Model;

namespace PirateTV
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myTVOperations = new TVOperations();
        }

        #region Application Pirate TV
        private ITVOperations myTVOperations;
        private void TVChannelUp_Click(object sender, RoutedEventArgs e)
        {
            IPirateChannel c = myTVOperations.ChannelUp();
            //TODO: Imagebrush
            TVScreen.Fill = c.Channel;
            TVChannelName.Text = c.Logo;
        }
        private void TVChannelDown_Click(object sender, RoutedEventArgs e)
        {
            IPirateChannel c = myTVOperations.ChannelDown();
            TVScreen.Fill = c.Channel;
            TVChannelName.Text = c.Logo;
        }
        #endregion
    }
}
