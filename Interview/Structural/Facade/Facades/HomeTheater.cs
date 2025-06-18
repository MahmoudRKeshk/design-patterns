using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Facades
{
    public class HomeTheater : IHomeTheater
    {
        private readonly IProjector _projector;
        private readonly ISound _sound;
        private readonly IDVD _dvd;
        private readonly ILights _lights;

        public HomeTheater(IProjector projector, ISound sound, IDVD dvd, ILights lights)
        {
            _projector = projector;
            _sound = sound;
            _dvd = dvd;
            _lights = lights;
        }

        public void StartWatchingMovie(string movieName)
        {
            _dvd.Insert(movieName);
            _dvd.On();

            _sound.PlaySound(movieName);
            _sound.SetVolume(75);

            _lights.TurnOnLights();
            _lights.DimLights(50);
            
            _projector.SetInputSource("Cinema");
            _projector.TurnOn();
            _projector.DisplayContent(movieName);

            Console.WriteLine($"Now watching: {movieName}");
        }

        public void StopWatchingMovie()
        {
            _projector.TurnOff();
            _lights.TurnOnLights();
            _sound.StopSound();
            _dvd.Off();
            Console.WriteLine("Movie stopped. Home theater is now off.");
        }
    }
}
