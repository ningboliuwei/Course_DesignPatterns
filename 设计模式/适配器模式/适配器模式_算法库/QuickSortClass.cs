namespace 适配器模式_算法库 {
    internal class QuickSortClass {
        public int partition(int[] a, int p, int r) {
            var x = a[r];
            var j = p - 1;
            for (var i = p; i <= r - 1; i++) {
                if (a[i] <= x) {
                    j++;
                    swap(a, j, i);
                }
            }

            swap(a, j + 1, r);
            return j + 1;
        }

        public int[] QuickSort(int[] array) {
            sort(array, 0, array.Length - 1);
            return array;
        }

        public void sort(int[] array, int p, int r) {
            var q = 0;
            if (p < r) {
                q = partition(array, p, r);
                sort(array, p, q - 1);
                sort(array, q + 1, r);
            }
        }

        public void swap(int[] a, int i, int j) {
            var t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }
}