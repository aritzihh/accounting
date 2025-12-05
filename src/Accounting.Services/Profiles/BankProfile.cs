using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.Dto.Request;
using Accounting.Dto.Response;
using Accounting.Entities;
using AutoMapper;

namespace Accounting.Services.Profiles
{
    public class BankProfile : Profile
    {

        public BankProfile()
        {
            CreateMap<Bank, BankResponseDto>();
            CreateMap<BankRequestDto, Bank>();
        }

    }
}
