namespace StudentsManagementAPI.Interface
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
       
    }
}
