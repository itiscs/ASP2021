﻿using DtoAppSecond.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoAppSecond.Data
{
    public class DtoDb : DbContext
    {
        public DtoDb(DbContextOptions<DtoDb> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
