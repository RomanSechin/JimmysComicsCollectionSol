using System.Collections.Generic;
using System.Linq;
internal class Program
{
    //Добавим в метод Main запрос LINQ, который работает точно так же, не считая того, что он
    //использует объекты Comic вместо значений int, чтобы на консоль выводился список комиксов
    //с ценой >500 в обратном порядке.
    private static void Main(string[] args)
    {
        var mostExpensive =
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 500
            orderby -Comic.Prices[comic.Issue] //descending
            select comic;

        foreach (Comic comic in mostExpensive) {
            Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
        }
    }
}