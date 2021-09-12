using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book FindByID(long ID);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long ID);
    }
}
