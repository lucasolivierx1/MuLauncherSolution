using MuLauncher.app.configs.domain;
using MuLauncher.app.configs.domain.repositories;
using MuLauncher.app.configs.infra.datasource;

namespace MuLauncher.app.configs.infra.repositories
{
    public class ConfigRepositoryImpl : ConfigRepository
    {
        ConfigDatasource dataSource;

        public ConfigRepositoryImpl(ConfigDatasource pDataSource)
        {
            dataSource = pDataSource;
        }

        public override MuConfig LoadConfig()
        {
            return new MuConfigModel(
                    dataSource.ReadIntKey("WindowMode"),
                    dataSource.ReadIntKey("SoundOnOff"),
                    dataSource.ReadIntKey("Resolution"),
                    dataSource.ReadIntKey("MusicOnOff"),
                    dataSource.ReadStringKey("ID"),
                    dataSource.ReadStringKey("LangSelection"));
        }

        public override void SaveConfig(MuConfig pConfig)
        {
            dataSource.WriteIntKey("WindowMode", pConfig.WindowMode);
            dataSource.WriteIntKey("SoundOnOff", pConfig.SoundOnOff);
            dataSource.WriteIntKey("Resolution", pConfig.Resolution);
            dataSource.WriteIntKey("MusicOnOff", pConfig.MusicOnOff);
            dataSource.WriteStringKey("ID", pConfig.ID);
            dataSource.WriteStringKey("LangSelection", pConfig.LangSelection);
        }
    }
}
