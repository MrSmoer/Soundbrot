using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Threading;

namespace Soundbrot
{
    class Soundplayer
    {
        public int device = 0;
        public Soundplayer(int pdevice)
        {
            device = pdevice;
        }

        public void playSound(object filepath)
        {
            

            //Console.WriteLine("Instance thread procedure. Data='{0}'", filepath);
            String pathstring = filepath.ToString();
            using (var audioFile = new AudioFileReader(pathstring))
            using (var outputDevice = new WaveOutEvent())
            {
                //Console.WriteLine(WaveOut.DeviceCount);
                outputDevice.DeviceNumber = device;
                Console.WriteLine(outputDevice);
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }

            }
        }
        
    }
}
