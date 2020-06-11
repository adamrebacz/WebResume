﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebResume.Models;

namespace WebResume.MVC.DataAccess.Repository.IRepository
{
    public interface IStringItemRepository : IRepository<StringItem>
    {
        void Update(StringItem stringItem);
    }
}
