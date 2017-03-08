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
    public partial class BHBay1 : PhoneApplicationPage
    {

        DispatcherTimer mytimer = new DispatcherTimer();
        DispatcherTimer mytimer2 = new DispatcherTimer();
        DispatcherTimer mytimerK = new DispatcherTimer();
        DispatcherTimer mytimerK2 = new DispatcherTimer();
        DispatcherTimer mytimerK3 = new DispatcherTimer();
        DispatcherTimer mytimerG = new DispatcherTimer();
        DispatcherTimer mytimerS = new DispatcherTimer();
        DispatcherTimer mytimerS2 = new DispatcherTimer();
        DispatcherTimer mytimerS3 = new DispatcherTimer();
        DispatcherTimer mytimerS4 = new DispatcherTimer();
        DispatcherTimer mytimerC = new DispatcherTimer();
        VibrationDevice Vibration = VibrationDevice.GetDefault();

        int currentcount = 180;
        int currentcount2 = 180;
        int currentcountK = 240;
        int currentcountK2 = 240;
        int currentcountK3 = 240;
        int currentcountG = 300;
        int currentcountS = 150;
        int currentcountS2 = 150;
        int currentcountS3 = 150;
        int currentcountS4 = 150;
        int currentcountC = 240;


        public BHBay1()
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

            mytimerK3.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerK3.Tick += new EventHandler(mytimerK3_Tick);

            mytimerG.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerG.Tick += new EventHandler(mytimerG_Tick);

            mytimerS.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerS.Tick += new EventHandler(mytimerS_Tick);

            mytimerS2.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerS2.Tick += new EventHandler(mytimerS2_Tick);

            mytimerS3.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerS3.Tick += new EventHandler(mytimerS3_Tick);

            mytimerS4.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerS4.Tick += new EventHandler(mytimerS4_Tick);

            mytimerC.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimerC.Tick += new EventHandler(mytimerC_Tick);

        }

        private void mytimerS4_Tick(object sender, EventArgs e)
        {
            TimerS4.Text = currentcountS4--.ToString();

            if (currentcountS4 == -1)
            {
                mytimerS4.Stop();
                currentcountS4 = 150;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerS4.Text = " ";
            }
        }

        private void mytimerS3_Tick(object sender, EventArgs e)
        {
            TimerS3.Text = currentcountS3--.ToString();

            if (currentcountS3 == -1)
            {
                mytimerS3.Stop();
                currentcountS3 = 150;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerS3.Text = " ";
            }
        }

        private void mytimerK3_Tick(object sender, EventArgs e)
        {
            TimerK3.Text = currentcountK3--.ToString();

            if (currentcountK3 == -1)
            {
                mytimerK3.Stop();
                currentcountK3 = 240;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerK3.Text = " ";
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

        private void mytimerS2_Tick(object sender, EventArgs e)
        {
            TimerS2.Text = currentcountS2--.ToString();

            if (currentcountS2 == -1)
            {
                mytimerS2.Stop();
                currentcountS2 = 150;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerS2.Text = " ";
            }
        }

        private void mytimerC_Tick(object sender, EventArgs e)
        {
            TimerC.Text = currentcountC--.ToString();

            if (currentcountC == -1)
            {
                mytimerC.Stop();
                currentcountC = 240;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerC.Text = " ";
            }
        }



        private void mytimerS_Tick(object sender, EventArgs e)
        {
            TimerS.Text = currentcountS--.ToString();

            if (currentcountS == -1)
            {
                mytimerS.Stop();
                currentcountS = 150;
                Ring.Play();
                Vibration.Vibrate(TimeSpan.FromSeconds(2));
                TimerS.Text = " ";
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

            if(currentcountK == -1)
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

            if (currentcount2 == -1)
            {
                mytimer2.Stop();
                currentcount = 180;
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

        private void buttonS_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerS.Start();
        }

        private void buttonC_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerC.Start();
        }

        private void button2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimer2.Start();
        }


        private void buttonK2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK2.Start();
        }

        private void buttonK3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerK3.Start();
        }

        private void buttonS2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerS2.Start();
        }

        private void buttonS3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerS3.Start();
        }

        private void buttonS4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mytimerS4.Start();
        }
    }
}