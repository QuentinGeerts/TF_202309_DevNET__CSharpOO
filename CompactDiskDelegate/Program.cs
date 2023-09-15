using CompactDiskDelegate.Models;

namespace CompactDiskDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompactDisk cd = new CompactDisk(0, 120, 340, 720, 980);

            CompactDiskPlayer player = new CompactDiskPlayer();
            player.CurrentDisk = cd;

            player.AddTrack(player.SelectTrack(5));
            player.AddTrack(player.SelectTrack(1));
            player.AddTrack(player.SelectTrack(3));
            player.AddTrack(player.SelectTrack(2));
            player.AddTrack(player.SelectTrack(4));

            player.Play();
        }
    }
}