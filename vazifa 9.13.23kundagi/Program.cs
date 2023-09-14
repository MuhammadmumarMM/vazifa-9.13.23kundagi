////////////////vazifa 




//// PowerA3
//double A, B;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write(i + "- sonni kiriting: ");
//    A = Convert.ToDouble(Console.ReadLine());
//    PowerA3(A, out B);
//    Console.WriteLine(A + "ning uchinchi darajasi: " + B);
//}
//void PowerA3(double A, out double B)
//{
//    B = A * A * A;
//}



//// PowerA234
//double A, B, C, D;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write(i + "- sonni kiriting: ");
//    A = Convert.ToDouble(Console.ReadLine());
//    PowerA3(A, out B, out C, out D);
//    Console.WriteLine(A + " - ning ikkinchi darajasi: " + B);
//    Console.WriteLine(A + " - ning uchinchi darajasi: " + C);
//    Console.WriteLine(A + " - ning to'rtinchi darajasi: " + D);
//}
//void PowerA3(double A, out double B, out double C, out double D)
//{
//    B = A * A;
//    C = A * A * A;
//    D = A * A * A * A;
//}

//// DigitCount SUM
//int K, C, S, E;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write(i + "- sonni kiriting: ");
//    K = Convert.ToInt32(Console.ReadLine());

//    PowerA3(K, out C, out S, out E);
//    Console.WriteLine(K + " raqamlar soni " + E);
//    Console.WriteLine(K + " raqamlar yigindisi " + C);
//    Console.WriteLine(K + " raqamlar kopaytmasi " + S);
//}
//void PowerA3(int K, out int C, out int S, out int E)
//{
//    C = 0; S = 1; E = 0;

//    for (int i = 1; i <= K; i++)
//    {
//        E = i;
//        C += i;
//        S *= i;
//    }
//}


///////// InvertDigits
///

//int K;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write(i + "- sonni kiriting: ");
//    K = Convert.ToInt32(Console.ReadLine());
//    Rever(K);
//    Console.WriteLine();
//}
//void Rever(int K)
//{
//    string KStr = K.ToString();
//    char[] KChars = KStr.ToCharArray();
//    Array.Reverse(KChars);
//    foreach (char c in KChars)
//        {
//            Console.Write(c);
//        }
//}


////Add righ digit - 1

//int K, D, F;
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write(i + "- sonni kiriting: ");
//    K = Convert.ToInt32(Console.ReadLine());
//    F = Convert.ToInt32(Console.ReadLine());
//    Qosh(K,F, out D);
//    Console.WriteLine(K + "- ga qowilgan son " + D);
//}
//void Qosh(int K, int F, out int D)
//{
//    D = K * 10 + F;
//}


////Add righ digit - 2

//int K, D;
//K = Convert.ToInt32(Console.ReadLine());
//D = Convert.ToInt32(Console.ReadLine()); 

//int natija = AddDigitToRight(K, D);

//Console.WriteLine(natija);

//static int AddDigitToRight(int K, int D)
//{
//    return K * 10 + D;
//}


////////MIN MAX

//int X , Y ;
//Console.Write("X ni kiriting: ");
//X = Convert.ToInt32(Console.ReadLine());
//Console.Write("Y ni kiriting: ");
//Y = Convert.ToInt32(Console.ReadLine()); 

//MinMax(ref X, ref Y);

//Console.WriteLine("X = " + X);
//Console.WriteLine("Y = " + Y);
//void MinMax(ref int X, ref int Y)
//{
//    int temp = X;
//    X = Y;
//    Y = temp;
//}


//////////////////SORT

//int A, B, C;
//Console.Write("A ni kiriting: ");
//A = Convert.ToInt32(Console.ReadLine());
//Console.Write("B ni kiriting: ");
//B = Convert.ToInt32(Console.ReadLine());
//Console.Write("C ni kiriting: ");
//C = Convert.ToInt32(Console.ReadLine());

//Sortlash(ref A, ref B , ref C);

//Console.WriteLine("A = " + A);
//Console.WriteLine("B = " + B);
//Console.WriteLine("C = " + C);

//void Sortlash(ref int A, ref int B, ref int C)
//{
//    if (A > B)
//    {
//        int ozlash1 = A;
//        A = B;
//        B = ozlash1;
//    }
//    if (A > C)
//    {
//        int ozlash2 = A;
//        A = C;
//        C = ozlash2;
//    }
//    if (B > C)
//    {
//        int ozlash3 = B;
//        B = C;
//        C = ozlash3;
//    }
//}



////////////  Sum range

//int A, B;
//Console.Write("A ni kiriting: ");
//A = Convert.ToInt32(Console.ReadLine());
//Console.Write("B ni kiriting: ");
//B = Convert.ToInt32(Console.ReadLine());
//int sum = Summer(A, B);

//Console.WriteLine("A dan B gacha bo'lgan sonlar yig'indisi: " + sum);

//int Summer(int A, int B)
//{
//    if (A > B)
//    {
//        return 0;
//    }

//    int sum = 0;
//    for (int i = A; i <= B; i++)
//    {
//        sum += i;
//    }

//    return sum;
//}