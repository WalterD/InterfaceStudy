namespace InterfaceStudy
{
    public interface IMyInterface2
    {
        /*
         NOTE

        In C# versions earlier than 8.0, an interface is like an abstract base class with only 
        abstract members. A class or struct that implements the interface must implement all its members.
        
        Beginning with C# 8.0, an interface may define default implementations for some or all of its members. 
        A class or struct that implements the interface doesn't have to implement members that have 
        default implementations. For more information, see default interface methods.
         */
        public int GetValue() 
        {
            return 1;
        }

        public static int GetValue2()
        {
            return 1;
        }
    }
}
