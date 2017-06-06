using System;
using System.Threading.Tasks;
using ItRequitment.Core;
using ItRequitment.Core.Repositories;

namespace ItRequitment.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEncrypter _encrypter;

        public UserService(IEncrypter encrypter, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
        }

        public async Task<User> GetAsync(string login)
        {
            var user = await _userRepository.GetAsync(login);
            return user;
        }

        public async Task LoginAsync(string login, string password)
        {
            var user = await _userRepository.GetAsync(login);
            if (user == null)
            {
                throw new Exception("Invalid credentials");
            }
            var salt = _encrypter.GetSalt(password);
            var hashPass = _encrypter.GetHash(password, salt);

            if (user.Password == hashPass)
            {
                return;
            }
            throw new Exception("Invalid credentials");


        }
        public async Task RegisterAsync(User user)
        {
            var getUser = await _userRepository.GetAsync(user.Login);
            if(getUser!=null)
            {
                throw new Exception("User allredy exist");
            }

           
        }
    }
}