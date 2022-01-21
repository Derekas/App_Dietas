using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    public class DataBase
    {
        public static SQLiteAsyncConnection ConnectioDatabase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

        static DataBase()
        {
            /*ConnectioDatabase.DropTableAsync<Dieta>().Wait();
            ConnectioDatabase.DropTableAsync<Comida>().Wait();
            ConnectioDatabase.DropTableAsync<CategoriaComida>().Wait();*/

            ConnectioDatabase.CreateTableAsync<Dieta>().Wait();
            ConnectioDatabase.CreateTableAsync<Comida>().Wait();
            ConnectioDatabase.CreateTableAsync<CategoriaComida>().Wait();
        }
    }
}
