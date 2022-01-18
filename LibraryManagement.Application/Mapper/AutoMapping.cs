using AutoMapper;

using LibraryManagement.Application.DTOs;
using LibraryManagement.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Application.Mapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
        }
    }
}
