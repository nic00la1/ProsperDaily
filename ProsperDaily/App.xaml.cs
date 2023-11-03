using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily;

public partial class App : Application
{

    public static BaseRepository<Transaction>
         TransactionsRepo
    { get; private set; }

    public App(BaseRepository<Transaction> _transcationsRepo)
    {
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cWWBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWH5ec3VWR2hcUkxzW0c=");
        InitializeComponent();

        TransactionsRepo = _transcationsRepo;

        MainPage = new AppContainer();
    }
}
