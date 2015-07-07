﻿using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data.Repositories
{
    public class CinemaHallRepository : BaseRepository<CinemaHall>, ICinemaHallRepository
    {
        public CinemaHallRepository(CinemaDbContext context)
            : base(context)
        {

        }
    }
}
