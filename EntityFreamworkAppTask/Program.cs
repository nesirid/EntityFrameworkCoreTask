using EntityFreamworkAppTask.Controllers;
using EntityFreamworkAppTask.Data;
using Microsoft.EntityFrameworkCore.Migrations;
using EntityFreamworkAppTask.Services;
using EntityFreamworkAppTask.Services.Interfaces;
using EntityFreamworkAppTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;




//var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

//using (var context = new AppDbContext(optionsBuilder.Options))
//{
//    var settingController = new SettingController(context);
//    await settingController.GetAllAsync();
//}

// void ConfigureServices(IServiceCollection services)
//{
//    services.AddControllers();
//    services.AddScoped<ICityService, CityService>();
//}







//void GetAllSettings()
//{
//    var datas = context.Settings.ToList();

//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.Address + " " + item.Phone + " " + item.Email);
//    }

//}
//void GetById(int id)
//{
//    var data = context.Settings.FirstOrDefault(m => m.Id == id);

//    Console.WriteLine(data.Address + " " + data.Phone + " " + data.Email);
//}



//GetAllSettings();

//Console.WriteLine("------------------------");

//GetById(2);












Console.WriteLine("Successfully");


