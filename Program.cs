using System;
using System.Collections.Generic;
using WebJobChollos.Models;
using WebJobChollos.Repositories;

namespace WebJobChollos
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryRss repo = new RepositoryRss();
            List<CholloRss> chollos = repo.GetChollos();

            //foreach (CholloRss chollo in chollos)
            //{
            //    Console.WriteLine(chollo.Titular);
            //}
            RepositoryBbdd repobbdd = new RepositoryBbdd();
            repobbdd.ActualizarChollos(chollos);
            //Console.WriteLine("Chollos actualizados en BBDD");
        }
    }
}
