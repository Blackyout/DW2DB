using System;
using System.Data.Entity;
using DataBase.Migrations;

namespace DataBase
{
    public class DB : IDisposable
    {
        public DB()
        {   
            //Установка инициализатора
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DW2DBContext, Configuration>());
            dw2DbContext = new DW2DBContext();
        }


        public DW2DBContext dw2DbContext { get; set; }


        public void Dispose()
        {
            dw2DbContext.Dispose();
        }
    }
}
