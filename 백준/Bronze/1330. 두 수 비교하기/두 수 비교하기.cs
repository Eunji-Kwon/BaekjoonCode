string[] a =Console.ReadLine().Split();
if(int.Parse(a[0])>int.Parse(a[1])){
    Console.WriteLine('>');
}
else if (int.Parse(a[0])<int.Parse(a[1])){
    Console.WriteLine('<');

}
 else{
Console.WriteLine(@"==");
}