using okulSistem.Business.Abstract;
using okulSistem.DataAccess.Abstract;
using okulSistem.DataAccess.Concrete;
using okulSistem.Entities;

namespace okulSistem.Business.Concrete;

public class UserManager:IUserService
{
    private IUserRepository _userRepository;

    public UserManager()
    {
        _userRepository = new UserRepository();
    }
    public List<User> GetAllUser()
    {
        return _userRepository.GetAllUsers();
    }

    public User GetByUserId(int id)
    {
        return _userRepository.GetByUserId(id);
    }

    public User CreateUser(User user)
    {
        return _userRepository.CreateUser(user);
    }

    public User UpdateUser(User user)
    {
        return _userRepository.UpdateUser(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }
}