//* 백준 풀었던 문제 개인 저장용. (Better Comments 확장 추천.)
/*  //Todo  기본 양식
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        
    }
}
*/

#region //* 단계 - step
#region     1단계 - 입출력과 사칙연산
/*  //?     1. Hello World
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
*/
/*  //?     2. A+B
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[2];
        int a = Convert.ToInt32(value[0]);
        int b = Convert.ToInt32(value[1]);
        Console.WriteLine(a + b);
    }
}
*/
/*  //?     3. A-B
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[2];
        int a = int.Parse(value[0]);
        int b = int.Parse(value[1]);
        Console.WriteLine(a - b);
    }
}
*/
/*  //?     4. A×B
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[2];
        int a = int.Parse(value[0]);
        int b = int.Parse(value[1]);
        Console.Write(a * b);
    }
}
*/
/*  //?     5. A/B
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[2];
        double a = Convert.ToInt32(value[0]);
        double b = Convert.ToInt32(value[1]);
        double result = (a != -1 && b != 0) ? (a / b) : -1d;

        if (result != -1d)
            Console.WriteLine(result);
        else
            Console.WriteLine("null");
    }
}
*/
/*  //?     6. 사칙연산
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split() ?? new string[2];
        int a = Convert.ToInt32(value[0]);
        int b = Convert.ToInt32(value[1]);

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        if (b != 0)
        {
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
*/
/*  //?     7. ??!
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? id = Console.ReadLine() + "??!";
        Console.WriteLine(id);
    }
}
*/
/*  //?     8. 1998년생인 내가 태국에서는 2541년생?!
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        int inputYear = input != null ? int.Parse(input) : 0;
        if (1000 <= inputYear && inputYear <= 3000)
            Console.WriteLine(inputYear - 543);
    }
}
*/
/*  //?     9. 나머지
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[3];
        int a = Convert.ToInt32(value[0]);
        int b = Convert.ToInt32(value[1]);
        int c = Convert.ToInt32(value[2]);

        if (2 <= a && c <= 10000)
        {
            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
*/
/*  //?     10. 곱셈
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? first = Console.ReadLine();
        string? second = Console.ReadLine();

        int num1 = 0, num2 = 0;
        if (first != null)
            num1 = Convert.ToInt32(first);
        if (second != null)
            num2 = Convert.ToInt32(second);

        if (99 < num1 && num1 < 1000 && 99 < num2 && num2 < 1000)
        {
            int[] digit = new int[3];

            if (second != null)
                for (int i = 0; i < 3; i++)
                    digit[i] = (int)char.GetNumericValue(second[i]);

            for (int i = 2; i >= 0; i--)
                Console.WriteLine(num1 * digit[i]);
            Console.WriteLine(num1 * num2);
        }
    }
}
*/
/*  //?     11. 꼬마 정민
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string[] value = input?.Split(" ") ?? new string[3];
        decimal sum = 0;
        for (int i = 0; i < 3; i++)
            sum += Convert.ToDecimal(value[i]);
        if (sum != 0)
            Console.WriteLine(sum);
    }
}
*/
/*  //?     12. 고양이
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        Console.WriteLine("\\    /\\");
        Console.WriteLine(" )  ( \')");
        Console.WriteLine("(  /  )");
        Console.WriteLine(" \\(__)|");
    }
}
*/
/*  //?     13. 개
namespace Cinnamon;
public class Program
{
    static void Main()
    {
        Console.WriteLine("|\\_/|");
        Console.WriteLine("|q p|   /}");
        Console.WriteLine("( 0 )\"\"\"\\");
        Console.WriteLine("|\"^\"`    |");
        Console.WriteLine("||_/=\\\\__|");
    }
}
*/
#endregion
#region     2단계 - 조건문




#endregion
#endregion

#region //* 분류 - category



#endregion

