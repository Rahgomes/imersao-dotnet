using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SocialBots.Models;

namespace SocialBots.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static List<User> users = new List<User>();
    private static int id = 0;

    [HttpGet]
    public List<User> GetAllUsers()
    {
        return users;
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] User user)
    {
        user.Id = id++;
        users.Add(user);

        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById([FromRoute] int id)
    {
        var user = users.FirstOrDefault(user => user.Id == id);

        if (user == null)
        {            
            return NotFound();
        }

        return Ok(user);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUserById([FromRoute] int id)
    {
        var user = users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        users.Remove(user);

        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUserById(int id, [FromBody] User user)
    {
        var userList = users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        userList.Name = user.Name;
        userList.Nickname = user.Nickname;
        userList.Job= user.Job;

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateUserPartialById(int id, JsonPatchDocument<User> patch)
    {
        var user = users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        patch.ApplyTo(user, ModelState);

        if (!TryValidateModel(user))
        {
            return ValidationProblem(ModelState);
        }

        return NoContent();
    }
}
