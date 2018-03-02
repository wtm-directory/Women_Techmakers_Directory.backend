using Microsoft.AspNetCore.Mvc;

namespace Directory.Api
{
    [Route("/v1/")]
    public class Controller: ControllerBase
    {
        public Controller()
        {

        }
        
        [Route("all")]
        [HttpGet]
        public string GetFullDirectory()
        {
            return "All the directory!!";
        }
    }
}
