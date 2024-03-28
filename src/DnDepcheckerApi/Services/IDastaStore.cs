namespace DnDepcheckerApi;

public interface IDastaStore<T>
{
    public Task Insert(T obj);
    public Task Update(T obj);
    public Task Delete(T obj);
    public Task Upsert(T obj);

    public Task<IEnumerable<T>> GetAll();
    
}
