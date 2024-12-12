using System;

string[] data = GetDataFromFile();
List<Movie> list = new List<Movie>();

foreach (string line in data)
{
    string[] temparray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(temparray[0], temparray[2], temparray[1]);
    list.Add(newMovie);
}

foreach (Movie movie in list)
{
    Console.WriteLine($"One of my favorite movie {movie.title}  was released in {movie.year}.");
}

static string[] GetDataFromFile()
{
    string filePath = @"C:\Users\Lenovo\Desktop\movies.txt";
    return File.ReadAllLines(filePath);
}
class Movie
{
    public string title;
    public string rating;
    public string year;

    public Movie(string _title, string _rating, string _year)
    {
        title = _title;
        rating = _rating;
        year = _year;
    }
}