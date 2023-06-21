namespace ProektDomakinstvo
{
    internal class Program
    {
        static void VhodniDanni(List<double>razhodi,double count ) 
        {
            for (int i = 0; i < count; i++)
                razhodi.Add(double.Parse(Console.ReadLine()));
            
        }
        static void IzhodniDanni(List<double> razhodi)
        {
            Console.Write(string.Join(",", razhodi));
        }
        static void Swap(List<double> razhodi, int index1, int index2)
        {
            double swap= razhodi[index1];
            razhodi[index1]= razhodi[index2];
            razhodi[index2] = swap;

        }
        static void Sort(List<double> razhodi)
        {
            for (int i = 0; i <razhodi.Count-1; i++)
                for(int j=0;j<razhodi.Count-i-1;j++)
                    if (razhodi[j] > razhodi[j+1])
                    {
                        Swap(razhodi,j,j+1);
                    }
           
        }
        static int Find(List<double> razhodi,double zaplata)
        {
            int L = 0;
            int R = razhodi.Count-1;
            int m;
            do
            {
                m = (L + R) / 2;
                if (razhodi[m] < zaplata)
                {
                    L = m + 1;
                }
                else
                {
                    R = m - 1;
                }
            } while (razhodi[m]!=zaplata&&R>=L);
            if (razhodi[m] == zaplata)
                return m;
            else return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Vavedi broq na vavedenite razhodi");
            double count = double.Parse(Console.ReadLine());
            Console.Write("Vavedete mesecniq razhod na semeistvoto ");
            List<double> razhodi = new List<double>();
            VhodniDanni(razhodi, count);
            Sort(razhodi);
            IzhodniDanni(razhodi);
            Console.Write("Mesecen razhod");
            double zaplata= double.Parse(Console.ReadLine());
            Console.Write("Minimalna rabotna zaplata");
            int index= Find(razhodi, zaplata);
            
        }
    }

}