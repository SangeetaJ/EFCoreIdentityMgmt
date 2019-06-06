using AutoMapper;
using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DataAccess
{
    public class DataService
    {
        public readonly IdnDBContext idbContext;
        public readonly IMapper mapper;

        public DataService(IdnDBContext idbContext, IMapper mapper)
        {
            this.idbContext = idbContext;
            this.mapper = mapper;
        }
    }
}
