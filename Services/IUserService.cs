using MyApi.Models;

namespace MyApi.Services;

public interface IUserService {
    Task<IEnumerable<User>> GetUsers();
    Task<User> CreateUser(User user);
}
