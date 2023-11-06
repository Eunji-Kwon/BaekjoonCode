    string[] time = Console.ReadLine().Split();

    int h = int.Parse(time[0]);
    int m = int.Parse(time[1]) - 45;


        if(m<0)
        { if(h==0){h = 24;}
          
            h = h -1;
            m = 60 + m;
        }    
    Console.WriteLine($"{h} {m}");   