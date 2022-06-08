namespace 实验15_迭代器模式_IEnumerator接口;

public static class Program {
    private static void Main(string[] args) {
        Person[] array = {
            new() { Name = "王五", Age = 21 },
            new() { Name = "张三", Age = 23 },
            new() { Name = "李四", Age = 22 },
            new() { Name = "赵六", Age = 20 }
        };

        var people = new People(array);

        foreach (Person item in people) {
            Console.WriteLine("姓名：{0}，年龄{1}", item.Name, item.Age);
        }

        Console.ReadLine();
    }
}