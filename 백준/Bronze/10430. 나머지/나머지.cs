         string[] num = Console.ReadLine().Split(' ');
            double A = double.Parse(num[0]);
            double B = double.Parse(num[1]);
            double C = double.Parse(num[2]);

            Console.WriteLine((A + B)%C);
            Console.WriteLine((A%C + B%C)%C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine((A % C) * (B % C) % C);