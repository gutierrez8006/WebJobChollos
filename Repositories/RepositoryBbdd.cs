using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobChollos.Data;
using WebJobChollos.Models;

namespace WebJobChollos.Repositories
{
    public class RepositoryBbdd
    {
        ChollosContext context;
        public RepositoryBbdd()
        {
            this.context = new ChollosContext();
        }

        public int GetMaxIdChollo()
        {
            var consulta = this.context.Chollos;
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else
            {
                return consulta.Max(z => z.IdChollo) + 1;
            }
        }

        public void ActualizarChollos(List<CholloRss> chollos)
        {
            int id = this.GetMaxIdChollo();
            foreach (CholloRss chollo in chollos)
            {
                CholloBbdd chollobbdd = new CholloBbdd();
                chollobbdd.IdChollo = id;
                chollobbdd.Fecha = DateTime.Now;
                chollobbdd.Titular = chollo.Titular;
                chollobbdd.Descripcion = chollo.Descripcion;
                chollobbdd.Categoria = chollo.Categoria;
                chollobbdd.Enlace = chollo.Enlace;
                id += 1;
                this.context.Chollos.Add(chollobbdd);
            }
            this.context.SaveChanges();
        }

    }
}
