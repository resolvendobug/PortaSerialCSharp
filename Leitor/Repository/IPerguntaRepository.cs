using Leitor.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor.Repository
{
    interface IPerguntaRepository
    {
        public Task<List<Pergunta>> LoadData();

        public bool Insert(Pergunta pergunta);

        public bool Delete(int id);

        public bool Update(int id, Pergunta pergunta);

    }
}