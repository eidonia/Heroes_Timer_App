using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Heroes_of_the_Storm_Timer.Resources;

namespace Heroes_of_the_Storm_Timer
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void BHBay_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BHBay1.xaml", UriKind.Relative));
        }

        private void Cursed_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cursed.xaml", UriKind.Relative));
        }

        private void Haunted_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HauntedMines.xaml", UriKind.Relative));
        }

        private void Spider_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ToSQ.xaml", UriKind.Relative));
        }

        private void Dragon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DragonShire.xaml", UriKind.Relative));
        }

        private void Temple_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Skytemple.xaml", UriKind.Relative));
        }

        private void Eternity_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/battleEternity.xaml", UriKind.Relative));
        }

        private void Shrines_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/InfernalShrines.xaml", UriKind.Relative));
        }

        private void Garden_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GardenTerror.xaml", UriKind.Relative));
        }
    }
}