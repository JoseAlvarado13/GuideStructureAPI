using Microsoft.Extensions.Configuration;

namespace Settings.Commons
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// 
    /// This class manages the base configuration to manage appsetting file that some special classes share with each other.
    /// </summary>
    public class BaseConfigurationAppSetting
    {
        #region Constructor 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Constructor for initializing the class with the configuration object.
        /// </summary>
        /// <param name=""></param> 
        protected IConfiguration GetConfiguration()
        {
            // Define the path to the appsettings.json
            string basePath = Directory.GetCurrentDirectory(); // Gets the output directory
            return new ConfigurationBuilder()
                .SetBasePath(basePath) // Set the base path
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Load the file
                .Build();
        }
        #endregion
    }
}
