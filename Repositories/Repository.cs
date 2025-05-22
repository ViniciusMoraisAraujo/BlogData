using BlogData.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogData.Repositories;

public class Repository<TModel> where TModel : class // classe de um tipo generico
{

    public Repository(SqlConnection connection)
    {
        Database.Connection = connection;
    }

    public IEnumerable<TModel> Get()
        => Database.Connection.GetAll<TModel>();

    public TModel Get(int id)
        => Database.Connection.Get<TModel>(id);

    public void Create(TModel insertModel)
        => Database.Connection.Insert(insertModel);

    public void Update(TModel updateModel)
        => Database.Connection.Update(updateModel);

    public void Delete(TModel deleteModel)
        => Database.Connection.Delete(deleteModel);

    public void Delete(int modelId)
    {
        var user = Database.Connection.Get<TModel>(modelId);
        Database.Connection.Delete(user);
    }
}