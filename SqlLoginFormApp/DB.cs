using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLoginFormApp
{
    class DB
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;" +
                                                                "port=3306;" +
                                                                "username=root;" +
                                                                "password=root;" +
                                                                "database=logindb; SSL Mode=0");

        public void SetConnectionOpenToDb()
        {
            if(mySqlConnection.State == System.Data.ConnectionState.Closed) // Если не подключены к БД - открыть соединение
            {
                mySqlConnection.Open();
            }
        }

        public void SetConnectionCloseToDb()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open) // Если подключены к БД - закрыть соединение
            {
                mySqlConnection.Close();
            }
        }

        public MySqlConnection getConnection() // Получаем статус соединения
        {
            return mySqlConnection;
        }
    }
}
