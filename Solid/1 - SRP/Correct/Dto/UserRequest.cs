using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Correct.Dto
{
    public class UserRequest
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public Email Email { get; set; }

        public bool Validar()
        {
            return Email.Validar();
        }
    }
}
