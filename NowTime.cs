using System;

namespace NowTime
{
    public static class CNowTime
    {
        public static string strNowTime
        {
            get
            {
                DateTime dt = DateTime.Now;

                return String.Format("{0}/{1}/{2} {3}:{4}:{5}",
                   dt.Month.ToString("D2"),
                   dt.Day.ToString("D2"),
                   dt.Year.ToString("D4"),
                   dt.Hour.ToString("D2"),
                   dt.Minute.ToString("D2"),
                   dt.Second.ToString("D2")
                   );
            }
        }

        public static Action<string> TimeSay = str => Console.WriteLine(CNowTime.strNowTime + " " + str);
        public static Action<string> Write = str => Console.Write(CNowTime.strNowTime + " " + str);
        public static Action<string> WriteLine = str => Console.WriteLine(CNowTime.strNowTime + " " + str);
    }
}
