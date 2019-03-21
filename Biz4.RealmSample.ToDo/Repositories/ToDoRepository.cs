using System;
using System.Linq;
using Biz4.RealmSample.ToDo.Entities;
using Realms;

namespace Biz4.RealmSample.ToDo.Repositories
{

    public interface IToDoRepository
    {
        void Insert(RlmToDoItem item);
        IQueryable<RlmToDoItem> GetAll();
    }

    public class ToDoRepository : IToDoRepository
    {
        public readonly Realm realmInstance;

        public ToDoRepository()
        {
            try
            {
                var con = new RealmConfiguration("toDo.realm")
                {
                    MigrationCallback = (migration, oldSchemaVersion) => {

                    },
                    ShouldDeleteIfMigrationNeeded = true
                };
                System.Diagnostics.Debug.WriteLine(con.DatabasePath);
                realmInstance = Realms.Realm.GetInstance(con);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Insert(RlmToDoItem item)
        {
            realmInstance.Write(() =>
            {
                realmInstance.Add(item);
            });
        }

        public IQueryable<RlmToDoItem> GetAll()
        {
            return realmInstance.All<RlmToDoItem>();
        }
    }
}
