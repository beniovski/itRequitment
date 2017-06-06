using ItRequitment.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItRequitment.Infrastructure.Repositories
{
    public class DbReposiotory
    {
        protected DataBaseContext Dbc;

        public DbReposiotory()
        {
            Dbc = new DataBaseContext();
        }

    }
}