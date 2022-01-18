using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Domain.Entities
{
    public class BookByMember
    {
        public int BookByMemberId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    }
}
