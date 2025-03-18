using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Services;

public class UserService : IUserService {
    private readonly AppDbContext _context;
    
    public UserService(AppDbContext context) {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsers() {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> CreateUser(User user) {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
}
