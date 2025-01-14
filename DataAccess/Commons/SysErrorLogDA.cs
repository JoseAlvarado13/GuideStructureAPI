﻿using DataAccess.DataModel.DracarysModel;
using DataAccessInterface.Commons;
using EntitiesInterfaces.Base;

namespace DataAccess.Commons
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// 
    /// This class manages the syserrorlog CRUD.
    /// </summary>
    public class SysErrorLogDA : ISysErrorLogDA
    {
        #region Save 
        /// <summary>        
        /// AM-001
        /// Author: José Andrés Alvarado Matamoros 
        /// Method to save the system error log inside data base.  
        /// </summary>
        /// <param name="exceptionDTO">Here came the exception information about error.</param> 
        public int Save(IExceptionDTO exceptionDTO)
        {
            using (DracarysContext context = new DracarysContext()) 
            {
            //    context.;
            }
            return 0;
        }
        #endregion
    }
}
