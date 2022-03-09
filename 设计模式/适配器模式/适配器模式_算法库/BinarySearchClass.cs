namespace 适配器模式_算法库 {
    internal class BinarySearchClass {
        public int BinarySearch(int[] array, int key) {
            var low = 0;
            var high = array.Length - 1;
            while (low <= high) {
                var mid = (low + high) / 2;
                var midVal = array[mid];
                if (midVal < key) {
                    low = mid + 1;
                }
                else if (midVal > key) {
                    high = mid - 1;
                }
                else {
                    return 1; //找到元素返回1    
                }
            }

            return -1; //未找到元素返回-1  
        }
    }
}