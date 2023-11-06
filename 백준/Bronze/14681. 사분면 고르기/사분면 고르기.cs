int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if(x>0){
    if(y>0){
        Console.WriteLine(1);
    }
    else if(y<0){
        Console.WriteLine(4);
    }
}
if(x<0){
    if(y>0){
        Console.WriteLine(2);
    }
    else if(y<0){
        Console.WriteLine(3);
    }
}