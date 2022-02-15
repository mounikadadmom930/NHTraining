using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MounikaLibrary;
//***************************************
//Author:paluru mounika
//purpose:using Access modifiers
//****************************************

namespace PublicLibrary
{
    /// <summary>
    /// using mypubliclibraryclass method
    /// </summary>
    public class MyPublicLibraryDerivedClass:MyBaseClass1
    {
        public void MyPublicLibraryDerivedClassMethod()
        {
            a = 3;
            b = 5;
            c = 6;  
            d = 7;  
            e = 8;  
            f = 9;  

        }
    }
    /// <summary>
    /// using mypubliclibraryotherclass method
    /// </summary>
    public class MyPublicOtherClass:MyBaseClass1 
    {
        public void MyPublicOtherClassMethod()
        {
            MyBaseClass1 mb = new MyBaseClass1();
            mb.a = 1;   
            mb.b = 2;   
            mb.c = 3;   
            mb.d = 4;   
            mb.e = 5;   
            mb.f = 6;   

        }
    }
}
