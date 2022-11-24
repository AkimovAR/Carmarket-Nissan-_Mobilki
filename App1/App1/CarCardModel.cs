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
    }
}
