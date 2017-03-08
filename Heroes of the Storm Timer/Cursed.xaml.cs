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
    public partial class Cursed : PhoneApplicationPage
    {
        DispatcherTimer mytimer = new DispatcherTimer();
        DispatcherTimer mytimer2 = new DispatcherTimer();
        DispatcherTimer mytimerK = new DispatcherTimer();
        DispatcherTimer mytimerK2 = new DispatcherTimer();
        DispatcherTimer mytimerG = new DispatcherTimer();
        DispatcherTimer mytimerG2 = new DispatcherTimer();
        DispatcherTimer mytimerT = new DispatcherTimer();
        DispatcherTimer mytimerAC = new DispatcherTimer();
        VibrationDevice Vibration = VibrationDevice.GetDefault();


        int currentcount = 180;
        int currentcount2 = 180;
        int currentcountK = 240;
        int currentcountK2 = 240;
        int currentcountG = 300;
        int currentcountG2 = 300;
        int currentcountT = 70;
        int currentcountAC = 150;

        public Cursed()
        {
            InitializeComponent();

            mytimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer.Tick += new EventHandler(mytimer_Tick);

            mytimer2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer2.Tick += new EventHandler(mytimer2_Tick);

            mytimerK.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK.Tick += new EventHandler(mytimerK_Tick);

            mytimerK2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK2.Tick += new EventHandler(mytimerK2_Tick);

            mytimerG.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerG.Tick += new EventHandler(mytimerG_Tick);

            mytimerG2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerG2.Tick += new EventHandler(mytimerG2_Tick);

            mytimerT.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerT.Tick += new EventHandler(mytimerT_Tick);

            mytimerAC.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerAC.Tick += new EventHandler(mytimerAC_Tick);

        }

        private void mytimerAC_Tick(object sender, EventArgs e)
        {
            TimerAC.Text = currentcountAC--.ToString();

            if (currentcountAC == -1)
            {
                mytimerAC.Stop();
                currentcountAC = 300;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerAC.Text = " ";
            }
        }

        private void mytimerT_Tick(object sender, EventArgs e)
        {
            TimerT.Text = currentcountT--.ToString();

            if (currentcountT == -1)
            {
                mytimerT.Stop();
                currentcountT = 300;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerT.Text = " ";
            }
        }

        private void mytimerG2_Tick(object sender, EventArgs e)
        {
            TimerG2.Text = currentcountG2--.ToString();

            if (currentcountG2 == -1)
            {
                mytimerG2.Stop();
                currentcountG2 = 300;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerG2.Text = " ";
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

        private void mytimer2_Tick(object sender, EventArgs e)
        {
            Timer2.Text = currentcount2--.ToString();

            if (currentcount == -1)
            {
                mytimer2.Stop();
                currentcount2 = 180;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                Timer2.Text = " ";
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

        private void buttonG_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerG.Start();
        }

        private void button2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer2.Start();
        }


        private void buttonK2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK2.Start();
        }

        private void buttonG2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerG2.Start();
        }

        private void buttonT_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerT.Start();
        }

        private void buttonAC_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerAC.Start();
        }
    }
}