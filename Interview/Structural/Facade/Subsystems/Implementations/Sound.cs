using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Implementations
{
    public class Sound : ISound
    {
        private string _currentSoundFile;
        private int _volumeLevel;
        private bool _isPlaying;
        public void PlaySound(string soundFile)
        {
            if (string.IsNullOrEmpty(soundFile))
            {
                throw new ArgumentException("Sound file cannot be null or empty.", nameof(soundFile));
            }
            _currentSoundFile = soundFile;
            _isPlaying = true;
            Console.WriteLine($"Playing sound: {_currentSoundFile}");
        }

        public void SetVolume(int volumeLevel)
        {
            if (string.IsNullOrEmpty(_currentSoundFile))
            {
                throw new InvalidOperationException("No sound is currently playing. Please play a sound first.");
            }else
            {
                this._volumeLevel = volumeLevel;
            }
        }

        public void StopSound()
        {
            if (string.IsNullOrEmpty(this._currentSoundFile))
            {
                throw new InvalidOperationException("No sound is currently playing. Please play a sound first.");
            }else
            {
                this._isPlaying = false;
            }            
        }
    }
}
