using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.infra.datasource
{
    public abstract class ConfigDatasource
    {
        public abstract void WriteStringKey(String pKey, String pValue);

        public abstract String ReadStringKey(String pKey);

        public abstract void WriteIntKey(String pKey, int pValue);

        public abstract int ReadIntKey(String pKey);

    }
}
