using Microsoft.Data.Sqlite;
using System;

namespace Slagalica
{
    class ConnectionDB
    {
        private static SqliteConnection instance = null;
        private static Object padlock = new Object();

        public static SqliteConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new SqliteConnection("Data Source=" + Properties.Resources.GameDataFileName + "; Mode=ReadWriteCreate");
                    }
                    return instance;
                }
            }
        }
    }
}