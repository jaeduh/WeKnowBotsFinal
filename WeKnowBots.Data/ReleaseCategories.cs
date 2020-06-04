using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeKnowBots.Data
{
    public enum ReleaseType { FCFS = 1, TimedRaffle, EmailNotifyRaffle }
    public class ReleaseCategories
    {
        public int ReleaseId { get; set; }

        public ReleaseType TypeOfRelease { get; set; }
    }
}
