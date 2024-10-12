
namespace methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region c.Methoda ad gonderende(Sabir),a ve s gonderende(Guliyev Sabir),a,s ve ata a göndərildikdə adin(S.Guliyev Mehti).
            //string name = Console.ReadLine();
            //string surname= Console.ReadLine();
            //string fatherName = Console.ReadLine();
            //Biography(name);
            #endregion
            #region b.əgər methoda bir eded gonderilirse hemin ededin kvadratını,iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.
            //Console.WriteLine(POW(2));
            #endregion

            #region a.Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir. Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.
            //Console.WriteLine(Aricmetic(3,5,(char)43));
            #endregion

        }
        static void Biography(string name)//C misali
        {
            Console.WriteLine(name);
        }
       static void Biography(string name,string surname)
        {
            Console.WriteLine($"{surname}{" "}{name}");
        }

        static void Biography(string name,string surname,string fatherName)
        {
            char basHerf = name[0];
            Console.WriteLine($"{basHerf+"."}{surname}{" "}{fatherName}");
        }

        static int POW(int num1, int num2=2)//B misali
        { int quvvet = 1;
            for (int i = 0; i <num2 ; i++)
            {
               quvvet *= num1;
                
            }
            return quvvet;

        }
        
        static int Aricmetic(int number1,int number2,char operators)//A misali
        {
            if (operators == (char)42)
            {
                return number1 * number2;
            }
            else if (operators == (char)43)
            {
                return number1 + number2;
            }
            else if (operators == (char)45)
            {
                return number1 - number2;
            }
            else if (operators == (char)47)
            {
                return number1 / number2;
            }
            else 
            {
                return 0;
            }
        }


    }
}
