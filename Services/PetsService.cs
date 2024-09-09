using PetsAlone.Models;
using PetsAlone.ServiceContracts;

namespace PetsAlone.Services
{
    public class PetsService : IPetService
    {
        public Task AddPetAsync(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pet>> GetPetsAsync(string typeFilter, string sortOrder, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }
    }
}
