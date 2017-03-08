using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using Windows.Phone.Devices.Notification;

namespace Heroes_of_the_Storm_Timer
{
    public partial class ToSQ : PhoneApplicationPage
    {
        DispatcherTimer mytimer = new DispatcherTimer();
        DispatcherTimer mytimerK = new DispatcherTimer();
        DispatcherTimer mytimerK2 = new DispatcherTimer();
        DispatcherTimer mytimerG = new DispatcherTimer();
        VibrationDevice Vibration = VibrationDevice.GetDefault();

        int currentcount = 180;
        int currentcountK = 240;
        int currentcountK2 = 240;
        int currentcountG = 300;

        public ToSQ()
        {
            InitializeComponent();

            mytimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer.Tick += new EventHandler(mytimer_Tick);

            mytimerK.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK.Tick += new EventHandler(mytimerK_Tick);

            mytimerK2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK2.Tick += new EventHandler(mytimerK2_Tick);

            mytimerG.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerG.Tick += new EventHandler(mytimerG_Tick);
        }

        private void mytimerG_Tick(object sender, EventArgs e)
        {
            TimerG.Text = currentcountG--.ToString();

            if (currentcountG == -1)
            {
                mytimerG.Stop();
                currentcountG = 300;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerG.Text = " ";
            }
        }

        private void mytimerK2_Tick(object sender, EventArgs e)
        {
            TimerK2.Text = currentcountK2--.ToString();

            if (currentcountK2 == -1)
            {
                mytimerK2.Stop();
                currentcountK2 = 240;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerK2.Text = " ";
            }
        }

        private void mytimerK_Tick(object sender, EventArgs e)
        {
            TimerK.Text = currentcountK--.ToString();

            if (currentcountK == -1)
            {
                mytimerK.Stop();
                currentcountK = 240;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerK.Text = " ";
            }
        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
            Timer.Text = currentcount--.ToString();

            if (currentcount == -1)
            {
                mytimer.Stop();
                currentcount = 180;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                Timer.Text = " ";
            }
        }

        private void button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer.Start();
        }

        private void buttonK_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK.Start();
        }

        private void buttonK2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK2.Start();
        }

        private void buttonG_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerG.Start();
        }
    }
}