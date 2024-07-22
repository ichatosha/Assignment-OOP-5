using assignment_oop_5.project_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5.project_1.Classes
{
    internal class Duration : IDuration
    {
        public int Hours   { get;set ; }
        public int Minutes { get; set ; }
        public int Seconds { get; set ; }


        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }


        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }


        private void Normalize()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }



        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Duration d = (Duration)obj;
            return (Hours == d.Hours) && (Minutes == d.Minutes) && (Seconds == d.Seconds);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Hours, Minutes, Seconds).GetHashCode();
        }


        // Operators overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }
        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

    }


}
