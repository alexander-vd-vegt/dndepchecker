using System.Linq.Expressions;
using LiteDB;
namespace DnDepcheckerApi;

public class DataStoreService<T> : IDastaStore<T>, IDisposable
{
    private readonly LiteDatabase _db;
    private readonly ILiteCollection<T> _collection; 
    public DataStoreService()
    {
        _db = new LiteDatabase("");
        _collection = _db.GetCollection<T>();
    }

    public Task Delete(T obj)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _db?.Dispose();
    }

    public Task<IEnumerable<T>> GetAll()
    {
        var all = _collection.FindAll();
        return Task.FromResult(all);
    }

    public Task Insert(T obj)
    {
        throw new NotImplementedException();
    }

    public Task Update(T obj)
    {
        throw new NotImplementedException();
    }

    public Task Upsert(T obj)
    {
        throw new NotImplementedException();
    }

    public async Task Select()
    {
        throw new NotImplementedException();
    }
}
