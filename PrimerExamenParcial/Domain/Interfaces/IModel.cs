﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel <T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> Read();
    }
}
