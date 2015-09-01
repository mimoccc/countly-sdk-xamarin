using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using countly_sdk_xamarin.Models;
using SmashIt;
using SQLite;
using Xamarin.Forms;

namespace countly_sdk_xamarin.Services
{
    public class DbService
    {
        static object locker = new object();

        SQLiteConnection database;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public DbService()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<Event>();
        }

        public IEnumerable<Event> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<Event>() select i).ToList();
            }
        }

        public IEnumerable<Event> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<Event>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
            }
        }

        public Event GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<Event>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem(Event item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Event>(id);
            }
        }
    }
}
