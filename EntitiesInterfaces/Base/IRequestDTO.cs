namespace EntitiesInterfaces.Base
{
    /// <summary>
    /// AM-001
    /// José Andrés Alvarado Matamoros.
    /// This interface is a versatile container class to store various types of data,
    /// including strings, JSON strings, integers, or other entities, this object is a Request class to manage in this base structure
    /// </summary>
    public interface IRequestDTO
    {
        object Value { get; set; }
    }
}
