using System;

namespace P324_Array_String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array methods
            //int[] arr = { 1,-7,8,20, 2, 3, 4, 5,5};
            //int[] arr2 = (int[])arr.Clone();
            //int[] arr3 = { 6, 7, 8, 9, 10,11,12,13,14,15 };
            //arr2[0] = 9;
            //Console.WriteLine(arr[0]);

            //Array.Copy(arr, arr3,arr3.Length);

            //int number  = Array.Find(arr,x=>x==5);

            //int index = Array.FindLastIndex(arr,x=>x==5);

            //int index = Array.IndexOf(arr,111);

            //Console.WriteLine(index);

            //Console.WriteLine(number);

            //arr.CopyTo(arr3,2);

            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(arr.ToString());

            //int[] arr = { 1, 2, 3, 4, 5,9,20,30,50,55,82,32 };

            //Array.Resize(ref arr,arr.Length+1);

            //arr[5] = 999;
            //Console.WriteLine(arr[81238]);

            //bool result = Array.Exists(arr, x => x ==130);
            //Console.WriteLine(result);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region String methods
            //string str = "   Hello world whats up,world   ";
            //string str2 = "World";

            //Console.WriteLine(string.Concat(str, str2, "This"," ", "\nis", " ", "static", "values",1,5,10));\

            //bool result = str2.Contains("d") && str.Contains("o");

            //bool result = str.EndsWith("elo");

            //bool result = str.Equals(str2);

            //string formated = string.Format("Price: {0:c} {1:c} {2:n}",90,100,91293912200);

            string formated = string.Format("Date:  ₼100 {0:r}", new DateTime(2022, 4, 19));

            //int index = str.IndexOfAny(new char[] { 'z','a','b'});

            //string inserted = str.Insert(2," World");

            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("This is empty string");
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}

            //string removed = str.Remove(2,2);

            //string replaced = str.Replace("world", "P324");

            //string products = "Milk Coffee Tea Water Cola";
            //string[] strArr= products.Split();

            //foreach (var item in strArr)
            //{
            //    Console.WriteLine(item);
            //}

            //string joinResult  = string.Join("=>", strArr);

            //string subString = str.Substring(0,10) + "...";

            //Console.WriteLine(str.Trim().Length ) ;

            // Array method => Ismayil Genceli

            //Array.ForEach(strArr, x => Console.WriteLine(x));

            //Console.WriteLine(replaced);

            //string.Concat();
            #endregion

            //string student1Name = "Xalil";
            //string student1Surname = "Xalilbeyli";
            //byte age = 28;
            //string info = $"{student1Name} {student1Surname}";
            //Console.WriteLine(student1Name + " " + student1Surname + " " + age);

            Student student = new Student();
            student.Name = "Chingiz";
            student.Surname = "Rahimov";
            student.Age = 25;
            student.Gender = "Male";

            Student student1 = new Student();
            student1.Name = "Jamal";
            student1.Surname = "Samadov";
            student1.Age = 25;
            student1.Gender = "Male";

            Console.WriteLine(student.getInfo());

            Console.WriteLine("Name:{0}, Surname: {1}, Age: {2}", student.Name, student.Surname, student.Age);

            Student student2 = new Student();
            Console.WriteLine(student2.Name);

            Student student3 = new Student("Kamran","Gasimov",26);
            Console.WriteLine(student.getInfo());
        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;

        public Student(string name, string surname, byte age, string gender="Male")
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public Student()
        {

        }

        public string getInfo()
        {
            //return "Name:" + Name + " Surname: " + Surname + " Age: " + Age + " Gender: " + Gender;

            return $"Name: {Name}, Surname:{Surname}, Age: {Age}, Gender: {Gender}";
        }
    }
}
