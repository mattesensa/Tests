namespace CalcolatriceTests
{
    public class SommaAlgebrica
    {
        public SommaAlgebrica()
        {
        }

        internal int Add(int[] addendi)
        {
            try
            {
                if (addendi == null || addendi.Length == 0)
                {
                    throw new ArgumentNullException();
                }
                int sum = 0;

                foreach (int v in addendi)
                {
                    sum += v;
                }

                return sum;

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
                
            }
        }

        internal double Somma(double[] addendi)
        {
            try
            {
                if (addendi == null || addendi.Length == 0)
                {
                    throw new ArgumentNullException();
                }
                double sum = 0;

                foreach (int v in addendi)
                {
                    sum += v;
                }

                return sum;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}