using EntityFreamworkAppTask.Data;
using EntityFreamworkAppTask.Models;
using EntityFreamworkAppTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace EntityFreamworkAppTask.Services
{
    internal class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService(AppDbContext context)
    {
        _context = context;
    }
        public int MyProperty { get; set; }
        public async Task CreateAsync(Setting setting)
        {
            await _context.Settings.AddAsync(setting);
            await _context.SaveChangesAsync();

        }
        
        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            return _context.Settings.FirstOrDefault(m=>m.Id == id);
        }

        public Task UpdateAsync(Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
