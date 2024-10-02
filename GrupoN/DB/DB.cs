using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoN.DB
{

    internal class DB
    {
        private readonly string _conection;
        public string Connetion => _conection;

        public DB {
            _connection = @"Server=DESKTOP-PRJRN6F\DBSERVER; Database=GrupoN; Trusted_Connection=true";
        }

        internal ObservableCollection<ProfesorModel> Get()
        {
        ObservableCollection<ProfesorModel> lastResult

        }

    }

}