using Solid.SRP.Correct.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Correct.Interface
{
    public interface IUserRepository
    {
        void CreateUser(UserRequest newUser);
    }
}
