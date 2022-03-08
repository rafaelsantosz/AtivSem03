using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebMVC.Models;

namespace WebMVC.DAO
{
    public class FilmesDAO
    {
        private readonly CatalogoBDEntities bd;

        public FilmesDAO()
        {
            bd = new CatalogoBDEntities();
        }

        //Método que lista todos os filmes
        public IEnumerable<Filmes> ListarFilmes()
        {
            var filmes = bd.Filmes.ToList();
            return filmes;
        }

        //Método que cadastra novo filme
        public void CadastrarFilme(Filmes filme)
        {
            bd.Filmes.Add(filme);
            bd.SaveChanges();
        }

        //Método que lista filme por id
        public Filmes ListarPorId(int id)
        {
            Filmes filme = bd.Filmes.Find(id);
            return filme;
        }

        //Método que edita o filme
        public void EditarFilme(Filmes filme)
        {
            bd.Entry(filme).State = EntityState.Modified;
            bd.SaveChanges();
        }

        //Método que exclui o filme
        public void ExcluirFilme(Filmes filme)
        {
            bd.Filmes.Remove(filme);
            bd.SaveChanges();
        }
    }
}