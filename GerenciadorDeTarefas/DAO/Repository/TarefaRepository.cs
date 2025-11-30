using GerenciadorDeTarefas.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeTarefas.DAO.Repository
{
    internal class TarefaRepository
    {
        public DataBase DataBase { get; set; }

        public TarefaRepository(DataBase dataBase)
        {
            DataBase = dataBase;
        }

        public bool Save(Tarefa tarefa)
        {
            return true;
        }
    }
}
