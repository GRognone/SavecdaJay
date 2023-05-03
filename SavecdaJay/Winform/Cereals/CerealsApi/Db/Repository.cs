using CerealsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CerealsApi.Db
{
    public class Repository<T> where T : Model // par convention T pour type
    {

        private DbContext ctx; // par convention ctx pour contexte
        private DbSet<T> items;

        public Repository(DbContext contexte)
        {
            ctx = contexte;
            items = ctx.Set<T>)();
        }

    }
}
