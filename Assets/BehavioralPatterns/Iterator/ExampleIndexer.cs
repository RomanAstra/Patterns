using System;


namespace Iterator
{
    public sealed class ExampleIndexer
    {
        public int[] Mass;

        public ExampleIndexer(int size)
        {
            Mass = new int[size];
        }

        public int Count()
        {
             return Mass.Length;
        }

        public int this[uint index]
        {
            get
            {
                if (index < Mass.Length)
                {
                    return Mass[index];
                }
                return Mass[0];
            }
            set
            {
                Mass[index] = value;
            }
        }

        public ExampleType this[string str]
        {
            get
            {
                switch (str)
                {
                    case "One":
                        return ExampleType.First;
                    case "Two":
                        return ExampleType.Second;
                    default:
                        return 0;
                }
            }
        }

        public void Add(int value)
        {
            if (Mass == null)
            {
                Mass = new int[0];
            }
            Array.Resize(ref Mass, Mass.Length + 1);
            Mass[Mass.Length - 1] = value;
        }

        public void PrintArray(char s = ' ')
        {
            foreach (var i in Mass)
            {
               // Print($"{s}{i}");
            }
        }

        public void SetValueArray(int max)
        {
            var random = new Random();
            for (var i = 0; i < Mass.Length; i++)
            {
                Mass[i] = random.Next(max);
            }
        }

        public void Sort()
        {
            for (int i = 0; i < Mass.Length - 1; i++)
            {
                var index = i;
                for (int j = i + 1; j < Mass.Length; j++)
                {
                    if (Mass[j] < Mass[index])
                    {
                        index = j;
                    }
                }
                Swap(ref Mass[i], ref Mass[index]);
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    public enum ExampleType
    {
        First,
        Second
    }
}

