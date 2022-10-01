// See https://aka.ms/new-console-template for more information

//pre set int array list of 10 values
int[] list = { 1, 5, 6, 8, 9, 8, 9, 7, 2, 3};

//show the list unordered
Console.WriteLine("here the list unordered");

//foreachloop that take i and lis
foreach (int i in list)
{
    //i + list 
    Console.Write(i + " ");
}

//take any duplicates out of the array list 
int[] dist = list.Distinct().ToArray();
//keep the lis on he same line 
Console.WriteLine("\nSorted List");
//for loop that take the new list dist 
for (int i = 0; i < dist.Length; i++)
{
    //sorts he array 
    Array.Sort(dist);
    Array.Reverse(dist);
    //displays new array without the duplicates 
    Console.Write(dist[i] + " ");

}
   