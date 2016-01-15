using System;   
using System.Windows.Input;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Proximity
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void btnGrocery_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=grocery";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private async void btnBank_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=bank";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }


        private async void btnHospital_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=hospital";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private async void btnRestaurant_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=restaurant";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private async void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=coffee";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }    
            else
            {
                // URI launch failed
            }
        }

        private async void btnPark_Click(object sender, RoutedEventArgs e)
        {
            Geolocator location = new Geolocator();
            Geoposition position = await location.GetGeopositionAsync();
            //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
            string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=park";
            var uri = new Uri(uriToLaunch);

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
            }
        }

        private async void KeyDown_Pressed(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                var search = txtSearch.Text;

                Geolocator location = new Geolocator();
                Geoposition position = await location.GetGeopositionAsync();
                //  string uriToLaunch = @"bingmaps:?cp=39.4267995~-76.7787601&lvl=12&q=skatepark";
                string uriToLaunch = @"bingmaps:?cp=" + position.Coordinate.Point.Position.Latitude + "~" + position.Coordinate.Point.Position.Longitude + "&lvl=11&q=" + search;
                var uri = new Uri(uriToLaunch);

                // Launch the URI
                var success = await Windows.System.Launcher.LaunchUriAsync(uri);
                if (success)
                {
                    txtSearch.Text = string.Empty;


                }
                else
                {
                    // URI launch failed
                }
            }
        }
        
    }
}
