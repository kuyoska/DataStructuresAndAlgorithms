

namespace ZTMCodeInterview.Sorting
{
    public class Sorting
    {
        public void BubbleSort(int[] array)
        {
            bool swapped;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        // If no two elements were swapped by inner loop, then break
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break; // Array is sorted
                }
            }
        }

        public void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minPos = i;
                int min = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        minPos = j;
                        min = array[j];
                    }
                }

                if (minPos != i)
                {
                    // Swap
                    int temp = array[i];
                    array[i] = min;
                    array[minPos] = temp;
                }
            }
        }

        public void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public void MergeSort(int[] array)
        {
            if (array.Length < 2)
                return;
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            for (int i = 0; i < mid; i++)
                left[i] = array[i];
            for (int i = mid; i < array.Length; i++)
                right[i - mid] = array[i];
            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        private void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }

        public void QuickSort(int[] array)
        {
            QuickSortInternal(array, 0, array.Length - 1);
        }

        private void QuickSortInternal(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSortInternal(array, low, pi - 1);
                QuickSortInternal(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Swap array[i + 1] and array[high] (pivot)
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }
    }
}
