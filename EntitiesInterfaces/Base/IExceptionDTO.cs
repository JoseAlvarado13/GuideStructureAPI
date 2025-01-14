﻿namespace EntitiesInterfaces.Base
{   
    /// <summary>
    /// AM-001
    /// Author:  José Andrés Alvarado Matamoros
    /// 
    /// Interface for encapsulating exception details.
    /// </summary>
    public interface IExceptionDTO
    {
        /// <summary>
        /// AM-001
        /// Author:  José Andrés Alvarado Matamoros
        /// The HTTP method or operation being performed when the exception occurred.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// AM-001
        /// Author:  José Andrés Alvarado Matamoros
        /// The name of the class where the exception occurred.
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// AM-001
        /// Author:  José Andrés Alvarado Matamoros
        /// 
        /// Any additional data relevant to the exception.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// AM-001
        /// Author:  José Andrés Alvarado Matamoros
        /// 
        /// The exception object containing the error details.
        /// </summary>
        public string Error { get; set; }
    }
}
