﻿using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]  //address: /api/users (route le user tabel)(we da framework talama bnt3amel ma3a http request)
//framework hyshof el controller we ba3d kda constructor fa elframework yfham eny 3ayza data context fa hy3mel new instance of the data context we ydakhalo m3ana we ykon available lena
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync(); //3ayzen n-return list of users,context.User:3shan n-accses user table
        return users;  //return users msh ok 3shan elframework create correct type of http response

    }

    [HttpGet("{id}")]  // /api/users/2 (da route lel parameter elhwa id we momken nhot ay rakam badal 2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }
}
