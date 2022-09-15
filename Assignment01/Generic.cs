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


    /* Explaination: 
The two classes, here referred to as GreaterCount and GreaterCount2, have a few differences, due to type constraints.
First off, GreaterCount has only one type constraint, which is “where T : IComparable<T>”.
This means that type T, must either be or implement the interface IComparable<T>, where T is its own type. This meams it must have a
compareTo() method, where it can be compared to other object of the same class. 

For our method ”GreaterCount<T, U>(IEnumerable<T> items, T x)”, this means that the objects in our Enumerable list “items” must be of,
and be able to be compared to, the given type T. Since our x must also be of, and be able to be compared to, the given type T,
we can now safely implement the compareTo method in our execution, as shown above. The type U has no bearing on anything,
as it is not used elsewhere in the method signature. Therefore, we can pass any object type, including the slim Generic type. 
And as seen in the tests it changes nothing. 

In our GreaterCount2 method, we have two type constraints, which are “where T : U” and “where U : IComparable<U>”.
First off, “where T : U” means that T must either be, or be a subclass of, type U. So whatever type U we give, T must be a subclass of it, or the same type.
Second, “where U : IComparable<U>” means the same thing as “where T : IComparable<T>”, but for the type U of course.
Since T must be of type, or be a subclass of, U, and subclasses must implement all interfaces of the parent,
this all means that T must also implement IComparable<U>, and therefore be able to be compared to type U.
In practice, this means that the given type T must be comparable to the given type U, which must either be the same type as T, or a parent of T.
Therefore, T must be comparable to itself, and possibly any parent of T we might give as U. All in all, we can still safely use our compareTo method in our execution.

    
    */

