using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily
{
    public partial class App : Application
    {
        public static BaseRepository<Transaction>

            TransactionsRepo
        { get; private set; }


        public App(BaseRepository<Transaction> _transactionsRepo)
        {
            // Register Syncfusion Licence
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cXmVCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWH5ec3VXRWBcVUZ3WkM=");

            InitializeComponent();
            TransactionsRepo = _transactionsRepo;

            MainPage = new StatisticPage();
        }
    }
}