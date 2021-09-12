using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IBookRepository
    {
        Book Create(Book person);

        Book FindByID(long ID);

        List<Book> FindAll();

        Book Update(Book person);

        void Delete(long ID);

        bool Exists(long id);
    }
}
