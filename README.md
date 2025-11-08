# Wolnelektury.cs
Web-API for [wolnelektury.pl](https://wolnelektury.pl/) a free library reaching children across Poland, offering required school readings and thousands of e-books and audiobooks.

## Example
```cs
using WolnelekturyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Wolnelektury();
            string books = await api.GetBooks();
            Console.WriteLine(books);
        }
    }
}
```
