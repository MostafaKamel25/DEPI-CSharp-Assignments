using System;
using System.Collections.Generic;
using System.Text;

namespace Project03
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        // Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            SetDuration(totalSeconds);
        }


      
        public Duration(int totalSeconds)
        {
            SetDuration(totalSeconds);
        }


        //  Methods
        private void SetDuration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;

            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;

            Seconds = totalSeconds % 60;
        }


        
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            }
            else
            {
                return $"Seconds :{Seconds}";
            }
        }


        // Equals
        public override bool Equals(object? obj)
        {
            if (obj is not Duration other)
                return false;

            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }


        
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }


        // Convert Duration to total seconds
        private int TotalSeconds
        {
            get
            {
                return Hours * 3600 +
                       Minutes * 60 +
                       Seconds;
            }
        }


        // Operator +
        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration(
                D1.TotalSeconds + D2.TotalSeconds
            );
        }


        // D3 = D1 + 7800

        public static Duration operator +(Duration D1, int seconds)
        {
            return new Duration(
                D1.TotalSeconds + seconds
            );
        }


        // D3 = 666 + D3

        public static Duration operator +(int seconds, Duration D1)
        {
            return new Duration(
                seconds + D1.TotalSeconds
            );
        }


        // ++
        // Increase One Minute

        public static Duration operator ++(Duration D)
        {
            return new Duration(
                D.TotalSeconds + 60
            );
        }


        // --
        // Decrease One Minute

        public static Duration operator --(Duration D)
        {
            int totalSeconds = D.TotalSeconds - 60;

            if (totalSeconds < 0)
                totalSeconds = 0;

            return new Duration(totalSeconds);
        }


        // -

        public static Duration operator -(Duration D1, Duration D2)
        {
            int result = D1.TotalSeconds - D2.TotalSeconds;

            if (result < 0)
                result = 0;

            return new Duration(result);
        }


        // >

        public static bool operator >(Duration D1, Duration D2)
        {
            return D1.TotalSeconds > D2.TotalSeconds;
        }


        // <

        public static bool operator <(Duration D1, Duration D2)
        {
            return D1.TotalSeconds < D2.TotalSeconds;
        }


        // <=

        public static bool operator <=(Duration D1, Duration D2)
        {
            return D1.TotalSeconds <= D2.TotalSeconds;
        }

        // >=
        public static bool operator >=(Duration D1, Duration D2)
        {
            return D1.TotalSeconds >= D2.TotalSeconds;
        }


        // ==
        // !=

        public static bool operator ==(Duration D1, Duration D2)
        {
            if (ReferenceEquals(D1, D2))
                return true;

            if (D1 is null || D2 is null)
                return false;

            return D1.Equals(D2);
        }


        public static bool operator !=(Duration D1, Duration D2)
        {
            return !(D1 == D2);
        }


        // if (D1)

        public static bool operator true(Duration D)
        {
            return D.TotalSeconds > 0;
        }

        public static bool operator false(Duration D)
        {
            return D.TotalSeconds == 0;
        }


        // Duration -> DateTime

        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(
                1,
                1,
                1,
                D.Hours,
                D.Minutes,
                D.Seconds
            );
        }
    }
}
