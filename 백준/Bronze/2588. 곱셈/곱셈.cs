 int line_one = Convert.ToInt32(Console.ReadLine());
            int line_two = Convert.ToInt32(Console.ReadLine());
           
            int a = line_one * (line_two % 10);
            int b = line_one * ((line_two/10)%10);
            int c = line_one * (line_two / 100);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a +10*b+ 100*c);