using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accounting.Dto.Response;
using Accounting.Dto.Request;
using Accounting.Dto.Response;
using Accounting.Entities;
using Accounting.Repositories.Interfaces;
using Accounting.Services.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Accounting.Services.Implementations
{
    public class BankService : IBankService
    {

        private readonly IBankRepository repository;
        private readonly ILogger<BankService> logger;
        private readonly IMapper mapper;

        public BankService(IBankRepository repository, ILogger<BankService> logger, IMapper mapper)
        {
            this.repository = repository;
            this.logger = logger;
            this.mapper = mapper;            
        }

        public async Task<BaseResponseGeneric<ICollection<BankResponseDto>>> GetAsync()
        {
            var response = new BaseResponseGeneric<ICollection<BankResponseDto>>();
            try
            {
                response.Data = mapper.Map<ICollection<BankResponseDto>>(await repository.GetAsync());
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Ocurrió un error al obtener la información";
                logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<BankResponseDto>> GetAsync(int id)
        {
            var response = new BaseResponseGeneric<BankResponseDto>();
            try
            {

                var data = await repository.GetAsync(id);
                response.Data = mapper.Map<BankResponseDto>(data);
                response.Success = data != null;

            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Ocurrió un error al obtener los datos.";
                logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<int>> AddAsync(BankRequestDto request)
        {
            var response = new BaseResponseGeneric<int>();
            Bank entity = new();
            try
            {
                entity = mapper.Map<Bank>(request);
                response.Data = await repository.AddAsync(entity);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Ocurrió un error al añadir la información.";
                logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }
        public async Task<BaseResponse> UpdateAsync(int id, BankRequestDto request)
        {
            var response = new BaseResponse();
            try
            {
                var data = await repository.GetAsync(id);
                if (data is null)
                {
                    response.ErrorMessage = "El registro no fue encontrado.";
                    return response;
                }

                mapper.Map(request, data);

                await repository.UpdateAsync();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Ocurrió un error al actualizar.";
                logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

        public async Task<BaseResponse> DeleteAsync(int id)
        {
            var response = new BaseResponse();
            try
            {
                var data = await repository.GetAsync(id);
                if (data is null)
                {
                    response.ErrorMessage = "El registro no fue encontrado.";
                    return response;
                }

                await repository.DeleteAsync(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Ocurrió un error al eliminar el registro.";
                logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

    }
}
