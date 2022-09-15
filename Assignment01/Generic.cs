    namespace Assignment01;

    public class Generic{
    
        public static int GreaterCount<T, U> (IEnumerable<T> items, T x) where T : IComparable<T>{
            int result = 0;
            
           foreach (IComparable item in items){
            if (item.CompareTo(x) == 1){
                result++;
            }
           }
           return result;
        }

         public static int GreaterCount2<T, U> (IEnumerable<T> items, T x) 
         where T : U
         where U : IComparable<U>
        {

            int result = 0;
            
           foreach (IComparable item in items){
            if (item.CompareTo(x) == 1){
                result++;
            }
           }
           return result;
        }
    }
