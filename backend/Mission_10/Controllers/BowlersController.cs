using Microsoft.AspNetCore.Mvc;
using Mission_10.Data;

namespace Mission_10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlerRepository _bowlRepository;
        public BowlersController(IBowlerRepository temp)
        {
            _bowlRepository = temp;
        }
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var BowlerData = _bowlRepository.Bowlers
                .Where(Bowler => Bowler.Team.TeamName == "Marlins" || Bowler.Team.TeamName == "Sharks")
                .ToArray();
            return BowlerData;
        }
    }
}
