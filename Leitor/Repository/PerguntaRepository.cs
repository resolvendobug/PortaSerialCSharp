using Dapper;
using Leitor.DB;
using Leitor.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor.Repository
{
    public class PerguntaRepository : IPerguntaRepository
    {
        private DBase _db;
        public PerguntaRepository(DBase db)
        {
            _db = db;
        }

        public async Task<List<Pergunta>> LoadData()
        {
            
            var listaPergunta = new List<Pergunta>();
            IDbConnection db = _db.GetConnection();
           // using (IDbConnection db = _db.GetConnection())
          //  {
                listaPergunta = (db.Query<Pergunta>("Select * from Pergunta").ToList());
           //  }
           

            return listaPergunta;

        }

        public bool Insert(Pergunta pergunta)
        {
            
            using (IDbConnection db = new DBase().GetConnection())
            {
                string numeroPergunta = pergunta.numeroPergunta;

                string dadosPergunta = pergunta.dadosPergunta;
                string dadosResposta = pergunta.dadosResposta;
                int n = db.Execute("insert into Pergunta (NumeroPergunta,dadosPergunta,dadosResposta)" +
                    "values(@numeroPergunta,@dadosPergunta,@dadosResposta)", new { NumeroPergunta = numeroPergunta, dadosPergunta = dadosPergunta,
                    dadosResposta = dadosResposta });

                if (n > 0)
                {
                 
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            using (IDbConnection db = new DBase().GetConnection())
            {
                int n = db.Execute("delete from pergunta where id=@id", new { id = id });

                if (n > 0)
                {
               
                    return true;

                }
            }
            return false;
        }

        public bool Update(int id,Pergunta pergunta)
        {
            using (IDbConnection db = new DBase().GetConnection())
            {
                int n = db.Execute("update pergunta set NumeroPergunta=@NumeroPergunta , dadosPergunta=@dadosPergunta ," +
                    "dadosResposta = @dadosResposta " +
                    " where id=@id", new { id = id, NumeroPergunta = pergunta.numeroPergunta, dadosPergunta = pergunta.dadosPergunta ,
                       dadosResposta = pergunta.dadosResposta  });

                if (n > 0)
                {
                    LoadData();
                    return true;
                }
            }
            return false;
        }
    }
}
