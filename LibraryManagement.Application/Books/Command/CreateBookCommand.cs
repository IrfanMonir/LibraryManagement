using LibraryManagement.Application.Common.Models;

using MediatR;

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Application.Books.Command
{
    public class CreateBookCommand:IRequest<Result>
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }
}
