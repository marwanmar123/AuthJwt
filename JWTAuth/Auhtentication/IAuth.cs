using JWTAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth.Auhtentication
{
    public interface IAuth
    {
        Task<TokenAuth> Register(Register register);
        Task<TokenAuth> DoLogin(Login token);
        Task<string> AddRole(RoleWork role);
        Task<string> CancelRole(RoleWork role);
    }
}
