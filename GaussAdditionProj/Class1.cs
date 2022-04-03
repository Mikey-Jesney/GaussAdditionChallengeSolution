namespace GaussAdditionProj
{
    public class Class1
    {

        public static int GaussAddition(int a, int b)
        {

            //add the smallest number to the biggest number and times it by halfway between the biggest and smallest number 
            // add both numbers and half it


            if (a > b)
            {
                int place = a;
                a = b;
                b = place;
            }

            if(a == 1)
            {
                int combined = a + b;
                int halfOfFirst = combined / 2;
                Console.WriteLine(combined * halfOfFirst);
                return combined * halfOfFirst;
            }
            if(a > 1)
            {
                int combined = a + b;
                int added = (b + 1) - a;
                double halfadded = (double)added / 2;
                double result = combined * halfadded;
                int finalresult = (int)Math.Round(result, 0);
                return Math.Abs(finalresult);
                
            }

            return 0;

        }

    }

}