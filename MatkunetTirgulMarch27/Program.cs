using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MatkunetTirgulMarch27
{
    internal class Program
    {
        // פעולה המקבלת מערך של נקודות
        // הפעולה מחזירה את המרחק הגדול ביותר בין שתי נקודות
        // בסוף הפעולה המערך נותר ללא שינוי

        public static double GetMaxDistance(Point[] arrPoints)
        {
            double max = 0;

            for (int i = 0; i < arrPoints.Length; i++)
            { for (int j = 0; j < arrPoints.Length; j++)
                {
                    if (arrPoints[i].Distance(arrPoints[j]) > max)
                    {
                        max = arrPoints[i].Distance(arrPoints[j]);
                    }
                }

            }
            return max;


        }

        //פעולה המקבלת מערך
        // הפעולה מחזירה אמת האם המערך עולה יורד על פי הכללים בשאלה
        // בסוף הפעולה המערך נותר ללא שינוי

        public static bool OleYored(int[] arr)
        {

            if (arr.Length % 2 != 0)
            {
                return false;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i % 2 == 0 && arr[i] > arr[i + 1])
                    return false;
                if (i % 2 == 1 && arr[i] < arr[i + 1])
                    return false;

            }
            return true;


        }


        //הפעולה מקבלת רשימה
        // הפעולה מחזירה את אורך הרשימה הקופצת באחד הארוכה ביותר
        // בסוף הפעולה הרשימה נותרת ללא שינוי
        public static int MaxJump(Node<int> myList)
        {
           // אם הרשימה ריקה החזר 0
            if (myList == null) return 0;

            int maxLength = 1, currentLength = 1;

            while (myList.HasNext())
            {
                if (myList.GetValue()+1==myList.GetNext().GetValue())
                {
                    maxLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
                myList = myList.GetNext();
            }
            return maxLength;

        }

       
        // פעולה המקבלת תור של שברים ומספר המייצג מכנה
        // הפעולה תחזיר את סכום המונים בעלי אותו מכנה
        // בסוף הפעולה התור ללא שינוי

        public static int SumOfMechane (Queue<Rational> myQueue, int mechane )

        {

            int sum = 0;
            Queue <Rational> temp = new Queue<Rational> ();

            while (!myQueue.IsEmpty())
            {
                if (myQueue.Head().GetDenom() == mechane)
                {
                    sum += myQueue.Remove().GetNumerator();
                }
                else
                {
                    temp.Insert(myQueue.Remove());
                }
           
            }

            while(!temp.IsEmpty())
            {
                myQueue.Insert(temp.Remove());
            }
            return sum;      
        }
        // פעולה המקבלת תור של עצמים מסוג שבר
        // הפעולה מעדכנת את התור המתקבל על פי הנחיות השאלה
        // התור המתקבל משתנה על פי ההנחיות

        public static void Remove(Queue<Rational> myQueue)
        {
            Queue<Rational> temp = new Queue<Rational>();

            
            while (!myQueue.IsEmpty())
            {
                int numMechane = myQueue.Head().GetDenom();
                int newMone = SumOfMechane(myQueue, numMechane);

                temp.Insert( new Rational (newMone, numMechane) );
            }
           
            while (!temp.IsEmpty())
            {
                myQueue.Insert(temp.Remove());
            }
        }
        
         public static Queue<int> bet (Node<Queue<int>> myList)
        {

        }
       

        static void Main(string[] args)
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Insert(8);
            myQ.Insert(122);
            Console.WriteLine(myQ);
            Queue<int> myQ2 = new Queue<int>();
            myQ2.Insert(888);
            myQ2.Insert(1222);
            Console.WriteLine(myQ2);
            Node<Queue<int>> myListOfQueues = new Node<Queue<int>>(myQ);
            Node<Queue<int>> nodeToAdd = new Node<Queue<int>>(myQ2);
            myListOfQueues.SetNext(nodeToAdd);
           Queue<int> myTempQ = myListOfQueues.GetNext().GetValue();    //888
            Console.WriteLine(myTempQ.Head()  );


            /*Rational r1 = new Rational(1,2);
            Console.WriteLine(r1);
            r1.Add(new Rational(3, 4));
            Console.WriteLine(r1);
            r1.Simplify();
            Console.WriteLine(r1);
            Console.WriteLine(r1.IsLargerThan(new Rational (5,4)));*/


        }
    }
}
