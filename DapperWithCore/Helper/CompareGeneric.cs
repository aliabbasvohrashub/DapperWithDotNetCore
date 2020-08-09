namespace DapperWithCore.Helper
{
    public class CompareGeneric<T> //where T:Type
    {
        public bool CompareTypes(T x, T y)
        {
            return x.Equals(y);
        }
    }
}
