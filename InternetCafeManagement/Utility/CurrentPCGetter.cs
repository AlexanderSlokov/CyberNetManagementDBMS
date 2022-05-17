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

        private static Computer computer;

        public static Computer Computer { get => computer; set => computer = value; }

        private CurrentPCGetter()
        {
        }
        public void StopPC()
        {
            computer = null;
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
            Computer = computer;
        }
        public Computer GetCurrentComputer()
        {
            return Computer;
        }
    }
}
