﻿using System.Data.Entity;

namespace MVCparcial.Models
{
    public class DataContext:DbContext
    
    {

        public DataContext():base("DefaultConnection")
        {

        }
    }
}