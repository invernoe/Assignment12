# Table Comparison
| Collection                | Structure                     | Access            | Insertion at End    | Insertion/Deletion at Start/Middle | Search             |
|---------------------------|-------------------------------|-------------------|---------------------|------------------------------------|--------------------|
| ArrayList                 | Dynamic array (non-generic)   | O(1)              | O(1) (O(n) if we reach capacity)      | O(n)                               | O(n)               |
| List<T>                   | Dynamic array (generic)       | O(1)              | O(1) (O(n) if we reach capacity)      | O(n)                               | O(n)               |
| LinkedList<T>             | Doubly linked list            | O(n)              | O(1)                | O(1)                               | O(n)               |
| Stack<T>                  | LIFO array                    | O(1)              | O(1)                | N/A                                | N/A                |
| Queue<T>                  | FIFO array                    | O(1)              | O(1)                | N/A                                | N/A                |
| Hashtable                 | Key/value pairs (non-generic) | O(1) avg, O(n) worst | O(1) avg, O(n) worst | O(1) avg, O(n) worst                | O(1) avg, O(n) worst |
| Dictionary<TKey, TValue>  | Key/value pairs (generic)     | O(1) avg, O(n) worst | O(1) avg, O(n) worst | O(1) avg, O(n) worst                | O(1) avg, O(n) worst |

# When to Use Each Collection

## ArrayList (Or any non-generic Collection data structure that is available)
- Store heterogeneous types in a Collection

## List<T>
- When access speed matters more than insertion speed

## LinkedList<T>
- When insertion speed matters more than access speed

## Stack<T>
- To have a collection that implements Last in First out (LIFO)

## Queue<T>
- To have a collection that implements First in First out (FIFO)

## Dictionary<TKey, TValue>
- Storing key value pairs with a unique key, and when you want to quickly search for an item based on key