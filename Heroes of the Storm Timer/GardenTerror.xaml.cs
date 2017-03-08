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
    public partial class GardenTerror : PhoneApplicationPage
    {
        DispatcherTimer mytimer = new DispatcherTimer();
        DispatcherTimer mytimer2 = new DispatcherTimer();
        DispatcherTimer mytimer3 = new DispatcherTimer();
        DispatcherTimer mytimer4 = new DispatcherTimer();
        DispatcherTimer mytimerK = new DispatcherTimer();
        DispatcherTimer mytimerK2 = new DispatcherTimer();
        DispatcherTimer mytimerN = new DispatcherTimer();
        VibrationDevice Vibration = VibrationDevice.GetDefault();

        int currentcount = 180;
        int currentcount2 = 180;
        int currentcount3 = 180;
        int currentcount4 = 180;
        int currentcountK = 240;
        int currentcountK2 = 240;
        int currentcountN = 170;

        public GardenTerror()
        {
            InitializeComponent();

            mytimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer.Tick += new EventHandler(mytimer_Tick);

            mytimer2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer2.Tick += new EventHandler(mytimer2_Tick);

            mytimer3.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer3.Tick += new EventHandler(mytimer3_Tick);

            mytimer4.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer4.Tick += new EventHandler(mytimer4_Tick);

            mytimerK.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK.Tick += new EventHandler(mytimerK_Tick);

            mytimerK2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK2.Tick += new EventHandler(mytimerK2_Tick);

            mytimerN.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerN.Tick += new EventHandler(mytimerN_Tick);

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

        private void mytimer2_Tick(object sender, EventArgs e)
        {
            Timer2.Text = currentcount2--.ToString();

            if (currentcount2 == -1)
            {
                mytimer2.Stop();
                currentcount2 = 180;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                Timer2.Text = " ";
            }
        }

        private void mytimer3_Tick(object sender, EventArgs e)
        {
            Timer3.Text = currentcount3--.ToString();

            if (currentcount3 == -1)
            {
                mytimer3.Stop();
                currentcount3 = 180;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                Timer3.Text = " ";
            }
        }

        private void mytimer4_Tick(object sender, EventArgs e)
        {
            Timer4.Text = currentcount4--.ToString();

            if (currentcount4 == -1)
            {
                mytimer4.Stop();
                currentcount4 = 180;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                Timer4.Text = " ";
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

        private void mytimerN_Tick(object sender, EventArgs e)
        {
            TimerN.Text = currentcountN--.ToString();

            if (currentcountN == -1)
            {
                mytimerN.Stop();
                currentcountN = 170;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerN.Text = " ";
            }
        }

        private void button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer.Start();
        }

        private void button2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer2.Start();
        }

        private void button3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer3.Start();
        }

        private void button4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer4.Start();
        }

        private void buttonK_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK.Start();
        }

        private void buttonK2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK2.Start();
        }

        private void buttonN_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerN.Start();
        }
    }
}