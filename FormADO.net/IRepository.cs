﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormADO.net
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
