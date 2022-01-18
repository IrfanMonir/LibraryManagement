using LibraryManagement.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookService:IRepository<Book>
    {
    }
}
