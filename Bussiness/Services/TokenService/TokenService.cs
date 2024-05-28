﻿using Bussiness.Services.AuthenticateService;
using Data.Model.TokenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services.TokenService
{
    public class TokenService : IToken
    {
        private readonly IAuthenticateService _authenticateService;
        public TokenService(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        public TokenModel decode(string token)
        {
            var roleName = _authenticateService.decodeToken(token, ClaimsIdentity.DefaultRoleClaimType);
            var userId = _authenticateService.decodeToken(token, "userid");

            return new TokenModel(userId, roleName);
        }
    }
}
