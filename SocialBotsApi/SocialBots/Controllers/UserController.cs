using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SocialBots.Data;
using SocialBots.Data.DTOs;
using SocialBots.Models;

namespace SocialBots.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private SocialBotContext _context;
    private IMapper _mapper;

    public UserController(SocialBotContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] CreateUserDTO userDTO)
    {
        User user = _mapper.Map<User>(userDTO);
        _context.Users.Add(user);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpGet]
    public IEnumerable<ReadUserDTO> GetAllUsers()
    {
        return _mapper.Map<List<ReadUserDTO>>(_context.Users.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById([FromRoute] int id)
    {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        var userDTO = _mapper.Map<ReadUserDTO>(user);

        return Ok(user);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUserById([FromRoute] int id)
    {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        _context.Remove(user);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUserById(int id, [FromBody] UpdateUserDTO userDTO)
    {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        _mapper.Map(userDTO, user);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateUserPartialById(int id, JsonPatchDocument<UpdateUserDTO> patch)
    {
        var user = _context.Users.FirstOrDefault(user => user.Id == id);

        if (user == null) return NotFound();

        var userUpdate = _mapper.Map<UpdateUserDTO>(user);

        patch.ApplyTo(userUpdate, ModelState);

        if (!TryValidateModel(userUpdate))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(userUpdate, user);
        _context.SaveChanges();

        return NoContent();
    }
}
