using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accounting.Dto.Response;
using Accounting.Dto.Request;
using Accounting.Dto.Response;


namespace Accounting.Services.Interfaces
{
    public interface IBankService
    {
        Task<BaseResponseGeneric<ICollection<BankResponseDto>>> GetAsync();
        Task<BaseResponseGeneric<BankResponseDto>> GetAsync(int id);
        Task<BaseResponseGeneric<int>> AddAsync(BankRequestDto request);
        Task<BaseResponse> UpdateAsync(int id, BankRequestDto request);
        Task<BaseResponse> DeleteAsync(int id);

    }
}
