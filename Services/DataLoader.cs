using PetsAlone.Models;
using PetsAlone.ServiceContracts;

namespace PetsAlone.Services
{
    public class DataLoader : IDataLoader
    {
        public Task<List<Pet>> LoadPetsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
