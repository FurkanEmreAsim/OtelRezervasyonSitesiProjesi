using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoseidonDeluxeCore.DataAccess.EntityFramework
{
    public class ContextCreater<TContext> where TContext : class,new()
    {
        private static TContext context;

        public static TContext GetContext
        {
            get
            {
                if (context == null)
                {
                    context = new TContext();
                }

                return context;
            }
        }

    }

}

