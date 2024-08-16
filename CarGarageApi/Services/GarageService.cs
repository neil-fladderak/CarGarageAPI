using CarGarageApi.Interfaces;
using CarGarageApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarGarageApi.Services
{
    public class GarageService : IGarageService
    {
        private readonly GarageContext _context;
        public GarageService(GarageContext context) 
        {
            _context = context;
        }

        public async Task<Garage> GetGarageById(int id)
        {
            var garage = await _context.Garages.FindAsync(id);

            if (garage == null)
            {
                throw new ArgumentNullException($"The Garage you are looking for with ID: {id} does not exist.");
            }

            return garage;
        }

        public async Task<IEnumerable<Garage>> GetAllGarages() 
        {
            return await _context.Garages.ToListAsync();
        }

        public async Task<Garage?> AddGarage(Garage garage)
        {
            Garage g = new Garage(garage.Name, garage.Description);

            _context.Garages.Add(g);
            var result = await _context.SaveChangesAsync();

            return result >= 0 ? garage : null;
        }

        public async Task<bool> DeleteGarage(int id)
        {
            var garage = await _context.Garages.FirstOrDefaultAsync(index => index.Id == id);

            if (garage != null)
            {
                _context.Garages.Remove(garage);
                var result = await _context.SaveChangesAsync();
                return result >= 0;
            }
            else
            {
                return false; 
            }
        }
    }
}
