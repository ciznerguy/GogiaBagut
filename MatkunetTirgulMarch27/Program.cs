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

        static void Main(string[] args)
        {
            
        }
    }
}
