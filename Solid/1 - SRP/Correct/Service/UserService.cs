using Solid.SRP.Correct.Dto;
using Solid.SRP.Correct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Correct.Service
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailServices _emailServices;

        public UserService(IUserRepository userRepository,
            IEmailServices emailServices)
        {
            _userRepository = userRepository;
            _emailServices = emailServices;
        }

        public string CreateUser(UserRequest user)
        {
            if (!user.Validar())
                return "The email is incorrect";

            _userRepository.CreateUser(user);
            _emailServices.SendEmail("empresa@empresa.com", user.Email.EmailAddress,
                                    "Welcome", "Congratulations, you are registered");

            return "User successfully registered";
        }
    }
}
