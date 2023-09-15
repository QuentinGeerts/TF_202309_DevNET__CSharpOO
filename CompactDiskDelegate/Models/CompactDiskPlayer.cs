using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactDiskDelegate.Models
{
    public delegate void CDPlayerProgram();

    internal class CompactDiskPlayer
    {
        public CompactDisk CurrentDisk { get; set; }

        public CDPlayerProgram Program;

        public CDPlayerProgram SelectTrack (int startAt)
        {
            return delegate
            {
                Console.WriteLine($"Nous lisons la piste {startAt} au temps {CurrentDisk.TimerTrack[startAt - 1]}");
            };
        }

        public void AddTrack(CDPlayerProgram selectedTrack)
        {
            Program += selectedTrack;
        }

        public void Play()
        {
            if (Program != null) { Program(); }
        }
    }
}
