using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Patient:Person
    {
        public Patient()
        {
            IsNew = true; //刚 new 出来的时候，这个 isnew 是 true 。
            BloodSugar = 4.9f;
            History = new List<string>();//把这个要 new 出来.
        }
        public string FullName => $"{LastName}{FirstName}";
        public bool IsNew { get; set; }  //是否是刚出生的。
        public float BloodSugar { get; set; }
        public int HeartBeatRate { get; set; }
        public void IncressHeartBeatRate()   //计算心跳
        {
            //执行完以后的方法 + 2
            HeartBeatRate = CalulateHeartBeatRate() + 2;
        }
        public List<string> History { get; set; }
        private int CalulateHeartBeatRate()  //心跳
        {
            var random = new Random();
            return random.Next(1, 100);
        }
    }
}
