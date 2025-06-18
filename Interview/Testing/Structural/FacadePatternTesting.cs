using Interview.Structural.Facade.Facades;
using Interview.Structural.Facade.Subsystems.Implementations;
using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public class FacadePatternTesting
    {
        public static void Run()
        {
            // Dependency Injection for subsystems
            ISound sound = new Sound();
            ILights light = new Lights();
            IProjector projector = new Projector("Movoe 01","Projector 01");
            IDVD dVD = new DVD();

            // Create the home theater system using the Facade pattern
            IHomeTheater homeTheater = new HomeTheater(projector, sound, dVD, light);

            // Start the home theater
            homeTheater.StartWatchingMovie("Movie 01");

            // Stop the home theater
            homeTheater.StopWatchingMovie();
        }
    }
}
