using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odin_BD.Clases
{
    
    class ClsPintar
    {
        public List<ClsProcedimiento> ListaProcedimientos {get; set;}

        private string rutaPintar;
        public string RutaPintar
        {
            get { return rutaPintar; }
            set { rutaPintar = value; }
        }
        
                
        
    }
}
