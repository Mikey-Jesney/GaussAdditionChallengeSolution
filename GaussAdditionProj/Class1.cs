namespace GaussAdditionProj
{
    public class Class1
    {

        public static int GaussAddition(int a, int b)
        {

            if(a > b)
            {
                int place = a;
                a = b;
                b = place;
            }

            if(a == 1)
            {
                int first = a + b;
                int second = first / 2;
                Console.WriteLine(first * second);
                return first * second;
            }
            if(a > 1)
            {
                int combined = a + b;
                int thinggy = (b + 1) - a;
                double halfthinggy = (double)thinggy / 2;
                double result = combined * halfthinggy;
                int finalresult = (int)Math.Round(result, 0);
                return Math.Abs(finalresult);
                
            }

            return 0;

        }

        //add the smallest number to the biggest number and times it by halfway between the biggest and smallest number 
        // add both numbers and half it

    }

}