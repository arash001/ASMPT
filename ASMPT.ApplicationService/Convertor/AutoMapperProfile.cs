using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ASMPT.ApplicationService.Convertor
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            try
            {
                CreateMap<StudentDto, Student>().ReverseMap();

                CreateMap<AuthorDto, Author>().ReverseMap();

                CreateMap<BookDto, Book>().ReverseMap();
                CreateMap<Borrow, BorrowViewModel>().ReverseMap();

                CreateMap<StudentViewModel, Student>().ReverseMap();
                CreateMap<StudentModel, Student>().ReverseMap().ReverseMap();

                CreateMap<BookViewModel, Book>().ReverseMap();
                CreateMap<Book, BookModel>().ReverseMap();

                CreateMap<Address, AddressDto>().ReverseMap();

                CreateMap<AddressDto, AddressViewModel>().ReverseMap();

                CreateMap<Address, AddressViewModel>().ReverseMap();

                CreateMap<Author, AuthorViewModel>()
           .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book));


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
