//using System;
//class Program

//{
//    static void Min()
//    {
//        int[] arr = { 5, 43, 67, 21, 2, 45, 667, 3234 };
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//                min = arr[i];
//        }

//        Console.WriteLine("En kicik eded:" + min);
//    }
//    static void Main()
//            {
//                Min();
//            }

//}


//using System;
//class Program

//{
//    static void Main()
//    {
//        int[] arr = { 5, 43, 67, 21, 2, 45, 667, 3234 };
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//                min = arr[i];
//        }
//        Console.WriteLine("En kicik eded:" + min);
//    }

//}


//using System;
//class Program

//{
//    static int Min()
//    {
//        int[] arr = { 5, 43, 67, 21, 2, 45, 667, 3234 };
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//                min = arr[i];
//        }

//        return min;
//    }
//    static void Main()
//    {
//        Console.WriteLine("En kicik eded:" + Min());
//    }
//}

using System;
class Program

{
    //Cevrenin S-i
    static double Area(double r)
    {
        double p = 3;
        return p * r * r;
    }

    //Duzbucaqlinin S-i
    static double Area(double a, double b)
    {
        return a * b;
    }

    //Duzbucaqli paralelpipedin tam sethinin S-i
    static double Area(double a, double b, double c)
    {
        return 2 * (a * b + a * c + b * c);
    }

    //3bucagin daxilie cekilmis cevrenin S-i
    static double Area(double a, double b, double c, double r)
    {

        double p = (a + b + c) / 2;
        return p * r;
    }
    static void Main()

    {
        Console.WriteLine("Cvrenin sahesi:" + Area(2));
        Console.WriteLine("Duzbucaqlinin sahesi:" + Area(2, 3));
        Console.WriteLine("Duzbucaqli paralelpipedin sahesi:" + Area(2, 3, 4));
        Console.WriteLine("3bucagin daxiline cekilmis cevrenin sahesi:" + Area(2, 3, 4, 5));
    }

}













































