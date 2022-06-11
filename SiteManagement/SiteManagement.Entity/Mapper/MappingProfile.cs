using AutoMapper;
using SiteManagement.Entity.Dto;
using SiteManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, DtoAddress>().ReverseMap();
            CreateMap<Apartment, DtoApartment>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<InvoiceType, DtoInvoiceType>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<Role, DtoRole>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
        }
    }
}
