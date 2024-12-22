using System.Collections;

// task 2 : create an array list containing grocery items. 

ArrayList groceries = new ArrayList() {"apple", "banana", "cherry", "soap"};

// task 2 : print the elements within the arrray containing groceries. 
foreach (var item in groceries)
{
    Console.WriteLine(item);   
}
Console.WriteLine("----------------------");
// task 3 : ArrayList Methods 

// insert orange at index 2 
groceries.Insert(2, "orange");

// remove one element 
groceries.Remove("cherry");

// check if banana exists in the arraylist and print it 

if (groceries.Contains("banana"))
{
    foreach (var item in groceries)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("banana exists in the list");
}

Console.WriteLine("----------------------");

// find the index of apple and print it 

Console.WriteLine("index of apple in the list is = " + groceries.IndexOf("apple"));

Console.WriteLine("----------------------");

// count number of elements in the array 

Console.WriteLine("number of elements in the array list is = " + groceries.Count);

