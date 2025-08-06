using System;
using System.Collections.Generic;

namespace Singletons
{
    public class ConfigurationManager : IConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new();
        private Dictionary<string, string> settings;

        private ConfigurationManager()
        {
            settings = new Dictionary<string, string>();
        }

        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
            }
            return _instance;
        }

        public void SetSetting(string key, string value)
        {
            if (settings.ContainsKey(key))
            {
                settings[key] = value;
            }
            else
            {
                settings.Add(key, value);
            }
        }

        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return "Setting not found";
        }
    }
}
