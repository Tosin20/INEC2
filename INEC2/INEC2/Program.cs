
namespace INEC
{
    internal class INEC2Ass
    {

        static void Main(string[] args)
        {

            SortedList<string, int> sortList = new SortedList<string, int>();

            string[] inecArray = { "seun", "tayo", "anu", "debo", "muyiwa", "anu", "anu", "tayo"};



            foreach (var name in inecArray)
            {
                int count = 0;
                if (sortList.ContainsKey(name))     //to compare one name to another in the array
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)      //to check the number of times a name appears
                {
                    if (name == inecArray[i])
                    {
                        count++;
                    }
                }
                if (count > 1)                   // to print out if count is more than 1
                {
                    sortList.Add(name, count);
                }
            }
            foreach (var item in sortList)         //to check each item in the array and print 
            {
                Console.WriteLine(item);

            }
        }

    }
}

