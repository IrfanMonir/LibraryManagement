using AutoMapper;

using LibraryManagement.Application.Common.Models;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;

using MediatR;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Books.Command
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, Result>
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;
        public CreateBookHandler(IBookService bookService,IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }
        public async Task<Result> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);
            var result = await _bookService.AddAsync(book);
            return result;
        }
    }
}
