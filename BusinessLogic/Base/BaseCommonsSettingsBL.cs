using Entities.Base;
using EntitiesInterfaces.Base;
using EntitiesInterfaces.Commons.Enums;
using System.Text.Json;

namespace BusinessLogic.Base
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// 
    /// This class serves as a base for reusable methods that can be shared across multiple classes.
    /// </summary>
    public class BaseCommonsSettingsBL
    {
        /// <summary>
        /// Handles exceptions by formatting their details for further processing or display.
        /// </summary>
        /// <param name="exceptionDTO">The DTO containing exception details.</param>
        /// <returns>An IResponseDTO with formatted error information.</returns>
        protected IResponseDTO ManageException(ExceptionDTO exceptionDTO)
        {
            IResponseDTO response = new ResponseDTO();

            try
            {
                //To do: Here we have to added logic to save this error in data base

                // Format the error details into the response object
                response.Result = ActionResult.Error;                
                response.ErrorMessage.Add(exceptionDTO.AdditionalDetails);
            }
            catch (Exception ex)
            {
                //To do: Here we have to add  logic to send a error email indicating the exception            
            }

            return response;
        }
    }
}
