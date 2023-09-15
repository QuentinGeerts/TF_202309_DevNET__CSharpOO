using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactDiskDelegate.Models
{
    internal class CompactDisk
    {
        public int[] TimerTrack;
        public CompactDisk(params int[] trackStartAt) 
        {
            TimerTrack = trackStartAt;
        }
    }
}
