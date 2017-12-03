using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo
{
    public class pnTarefa
    {
        public static void Inserir_Tarefa(Tarefa t)
        {
            try
            {
                ListaTarefasBD db = new ListaTarefasBD();
                db.Tarefa.Add(t);

                db.SaveChanges();
                
            }
            catch(Exception)
            {
                throw;
            }
        }
         public static Tarefa Pesquisar_Tarefa(int id)
        {
            try
            {
                ListaTarefasBD db = new ListaTarefasBD();
                return db.Tarefa.Find(id);               
            }
            catch(Exception)
            {
                throw;
            }
        }



        public static void Editar_Tarefa(Tarefa t)
        {
            try
            {
                ListaTarefasBD db = new ListaTarefasBD();
                Tarefa tarefa_editada = db.Tarefa.Find(t.Id);

                tarefa_editada.Titulo = t.Titulo;
                tarefa_editada.Finalizada = t.Finalizada;

                db.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remover_Tarefa(Tarefa t)
        {
            try
            {
                ListaTarefasBD db = new ListaTarefasBD();
                Tarefa apagada = db.Tarefa.Find(t.Id);
                db.Tarefa.Remove(apagada);

                db.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Tarefa> Retornar_Tarefas()
        {
            try
            {
                ListaTarefasBD db = new ListaTarefasBD();
                return db.Tarefa.ToList();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
