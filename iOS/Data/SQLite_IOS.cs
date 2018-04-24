using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using TestProjectXamarin.Data;
using TestProjectXamarin.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace TestProjectXamarin.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }

    }
}
