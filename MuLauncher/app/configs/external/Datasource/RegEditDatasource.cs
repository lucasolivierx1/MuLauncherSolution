using Microsoft.Win32;
using MuLauncher.app.configs.domain;
using MuLauncher.app.configs.infra.datasource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.external.Datasource
{
    public class RegEditDatasource : ConfigDatasource
    {

        public override int ReadIntKey(string pKey)
        {
            return (int)Registry.CurrentUser.OpenSubKey(MuConfig.WEBZEN_DIR, true).GetValue(pKey);
        }

        public override string ReadStringKey(string pKey)
        {
            return (String)Registry.CurrentUser.OpenSubKey(MuConfig.WEBZEN_DIR, true).GetValue(pKey);
        }

        public override void WriteIntKey(string pKey, int pValue)
        {
            Registry.CurrentUser.OpenSubKey(MuConfig.WEBZEN_DIR, true).SetValue(pKey, pValue);
        }

        public override void WriteStringKey(string pKey, string pValue)
        {
            Registry.CurrentUser.OpenSubKey(MuConfig.WEBZEN_DIR, true).SetValue(pKey, pValue);
        }
    }
}
