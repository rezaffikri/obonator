using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obonator.Shared.Auth
{
    public class UserModel
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
