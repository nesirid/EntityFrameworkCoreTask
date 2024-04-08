using EntityFreamworkAppTask.Data;
using EntityFreamworkAppTask.Services;
using EntityFreamworkAppTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Threading.Tasks;

namespace EntityFreamworkAppTask.Controllers
{
    internal class SettingController
    {
        private readonly ISettingService _settingServices;
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
            _settingServices = new SettingService(_context);

        }
        public async Task GetAllAsync()
        {
            var datas = await _settingServices.GetAllAsync();
            if (datas != null)
            {
                foreach (var item in datas)
                {
                    string data = $"Name: {item.Name}, Email: {item.Email}, Phone: {item.Phone}, Address: {item.Address}";
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("No settings found.");
            }
        }
        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add setting id:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                var data = await _settingServices.GetByIdAsync(id);
                if (data != null)
                {
                    string result = $"Name: {data.Name}, Email: {data.Email}, Phone: {data.Phone}, Address: {data.Address}";
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Setting not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid setting id.");
            }

        }


    }

}
