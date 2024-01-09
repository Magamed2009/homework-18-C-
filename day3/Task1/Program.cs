var t = new Teacher();
t.fullName = Console.ReadLine();
t.subject = Console.ReadLine();
t.experience = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(t.Teach());