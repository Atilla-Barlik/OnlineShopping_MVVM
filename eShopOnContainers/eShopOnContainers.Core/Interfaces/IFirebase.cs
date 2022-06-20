using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Interfaces
{
    public interface IFirebase
    {
        Task<string> Login(string email, string password);
        Task<string> Register(string email, string password);
    }
}
