using BusinessLogic.API;
using BusinessLogicInterfaces.API;
using BusinessLogicInterfaces.Commons;
using Entities.API;
using EntitiesInterfaces.API;

namespace BusinessLogic.Commons
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// Class manage exchange rate  to public hacienda of Costa Rica services.
    /// </summary>
    public class ExchangeRateBL : IExchangeRateBL
    {
        #region Global Data 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Here you can find instances or global variables.
        /// </summary>    
        private IApiConfigurationBL apiConfigurationBL;
        private IHaciendaDTO haciendaDTO;
        #endregion

        #region Constructor 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Constructor for initializing the class with the configuration object.
        /// </summary>
        /// <param></param>
        public ExchangeRateBL()
        {
          
            haciendaDTO = new HaciendaDTO();
        }
        #endregion

        #region Get
        /// <summary>
        /// AM-001
        /// José Andres Alvarado Matamoros.
        /// Method handle of get exchange rate to public hacienda of Costa Rica services.
        /// </summary>
        /// <param></param> 
        /// <returns>A string containing the exchange rate response.</returns>
        public string Get()
        {
            apiConfigurationBL = new ApiConfigurationBL
            {
                Url = haciendaDTO.Host + haciendaDTO.ExchangeRate,
                Method = HttpMethod.Get
            };

            string response =apiConfigurationBL.Call();
            return response;
        }
        #endregion
    }
}
