using BlogData.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogData.Repositories;

public class Repository<TModel> where TModel : class // classe de um tipo generico
{
    private readonly SqlConnection _connection;

    public Repository(SqlConnection connection)
        => _connection = connection;

    public IEnumerable<TModel> Get()
        => _connection.GetAll<TModel>();

    public TModel Get(int id)
        => _connection.Get<TModel>(id);

    public void Create(TModel insertModel)
        => _connection.Insert(insertModel);

    public void Update(TModel updateModel)
        => _connection.Update(updateModel);

    public void Delete(TModel deleteModel)
        => _connection.Delete(deleteModel);

    public void Delete(int modelId)
    {
        var user = _connection.Get<TModel>(modelId);
        _connection.Delete(user);
    }
}