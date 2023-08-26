using AutoMapper;
using Microsoft.EntityFrameworkCore;
using testapicore6.Data;
using testapicore6.Models;

namespace testapicore6.Repositories
{
    public class TestRepository : ItestRepository
    {
        private UserStoreContext _context;
        private readonly IMapper _mapper;

        public TestRepository(UserStoreContext context ,IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public Task<int> AddTestsAsync(TestModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTestsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TestModel>> getAllTestsAsync()
        {
            var users = await _context.tests!.ToListAsync();
            return _mapper.Map<List<TestModel>>(users);
        }

        public Task<TestModel> getTestsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTestsAsync(int id, TestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
