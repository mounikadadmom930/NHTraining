using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//****************************************
//Author:paluru mounika
//Purpose:physics class
//****************************************

namespace PublicLibrary
{
    public static class Physics
    {
        public static int FinalVelocity(int u, int a,int t)
        {
            return u + a + t;   
        }
    }
}
