﻿using Microsoft.AspNetCore.Identity;
using AspNetCoreIdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentityServer
{
    public class Fifo2UserTwoFactorTokenProvider : IUserTwoFactorTokenProvider<ApplicationUser>
    {
        public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            return Task.FromResult(true);
        }

        public Task<string> GenerateAsync(string purpose, UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            return Task.FromResult("fido2");
        }

        public Task<bool> ValidateAsync(string purpose, string token, UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            return Task.FromResult(true);
        }
    }
}
