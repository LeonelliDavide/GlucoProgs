﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoMan
{
    // Doing nothing Alarm
    // !!!! TODO find out how to make and alarm in Android
    // and implement it here 
    public partial class Alarm
    {
        // Android dependant part of the Alarm class
        private System.Timers.Timer alarm;

        public void InitAlarm()
        {
            alarm = new System.Timers.Timer();
            alarm.Elapsed += Alarm_Triggered;
        }
        public void SetAlarm(TimeSpan AlarmTimeSpan)
        {
            alarm.Interval = AlarmTimeSpan.TotalMilliseconds;
            alarm.Start();
        }
        private void Alarm_Triggered(object sender, System.Timers.ElapsedEventArgs e)
        {
            alarm.Stop();
            try
            {
                //player = new System.Media.SoundPlayer();
                //player.SoundLocation = @"C:\Windows\Media\Alarm03.wav";
                //player.PlayLooping();
                //playing = true;
            }
            catch (Exception ex)
            {

            }
        }
        public void StopAlarm()
        {
            //if (playing)
            //{
            //    player.Stop();
            //    playing = false;
            //}
            //else
            //{
            //    alarm.Stop();
            //    alarm.Dispose();
            //}
        }
    }
}
