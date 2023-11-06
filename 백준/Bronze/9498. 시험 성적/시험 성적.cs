double grade =Convert.ToDouble(Console.ReadLine());

if(grade <= 100 && grade >= 90){
    Console.WriteLine('A');
}
else if (grade <= 90 && grade >= 80){
    Console.WriteLine('B');
}
else if (grade <= 80 && grade >= 70){
    Console.WriteLine('C');
}
else if (grade <= 70 && grade >= 60){
    Console.WriteLine('D');
}
 else{
Console.WriteLine('F');
}