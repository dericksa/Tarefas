using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo;

namespace Desktop.Controllers
{
    public class TarefaController
    {
        public static void Criar_Tarefa(string titulo)
        {
            try
            {
                Tarefa t = new Tarefa();
                t.Titulo = titulo;
                t.Finalizada = false;
                pnTarefa.Inserir_Tarefa(t);  
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Finalizar_Tarefa(int id)
        {
            try
            {
                Tarefa t = pnTarefa.Pesquisar_Tarefa(id);
                t.Finalizada = true;
                pnTarefa.Editar_Tarefa(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Desfazer_Finalizar(int id)
        {
            try
            {
                Tarefa t = pnTarefa.Pesquisar_Tarefa(id);
                t.Finalizada = false;
                pnTarefa.Editar_Tarefa(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remover_Tarefa(int id)
        {
            try
            {
                Tarefa t = pnTarefa.Pesquisar_Tarefa(id);
                pnTarefa.Remover_Tarefa(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Tarefa> Listar_Pendentes()
        {
            try
            {
                List<Tarefa> todas_tarefas = new List<Tarefa>();
                List<Tarefa> pendentes = new List<Tarefa>();
                todas_tarefas = pnTarefa.Retornar_Tarefas();

                foreach(Tarefa t in todas_tarefas)
                {
                    if (!t.Finalizada)
                    {
                        pendentes.Add(t);
                    }
                }

                return pendentes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Tarefa> Listar_Finalizadas()
        {
            try
            {
                List<Tarefa> todas_tarefas = new List<Tarefa>();
                List<Tarefa> finalizadas = new List<Tarefa>();
                todas_tarefas = pnTarefa.Retornar_Tarefas();

                foreach (Tarefa t in todas_tarefas)
                {
                    if (t.Finalizada)
                    {
                        finalizadas.Add(t);
                    }
                }

                return finalizadas;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
