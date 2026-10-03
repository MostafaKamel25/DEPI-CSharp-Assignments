using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    public class AppLogger
    {
        private static AppLogger? _instance = null;

        private AppLogger()
        {
        }

        public static AppLogger GetLogger()
        {
            if (_instance == null)
            {
                _instance = new AppLogger();
            }

            return _instance;
        }
    }
}
