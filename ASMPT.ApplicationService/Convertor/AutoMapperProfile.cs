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

                CreateMap<Author, CreateAuthorDto>();

                CreateMap<CreateAuthorDto, Author>()
         .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignore Id during mapping
         .ForMember(dest => dest.Book, opt => opt.MapFrom(src => MapBooks(src.Book))); // Map books

                CreateMap<CreateBookDto, Book>()
                    .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignore Id during mapping
                    .ForMember(dest => dest.Author, opt => opt.Ignore()); // Ignore Author during mapping
            


                CreateMap<CreateBookDto, Book>().ReverseMap();
                

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


        private static ICollection<Book> MapBooks(ICollection<CreateBookDto>? createBookDtos)
        {
            if (createBookDtos == null)
                return new List<Book>();

            return createBookDtos.Select(dto => new Book
            {
                Title = dto.Title,
                ISBN = dto.ISBN,
                
              
            }).ToList();
        }
    }
}
