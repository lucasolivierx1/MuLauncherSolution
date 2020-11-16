using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.domain.errors
{
   public abstract class Errors : Exception{

        public Errors() : base() { }
        public Errors(String pMsg) : base(pMsg) { }
    }

    public class RegWriteError : Errors {

        public RegWriteError(String pMsg): base(pMsg) { 
        
        }
   
    }
}
