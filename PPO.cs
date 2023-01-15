namespace Solution_HomeWorks
{
    internal class PPO
    {
        private char[,] arr;
        private Random rdm= new Random();
        private int pl, ph;
        private bool isFirst;
        public PPO(int lenght,int height) 
        {
            arr= new char[lenght,height];
            for(int i = 0;i< lenght;i++)
            {
                for(int j = 0;j<height;j++)
                {
                    int value = rdm.Next(1,10);
                    if(value == 1)
                    {
                        arr[i,j] = '^';
                    }
                    else
                    {
                        arr[i, j] = '+';
                    }
                }
            }
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(arr[i,j]);
                }Console.WriteLine();
            }
        }
        public void StartFight()
        {
            
            while(true)
            {
                isFirst = true;
                Console.Clear();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j]);
                        if (arr[i, j] == '^' && isFirst)
                        {
                            pl = i;
                            ph = j;
                            isFirst = false;
                        }
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(1000);
                arr[pl, ph] = '*';
            }
        }
    }
}
