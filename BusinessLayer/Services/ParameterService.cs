using BusinessLayer.Interface;
using BusinessLayer.Models;
using DomainLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ParameterService:IParameterService
   
    { private IParameterRepository _parameterRepository;
        public ParameterService(IParameterRepository parameterRepository)
        {  
            _parameterRepository = parameterRepository;
        }
        public List<ParameterDTO> GetAllParameters()
        {
            List<ParameterDTO> parameterList = new List<ParameterDTO>();
            var dataList = _parameterRepository.GetAll();
            if (dataList != null && parameterList.Count > 0)
            {
                foreach (var parameter in dataList)
                {
                    ParameterDTO parameterDTO = new ParameterDTO();
                    parameterDTO.Id = parameter.Id;
                    parameterDTO.Name = parameter.Name;
                    parameterDTO.IsDeleted = parameter.IsDeleted;
                    parameterDTO.CreatedDate = parameter.CreatedDate;
                    parameterDTO.UpdatedDate = parameter.UpdatedDate;

                    parameterList.Add(parameterDTO);

                }
            }
            return parameterList;
        }
    }
}
