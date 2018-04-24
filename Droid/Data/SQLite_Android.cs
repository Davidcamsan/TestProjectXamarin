using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TestProjectXamarin.Data;
using System.IO;
using TestProjectXamarin.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]

namespace TestProjectXamarin.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);

            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
