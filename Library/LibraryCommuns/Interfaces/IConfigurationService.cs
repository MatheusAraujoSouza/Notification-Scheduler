using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCommuns.Interfaces
{
    public interface IConfigurationService
    {
        string GetAppSetting(string key);
        T GetAppSetting<T>(string key, T defaultValue = default);
    }
}
