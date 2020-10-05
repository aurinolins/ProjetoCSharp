using app02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app02.Services
{
    public class TituloService
    {
        private readonly app02Context _Context;

        public TituloService(app02Context context)
        {
            _Context = context;
        }
    }
}
