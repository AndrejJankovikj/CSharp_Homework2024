using Microsoft.AspNetCore.Mvc;

namespace Homework01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAll()
        {
            return StatusCode(StatusCodes.Status200OK, StaticDb.Usernames);
        }
        [HttpGet("{index}")]
        public ActionResult<string> GetByIndex(int index)
        {
            if (index < 0)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, "Only the numbers 0 and above!");
            }
            if (index >= StaticDb.Usernames.Count)
            {
                return StatusCode(StatusCodes.Status418ImATeapot, "I am a teapot and the index cannot be bigger than the length of the list!");
            }

            return StatusCode(StatusCodes.Status202Accepted, StaticDb.Usernames[index]);
        }
        [HttpPost]
        public IActionResult PostUser([FromBody] string username)
        {
            try
            {

                if (string.IsNullOrEmpty(username))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Username cannot be empty");
                }
                StaticDb.Usernames.Add(username);
                return StatusCode(StatusCodes.Status201Created, "Username Added");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser([FromBody] string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Username cannot be empty");
            }
            if (!StaticDb.Usernames.Contains(username))
            {
                return StatusCode(StatusCodes.Status404NotFound, "User was not found");
            }
            StaticDb.Usernames.Remove(username);
            return StatusCode(StatusCodes.Status204NoContent, "Username has been removed!");


        }


    }
}
