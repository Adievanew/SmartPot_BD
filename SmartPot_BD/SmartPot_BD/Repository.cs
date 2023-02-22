using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPot_BD
{
    public class Repository
    {
        SQLiteConnection database;
        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<DB>();
        }
        public IEnumerable<DB> GetItems()
        {
            return database.Table<DB>().ToList();
        }
        public DB GetItem(int id)
        {
            return database.Get<DB>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<DB>(id);
        }
        public int SaveItem(DB item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
