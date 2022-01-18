using LibraryManagement.Application.Common.Models;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Persistance;

using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly DapperContext _context;
        public BookService(DapperContext context)
        {
            _context = context;
        }


        public async Task<Result> AddAsync(Book entity)
        {
            using(var connevtion = _context.CreateConnection())
            {
                connevtion.Open();
                var sql = "INSERT INTO Books (BookName, Author) VALUES(@BookName, @Author); ";
                var result = await connevtion.ExecuteAsync(sql, entity);
                if (result > 0)
                    return Result.Success();
                return Result.Failure(new List<string> { "Data insert failed" });
            }
        }

        public Task<Result> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result> UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
