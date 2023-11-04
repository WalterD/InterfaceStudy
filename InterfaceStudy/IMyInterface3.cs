namespace InterfaceStudy
{
    // An interface must be implemented. Decorating an interface with "sealed" modifier generates an error.
    sealed interface IMyInterface3
    {
        private List<int> GetValues(); // "private" decorator is not allowed.
    }
}
