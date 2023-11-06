    string[] now = Console.ReadLine().Split();
    int cooking = Convert.ToInt32(Console.ReadLine());

    int a = int.Parse(now[0]);
    int b = int.Parse(now[1]) + cooking;

for(int i = b; b >= 60; i++)
 {           
           a = a +1;
           b = b - 60;
           
   if(a==24)
            {a = 0;}
}    
    Console.WriteLine($"{a} {b}");   