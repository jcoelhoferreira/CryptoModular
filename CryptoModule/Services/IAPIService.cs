using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoModule.Services
{
    public interface IAPIService
    {
        Task<Response> GetCryptoInfo();
    }
}
