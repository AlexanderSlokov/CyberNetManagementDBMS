using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetCafeManagement.Model;

namespace InternetCafeManagement.Utility
{
    public class CurrentPCGetter
    {
        private static CurrentPCGetter _instance;

        private Computer computer; 
        private CurrentPCGetter(Computer computer)
        {
            this.computer = computer;
        }
        private CurrentPCGetter()
        {
        }
        public static CurrentPCGetter GetCurrentPCGetter()
        {
            if( _instance == null)
            {
                return new CurrentPCGetter();
            }
            else
            {
                return _instance;
            }
        }
        public void SetCurrentComputer(Computer computer)
        {
            this.computer = computer;
        }
        public Computer GetCurrentComputer()
        {
            return computer;
        }
    }
}
