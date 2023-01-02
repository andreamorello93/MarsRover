using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MarsRover.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoverController : ControllerBase
    {             
        private Rover _rover;  

        public RoverController(Rover rover)
        {
            _rover = rover;
        }
        
        [HttpPost]
        [Route("InitializeRover")]
        public Rover InitializeRover(int x, int y, Direction direction)
        {
            _rover = new Rover(x, y, direction, new Planet(new Point[]{new(1,2), }));
            return _rover;
        }

        [HttpPost]
        [Route("ProcessCommands")]
        public string ProcessCommands(Commands[] commands)
        {
            return _rover.ProcessCommands(commands);
        }
    }
}