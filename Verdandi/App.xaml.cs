using DAL;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace Verdandi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            using (var db = new DataContext())
            {
                db.Database.Migrate();
            }
        }
    }
}
