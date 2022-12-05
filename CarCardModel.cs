using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1
{
    public class CarCardModel
    {
        SQLiteConnection database;
        public CarCardModel(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<CarCard>();
            database.CreateTable<CarData>();
        }
        public IEnumerable<CarCard> GetItems()
        {
            return database.Table<CarCard>().ToList();
        }
        public CarCard GetItem(int id)
        {
            return database.Get<CarCard>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<CarCard>(id);
        }
        public int SaveItem(CarCard item)
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
        public IEnumerable<CarData> GetItems1()
        {
            return database.Table<CarData>().ToList();
        }
        public CarData GetItem1(int id)
        {
            return database.Get<CarData>(id);
        }
        public int DeleteItem1(int id)
        {
            return database.Delete<CarData>(id);
        }
        public int SaveItem1(CarData item)
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
