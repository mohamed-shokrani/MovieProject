using Serenity.Navigation;
using System.Drawing;
using MyPages = MovieProject.MovieDB.Pages;
[assembly: NavigationMenu(9000, "MovieDB", icon: "fa-camera")]

[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie", typeof(MyPages.MoviePage), icon: "fa-video-camera  ")]
//[assembly: NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(MyPages.GenrePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(MyPages.GenrePage), icon: "fa-thumb-tack")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie Genres", typeof(MyPages.MovieGenresPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Person", typeof(MyPages.PersonPage), icon: "fa-users")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie Cast", typeof(MyPages.MovieCastPage), icon: null)]
