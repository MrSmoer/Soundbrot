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

        public void playSound(object filepath) 
        {

            Console.WriteLine("Instance thread procedure. Data='{0}'", filepath);
            String t = filepath.ToString();
            using (var audioFile = new AudioFileReader(t))
            using (var outputDevice = new WaveOutEvent())
            {
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
