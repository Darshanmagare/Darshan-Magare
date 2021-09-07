using System;


namespace AccessSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {

            ASpec cl1 = new ASpec();
            cl1.demo();
            //cl1.demo1(); // can not access or call private method out side its namespace
            //cl1.demo2();   // can not access or call private method out side its namespace
            //cl1.demo3(); // can not access or call private method out side its namespace
            //cl1.demo4(); // can not access or call private method out side its namespace
           

            int a = cl1.publicvar;
            //int b = c.privatevar; // can not access or call private method out side its classs
            //int d = c.protectedvar; ///can not access or call private method out side its classs
            int e = cl1.internalvar;
            int f = cl1.protectedinternalvar;
            
        }
    }
}
