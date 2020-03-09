namespace MergeSort
{
    class MergeSort
    {
        int[] array;
        int[] temp;
        public MergeSort(int[] a)
        {
            array = a;
            temp = a;
        }

        public void StartSort(int first, int last)
        {
            if(first < last)
            {
                int middle = (first + last)/2;
                StartSort(first, middle);
                StartSort(middle+1, last);
                Sorter(first,middle,last);
            }
        }
        void Sorter(int first,int middle, int last)
        {
            int firstIndex = first;
            int secondIndex = last;
            int counter = 0;
            while(0<firstIndex&&first<secondIndex)
            {
                if(array[firstIndex] <= array[secondIndex])
                {
                    array[counter] = temp[firstIndex];
                    firstIndex++;
                }
                else
                {
                    array[counter] = temp[secondIndex];
                    secondIndex--;
                }
                counter++;
            }
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
    }
}