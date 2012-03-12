using System;
using log4net;
using log4net.Config;

namespace Loopc.Foundation.Log
{
    public class LogManager
    {
        private static ILog _log;

        private static ILog Log
        {
            get
            {
                if (_log == null)
                {
                    XmlConfigurator.Configure();
                    _log = log4net.LogManager.GetLogger("Boomboxinc.Log");
                }
                return _log;
            }
        }

        public static void Error(string message)
        {
            if (Log.IsErrorEnabled)
            {
                Log.Error(message);
            }
        }

        public static void Error(Exception ex)
        {
            if (Log.IsErrorEnabled)
            {
                Log.Error(ex.ToString());
            }
        }

        public static void Debug(string message)
        {
            if (Log.IsDebugEnabled)
            {
                Log.Debug(message);
            }
        }

        public static void Fatal(string message)
        {
            if (Log.IsFatalEnabled)
            {
                Log.Fatal(message);
            }
        }

        public static void Info(string message)
        {
            if (Log.IsInfoEnabled)
            {
                Log.Info(message);
            }
        }

        public static void Warn(string message)
        {
            if (Log.IsWarnEnabled)
            {
                Log.Warn(message);
            }
        }

        public static string NewLogSerial()
        {
            var maxSerialLength = 10;
            var now = DateTime.Now;
            var serial = (now - now.Date).Ticks.ToString("x").ToUpper();
            serial = new String('0', maxSerialLength - serial.Length) + serial;

            return String.Format("{0}-{1:yyyyMMdd}-{2}", "E", now, serial);
        }
    }
}
