using testapicore6.Data;
using testapicore6.Models;

namespace testapicore6.Repositories
{
    public interface ItestRepository
    {
        public Task<List<TestModel>>getAllTestsAsync();
        public Task<TestModel> getTestsAsync(int id);
        public Task<int> AddTestsAsync(TestModel model);
        public Task UpdateTestsAsync(int id, TestModel model);
        public Task DeleteTestsAsync(int id);
    }
}
