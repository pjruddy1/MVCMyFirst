using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMyFirst.Models
{
    public class ActivityModel
    {
        public string name { get; set; }
        public int hoursSpent { get; set; }
        public bool spreadable { get; set; }

    }
}