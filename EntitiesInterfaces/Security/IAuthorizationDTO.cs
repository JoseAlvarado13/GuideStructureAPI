﻿namespace EntitiesInterfaces.Security
{
    /// <summary>
    /// AM-001
    /// Author: José Andrés Alvarado Matamoros
    /// This interfaces manages the authorization properties to loging in this API services.
    /// </summary>
    public interface IAuthorizationDTO
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
