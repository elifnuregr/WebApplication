using DataLayer.Context;
using DomainLayer.Interface;
using DomainLayer.Models;

namespace DataLayer.Repository
{
  public class ParameterRepository: GenericRepository<Parameter>, IParameterRepository
    {
        public ParameterRepository(StajProjeContext context) : base(context) 
        {
        } 
    }
}
