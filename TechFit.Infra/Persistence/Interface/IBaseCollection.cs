using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Application.Services.Interfaces
{
    public interface IBaseCollection<T>
    {
        int Create(T obj);
        ICollection<T> GetAll();
        T? GetById(int id);
        void Update(int id, T obj);
        void Delete(int id);
    }

}