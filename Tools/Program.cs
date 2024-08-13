using Tools.Context;
using Tools.Models;
using Tools.Repository;
using Tools.UnitOfWork;

namespace Tools;

public class Program
{
    
    public static void Main(string[] args)
    {
        using var context = new MyDbContext();
        var unitOfWork = new UnitOfWork.UnitOfWork(context);
        var beerRepository = new BeerRepository(context, unitOfWork);

        var beer = new Beer
        {
            Name = "Heineken",
            Style = "Pilsner"
        };

        beerRepository.AddAsync(beer).Wait();

        var beers = beerRepository.GetAllAsync().Result;
        foreach (var b in beers)
        {
            Console.WriteLine($"Id: {b.Id}, Name: {b.Name}, Style: {b.Style}");
        }

        beer.Name = "Budweiser";
        beerRepository.UpdateAsync(beer).Wait();

        beers = beerRepository.GetAllAsync().Result;
        foreach (var b in beers)
        {
            Console.WriteLine($"Id: {b.Id}, Name: {b.Name}, Style: {b.Style}");
        }

        beerRepository.DeleteAsync(beer).Wait();

        beers = beerRepository.GetAllAsync().Result;
        foreach (var b in beers)
        {
            Console.WriteLine($"Id: {b.Id}, Name: {b.Name}, Style: {b.Style}");
        }

    }
}