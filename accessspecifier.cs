using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
        public class ASpec
        {

            public int publicvar = 10;
            private int privatevar = 20;
            protected int protectedvar = 30;
            internal int internalvar = 40;
            protected internal int protectedinternalvar = 50;


            public void demo()
            {
                Console.WriteLine("This is public specifier");
                Console.WriteLine("Public Variable :" + publicvar);
                Console.WriteLine("Private Variable :" + privatevar);
                Console.WriteLine("protected Variable :" + protectedvar);
                Console.WriteLine("Internal Variable :" + internalvar);
                Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
            }
            private void demo1()
            {
                Console.WriteLine("This is private specifier");
                Console.WriteLine("Public Variable :" + publicvar);
                Console.WriteLine("Private Variable :" + privatevar);
                Console.WriteLine("protected Variable :" + protectedvar);
                Console.WriteLine("Internal Variable :" + internalvar);
                Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);

            }

            protected void demo2()
            {
                Console.WriteLine("This is protected specifier");
                Console.WriteLine("Public Variable :" + publicvar);
                Console.WriteLine("Private Variable :" + privatevar);
                Console.WriteLine("protected Variable :" + protectedvar);
                Console.WriteLine("Internal Variable :" + internalvar);
                Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
            }
            internal void demo3()
            {
                Console.WriteLine("This is internal specifier");
                Console.WriteLine("Public Variable :" + publicvar);
                Console.WriteLine("Private Variable :" + privatevar);
                Console.WriteLine("protected Variable :" + protectedvar);
                Console.WriteLine("Internal Variable :" + internalvar);
                Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
            }
            protected internal void demo4()
            {
                Console.WriteLine("This is protected internal specifier");
                Console.WriteLine("Public Variable :" + publicvar);
                Console.WriteLine("Private Variable :" + privatevar);
                Console.WriteLine("protected Variable :" + protectedvar);
                Console.WriteLine("Internal Variable :" + internalvar);
                Console.WriteLine("Protected Internal Variable :" + protectedinternalvar);
            }

        }
}
