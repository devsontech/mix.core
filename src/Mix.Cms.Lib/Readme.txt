Scaffold-DbContext "Server=localhost;Database=mix_structure;UID=sa;Pwd=1234qwe@;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\Cms -force
dotnet ef dbcontext scaffold "Host=my_host;Database=my_db;Username=my_user;Password=my_pw" Npgsql.EntityFrameworkCore.PostgreSQL  -OutputDir Models\Cms\PostgreSQL -force
Add-Migration -Context MixCmsContext
Update-Database -Context MixCmsContext

remove ntext type
remove default value


// Clean Init Database

  delete from test_123.dbo.mix_page_module
  delete from test_123.dbo.mix_page
  delete from test_123.dbo.mix_module_data
  delete from test_123.dbo.mix_module
  delete from test_123.dbo.mix_theme
  delete from test_123.dbo.mix_template
  delete from test_123.[dbo].[mix_related_attribute_data]
  delete from test_123.dbo.mix_attribute_set_data
  delete from test_123.dbo.mix_attribute_set_value
  delete from test_123.dbo.mix_attribute_field
  delete from test_123.dbo.mix_attribute_set_data
  delete from test_123.dbo.mix_attribute_set

UnitOfWorkHelper<TDbContext>.InitTransaction(_context, _transaction, out TDbContext context, out IDbContextTransaction transaction, out bool isRoot);
try
{
    UnitOfWorkHelper<TDbContext>.HandleTransaction(result.IsSucceed, isRoot, transaction);
}
catch (Exception ex)
{
    return UnitOfWorkHelper<TDbContext>.HandleException<TView>(ex, isRoot, transaction);
}
finally
{
    if (isRoot)
    {
        //if current Context is Root
        context.Database.CloseConnection();transaction.Dispose();context.Dispose();
    }
}

--- Default ViewModel -----

[GeneratedController("api/v1/rest/{culture}/attribute-set-data/portal")]
public class DefaultViewModel
       : ViewModelBase<MixCmsContext, MixPage, DefaultViewModel>
{
    #region Properties

    #region Models

    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("specificulture")]
    public string Specificulture { get; set; }

    #endregion Models

    #region Views

    
    #endregion Views

    #endregion Properties

    #region Contructors

    public DefaultViewModel() : base()
    {
    }

    public DefaultViewModel(MixPage model, MixCmsContext _context = null, IDbContextTransaction _transaction = null) : base(model, _context, _transaction)
    {
    }

    #endregion Contructors

    #region Overrides
    
    #endregion Overrides
}