using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class AuthenticationService
    {
        private readonly IPasswordHasher passwordHasher;

        public AuthenticationService(IPasswordHasher passwordHasher) 
        {
            this.passwordHasher = passwordHasher;
        }
    }
}