using Microsoft.AspNetCore.Mvc;

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
            _rover = _rover.Initalize(x, y, direction, new Planet());
            return _rover;
        }

        [HttpPost]
        [Route("ProcessCommands")]
        public ProcessCommandDto ProcessCommands(Commands[] commands)
        {
            return new ProcessCommandDto
            {
                CommandResult = _rover.ProcessCommands(commands),
                Rover = _rover
            };
        }
    }
}