
namespace methods_1
{//Overload Tasks 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Çevrənin sahəsi - S = p*r² (p=3)
            int radius = 10;
            int circleArea = Area(radius);
            Console.WriteLine(circleArea);
            #endregion

            #region 2. Düzbucaqlının sahəsi - S = a*b
            //int eni = 5;
            //int uzunlugu = 10;
            //int rectangularArea=Area(eni, uzunlugu);
            //Console.WriteLine(rectangularArea);
            #endregion

            #region 3. Düzbucaqlı paralelpipedin tam səthinin sahəsi -S = 2(a * b + a * c + b * c)
            //int aTerefi = 3;
            //int bTerefi=4;
            //int cTili = 5;
            //int duzbucaqliParalipedArea=Area(aTerefi, bTerefi, cTili);
            //Console.WriteLine(duzbucaqliParalipedArea);
            #endregion


            #region 4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
            //int a = 5;
            //int b = 3;
            //int c = 4;
            //int radius = 10;
            //int daxileCevreArea=Area(a, b, c,radius);
            //Console.WriteLine(daxileCevreArea);

            #endregion

        }
        static int Area(int radius)
        {
            int pi = 3;
            
            return pi * radius * radius;
        
        }
        static int Area(int eni, int uzunlugu)
        {
            return (eni * uzunlugu);
        }
        static int Area(int aTerefi,  int bTerefi, int cTili)
        {
            return 2 * (aTerefi * bTerefi + aTerefi* cTili + bTerefi * cTili);
        }
        static int Area(int a,int b,int c,int radius)
        {
            int p =(a+b+c)/2;
            return p*radius;
        }
    }
}
