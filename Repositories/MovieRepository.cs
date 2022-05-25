using ApiMinimaLogin.Models;

namespace ApiMinimaLogin.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Filme1", Description = "texte descrição do filme 1", Rating = 6.8 },
            new() { Id = 2, Title = "Filme2", Description = "texte descrição do filme 2", Rating = 8.2 },
            new() { Id = 3, Title = "Filme3", Description = "texte descrição do filme 3", Rating = 6.6 },
            new() { Id = 4, Title = "Filme4", Description = "texte descrição do filme 4", Rating = 6.4 },
            new() { Id = 5, Title = "Filme5", Description = "texte descrição do filme 5", Rating = 7.4 },
        };
    }
}
