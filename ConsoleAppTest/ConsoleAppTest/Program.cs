using ConsoleAppTest;
using ConsoleAppTest.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;


var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
   
    Flat bigFlat = new Flat { FloorApartment = 2, Balcony = false, Price = 4.500, RoomCount = 3 };
    Flat smallFlat = new Flat { FloorApartment = 1, Balcony = true, Price = 2.500, RoomCount = 2 };
    db.Flats.AddRange(bigFlat, smallFlat);
    Client tom = new Client { Name = "Tom", Surname = "Shelby", Phone = "+1337228", Email = "Tomas.Shelby2010", Address = "Grove Stree 35", City = "Minsk", Flat = bigFlat };
    Client alice = new Client { Name = "Alice", Surname = "Katya", Phone = "1488", Email = "Katya2022", Address = "Aliaska 45", City = "Minsk", Flat = smallFlat };
    
   
    db.Clients.AddRange(tom, alice);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    //получаем объекты из бд и выводим на консоль
    var clients = db.Clients.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Client u in clients)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Surname} - {u.Phone} - {u.Email} - {u.Address} - {u.City}");
    }


    var client = db.Clients.Include(y => y.Flat).ToList();
    foreach (var cli in client)
        Console.WriteLine($"{cli.Name} - {cli.Flat.Id} - {cli.Flat.RoomCount} - {cli.Flat.Floor}");
                       
}