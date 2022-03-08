using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebMVC.Models;

namespace WebMVC.DAO
{
    public class SeriesDAO
    {
        private readonly CatalogoBDEntities bd;

        public SeriesDAO()
        {
            bd = new CatalogoBDEntities();
        }

        //Método que lista todas as séries
        public IEnumerable<Series> ListarSeries()
        {
            var series = bd.Series.ToList();
            return series;
        }

        //Método que cadastra uma nova série
        public void CadastrarSerie(Series serie)
        {
            bd.Series.Add(serie);
            bd.SaveChanges();
        }

        //Método que lista série por id
        public Series ListarPorId(int id)
        {
            Series serie = bd.Series.Find(id);
            return serie;
        }

        //Método que edita a série
        public void EditarSerie(Series serie)
        {
            bd.Entry(serie).State = EntityState.Modified;
            bd.SaveChanges();
        }

        //Método que exclui a série
        public void ExcluirSerie(Series serie)
        {
            bd.Series.Remove(serie);
            bd.SaveChanges();
        }
    }
}