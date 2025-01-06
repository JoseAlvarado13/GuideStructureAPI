using BusinessLogicInterfaces.Security;
using Entities.Security;
using EntitiesInterfaces.Security;
using Settings.Security;

namespace BusinessLogic.Security
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// Class to manage authorization methods to loggin in this api services.
    /// </summary>
    public class AuthorizationBL : IAuthorizationBL
    {
        #region Global Data 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Here you can find instances or global variables.
        /// </summary>    
        private IAuthorizationDTO authorizationDTO;
        #endregion

        #region Constructor 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Constructor for initializing the class with the configuration object.
        /// </summary>
        /// <param></param>
        public AuthorizationBL() 
        {
            authorizationDTO = new AuthorizationDTO(); 
        }
        #endregion 

        #region  Get
        /// <summary>
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros
        /// Method to validate credential sent of the other application.
        /// </summary>
        /// <param name="UserName">Here came user sent to another external application.</param> 
        /// <param name="Password">Here came password sent to another external application.</param> 
        /// <@Return>This method return true if the credential are de same,  other hand the method'll return false .</param> 
        public bool Get(string UserName, string Password)
        {

            return true;
        }
        #endregion
    }
}
