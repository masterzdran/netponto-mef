using PirateTv_01.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PirateTv_01
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();



        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion



        #region Application Pirate TV 
        private int channel = 0;

        BitmapImage[] colors = new BitmapImage[]{
            null,
            new BitmapImage(new Uri("ms-appx:/Images/nbc.png", UriKind.Absolute)),
            new BitmapImage(new Uri("ms-appx:/Images/Fox-Sports.jpg", UriKind.Absolute)),
            new BitmapImage(new Uri("ms-appx:/Images/fox-business-logo.jpg", UriKind.Absolute)),
            new BitmapImage(new Uri("ms-appx:/Images/Discovery.jpg", UriKind.Absolute)),
            new BitmapImage(new Uri("ms-appx:/Images/Cartoon_Network_2010_Logo.png", UriKind.Absolute))
        };
  
                
        
        String[] channels = new String[]{
            "",
            "Beca",
            "YMCA",
            "Zumba",
            "MS",
            "XXPT"
        };
        /**
         *  TV Channel:
         *  
         *  Channel Name
         *  Channel Logo
         *  Channel BackGround
         *  Channel Number
         *  Channel Logo Localization
         *  
         * */

        private void TVChannelUp_Click(object sender, RoutedEventArgs e)
        {

            channel = (channel + 1) % colors.Length;
            ChangeChannel(channel);
        }

        private void ChangeChannel(int channel)
        {
            // Create an ImageBrush
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = colors[channel];
            TVScreen.Fill = imgBrush;
            TVChannelName.Text = channels[channel];
        }

        private void TVChannelDown_Click(object sender, RoutedEventArgs e)
        {
            channel = ((--channel) < 0)?colors.Length -1 : channel   ;
            ChangeChannel(channel);
        }
        #endregion
    }
}
