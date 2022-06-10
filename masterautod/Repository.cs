
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace masterautod
{
    public class Repository
    {
        SQLiteConnection database;
        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Water>();
            database.CreateTable<Weight>();
        }
        public IEnumerable<Water> GetItems()
        {
            return database.Table<Water>().ToList();
        }
        public Water GetItem(int id)
        {
            return database.Get<Water>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Water>(id);
        }
        public int SaveItem(Water item)
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

        public IEnumerable<Weight> GetWeightItems()
        {
            return database.Table<Weight>().ToList();
        }
        public Weight GetWeightItem(int id)
        {
            return database.Get<Weight>(id);
        }
        public int DeleteWeightItem(int id)
        {
            return database.Delete<Weight>(id);
        }
        public int SaveWeightItem(Weight item)
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