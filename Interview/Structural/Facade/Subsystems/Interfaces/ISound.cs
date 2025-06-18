using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Interfaces
{
    public interface ISound
    {
        void PlaySound(string soundFile);
        void StopSound();
        void SetVolume(int volumeLevel);
    }
}
