namespace 适配器模式_算法库 {
    internal interface IScoreOperation {
        int Search(int[] array, int key); //成绩查找  
        int[] Sort(int[] array); //成绩排序  
    }
}