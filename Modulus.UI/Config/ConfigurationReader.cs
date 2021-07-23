using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Config
{
    /// <summary>
    /// Reads setting values for specific assembly config file in the solution.
    /// </summary>
    public class ConfigurationReader
    {
        private static Dictionary<string, Configuration> Configs = new Dictionary<string, Configuration>();

        /// <summary>
        /// Gets the setting from the app config of the given assembly.
        /// </summary>
        /// <param name="assmeblyName">Assembly app.config to search.</param>
        /// <param name="settingKey">Setting to get.</param>
        /// <returns>Setting value.</returns>
        public static string GetSetting(string assmeblyName, string settingKey)
        {
            if (!Configs.ContainsKey(assmeblyName))
            {
                LoadAssemblyConfiguration(assmeblyName);
            }

            KeyValueConfigurationElement setting = Configs[assmeblyName].AppSettings.Settings[settingKey];

            if (setting == null)
            {
                string message = string.Format("Could not find setting '{0}' in '{1}.dll.config'", settingKey, assmeblyName);
                throw new SettingsPropertyNotFoundException(message);
            }

            return setting.Value;
        }

        /// <summary>
        /// Gets the setting from the app config of the calling assembly.
        /// </summary>
        /// <param name="settingKey">Setting to get.</param>
        /// <returns>Setting value.</returns>
        public static string GetCurrentAssemblySetting(string settingKey)
        {
            string assemblyName = Assembly.GetCallingAssembly().GetName().Name;
            string setting = GetSetting(assemblyName, settingKey);
            return setting;
        }

        private static void LoadAssemblyConfiguration(string assemblyName)
        {
            ExeConfigurationFileMap configurationFileMap = new ExeConfigurationFileMap();
            configurationFileMap.ExeConfigFilename = GetConfigFilePath(assemblyName);
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configurationFileMap, ConfigurationUserLevel.None);

            Configs.Add(assemblyName, config);
        }

        private static string GetConfigFilePath(string assemblyName)
        {
            return string.Format("{0}\\{1}.dll.config", AppDomain.CurrentDomain.BaseDirectory, assemblyName);
        }
    }
}
