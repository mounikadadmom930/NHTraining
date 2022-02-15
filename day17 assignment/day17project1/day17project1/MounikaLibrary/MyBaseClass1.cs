using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MounikaLibrary;
//***************************************************
//Author:paluru mounika
//Purpose:Using Access modifiers
//***********************************************************

namespace MounikaLibrary
{
    /// <summary>
    /// access modifiers with in class
    /// </summary>
    public class MyBaseClass1
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        int e;
        protected internal int f;
        public void MyBaseClass()
        {
            a = 11;
            b = 25;  
            c = 31;  
            d = 43;  
            e = 50;  
            f = 61;  

        }
    }
    /// <summary>
    /// methode for MyDerivedClass
    /// </summary>
    public class MyDerivedClass:MyBaseClass1
    {
        public void MyDerivedClassMethod()
        {
            a = 5;
            b = 7;
            c = 3;
            d = 8;
            e = 9;  
            f = 10; 

            
        }

    }
    /// <summary>
    /// method for MyDerivedClass
    /// </summary>
    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass1 mb=new MyBaseClass1(); 
            mb.a = 5;   
            mb.b = 2;   
            mb.c = 4;   
            mb.d = 3;   
            mb.e = 1;   
            mb.f = 6;   

        }

    }
}
