﻿using Evolve.Domain.Auth.Model;
using MongoDB.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.Infrastructure.Auth
{
    public class MongoIdentityUser : IdentityUser, IIdentityUser
    {
        public MongoIdentityUser(string userName) : base(userName)
        {

        }
    }
}
