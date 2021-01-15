using Serenity.Navigation;
using MyPages = Serene1.MovieDB.Pages;

[assembly: NavigationMenu(1000, "Movie Database", icon: "fa-database")]
[assembly: NavigationLink(1100, "Movie Database/Genres", typeof(MyPages.GenreController), icon: "fa-folder-open")]
[assembly: NavigationLink(1200, "Movie Database/Movies", typeof(MyPages.MovieController), icon: "fa-film")]
[assembly: NavigationLink(1300, "Movie Database/Person", typeof(MyPages.PersonController), icon: "fa-male")]
