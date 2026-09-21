namespace F26Week3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.myProtectedVar = 1;
            //objBase.myPublicVar = 1;

            DerivedClass objDerived = new DerivedClass("hello");
            ////objDerived.myProtectedVar = 1;
            //objDerived.myPublicVar = 2;
        }
    }
}
