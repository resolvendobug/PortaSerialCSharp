using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Leitor.Entity;

namespace Leitor.DB
{
    public class DBase
    {

        protected IDbConnection dbConnection;

        public DBase()
        {
            Connect();
            if (!File.Exists("Question.db"))
            {
                CreateDataBase();
            }
            
        }

        public IDbConnection GetConnection()
        {
            return this.dbConnection;
        }

        private void CreateDataBase()
        {
            using (IDbConnection db = GetConnection())
            {
                db.Execute("Create table Pergunta(ID INTEGER PRIMARY KEY AUTOINCREMENT,NumeroPergunta varchar(5),DadosPergunta varchar(500),DadosResposta varchar(500))");
             
            }
            Connect();

        }

        private void Connect()
        {
            dbConnection = new SQLiteConnection(@"Data Source=Question.db;Version=3;New=true");
        }
       

        
    }
}
