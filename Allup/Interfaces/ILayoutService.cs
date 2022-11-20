using Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Interfaces
{
    public interface ILayoutService
    {

     Task<Dictionary<string,string>> GetSettingsAsync();
    }
}
