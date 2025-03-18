using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Services;

namespace MyApi.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase {
    private readonly IUserService _userService;
    
    public UsersController(IUserService userService) {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers() {
        return Ok(await _userService.GetUsers());
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user) {
        var createdUser = await _userService.CreateUser(user);
        return CreatedAtAction(nameof(GetUsers), new { id = createdUser.Id }, createdUser);
    }
}
