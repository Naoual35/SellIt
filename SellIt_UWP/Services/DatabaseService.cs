using SellIt_UWP.Entities;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SellIt_UWP.Services
{
    public class DatabaseService
    {
        private SQLiteConnection sqliteConnection;

        public SQLiteConnection SqliteConnection
        {
            get { return sqliteConnection; }
        }
        public TableQuery<Client> Clients
        {
            get { return this.sqliteConnection.Table<Client>(); }
        }

        public TableQuery<Seller> Sellers
        {
            get { return this.sqliteConnection.Table<Seller>(); }
        }

        public TableQuery<Order> Orders
        {
            get { return this.sqliteConnection.Table<Order>(); }
        }

        public List<Client> ClientsEager
        {
            get { return this.sqliteConnection.GetAllWithChildren<Client>(); }
        }

        public List<Seller> SellersEager
        {
            get { return this.sqliteConnection.GetAllWithChildren<Seller>(); }
        }

        public List<Order> OrdersEager
        {
            get { return this.sqliteConnection.GetAllWithChildren<Order>(); }
        }

        public DatabaseService()
        {
            Task.Factory.StartNew(async () =>
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                StorageFile myDb = await localFolder.CreateFileAsync("mydb.sqlite",
                        CreationCollisionOption.OpenIfExists);
                this.sqliteConnection = new SQLiteConnection(myDb.Path);
                this.sqliteConnection.CreateTable<Seller>();
                this.sqliteConnection.CreateTable<Client>();
                this.sqliteConnection.CreateTable<Order>();
            });
        }
    }
}

