using ContactWebModels;

namespace MyContactManagerServices
{
    public class StatesService :IStatesService
    {
        public async Task<IList<State>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<State?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddOrUpdateAsync(State state)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(State state)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}