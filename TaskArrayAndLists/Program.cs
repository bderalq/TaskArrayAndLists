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

// check if an item exists in the arraylist and print it 

Console.WriteLine("Enter item :");
string checker = Console.ReadLine();

if (groceries.Contains(checker))
{
    Console.WriteLine(checker + " exists in the list");
} else { Console.WriteLine(checker + " does not exist in the list ");
}

Console.WriteLine("----------------------");

// find the index of an item and print it 

Console.WriteLine("Check index of an item. Enter item :");
string checktwo = Console.ReadLine();

if (groceries.Contains(checktwo))
{
    Console.WriteLine("index of " + checktwo + " in the list is = " + groceries.IndexOf(checktwo));

}
else { Console.WriteLine(checktwo + "does not exist in the list."); 
}

Console.WriteLine("----------------------");

// count number of elements in the array 

Console.WriteLine("number of elements in the array list is = " + groceries.Count);

// bonus 

ArrayList threshold = new ArrayList() {10, 20, 30, 40, 50, 60};

Console.WriteLine("Enter new number");
int number = Convert.ToInt32(Console.ReadLine());

ArrayList newarray = new ArrayList();

foreach (int elements in threshold) { 
   
    if (number > elements)
    {
        newarray.Add(number);
        return;
    }
}
foreach(var elements in newarray) { Console.WriteLine(elements); }    
