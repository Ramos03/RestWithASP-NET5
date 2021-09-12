﻿using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);

        Person FindByID(long ID);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long ID);
    }
}
