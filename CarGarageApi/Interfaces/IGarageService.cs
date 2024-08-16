using CarGarageApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarGarageApi.Interfaces
{
    public interface IGarageService
    {
        public Task<IEnumerable<Garage>> GetAllGarages();
        public Task<Garage> GetGarageById(int id);
        public Task<Garage?> AddGarage(Garage garage);
        public Task<bool> DeleteGarage(int id);

    }
}
