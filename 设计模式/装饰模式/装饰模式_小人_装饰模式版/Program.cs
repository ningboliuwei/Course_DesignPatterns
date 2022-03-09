#region

using System;

#endregion

namespace 装饰模式_小人_装饰模式版 {
    internal class Program {
        private static void Main(string[] args) {
            //第一种装扮——仅显示人
            // Person person = new Person("小毛");
            // person.Show();
            //第一种装扮

            //第二种装扮——垮裤
            // Person person = new Person("小毛");
            // BigTrousers bigTrousers = new BigTrousers();
            // bigTrousers.Decorate(person);
            // bigTrousers.Show();//如果此处改为person.Show()会如何？
            // person.Show();
            //第二种装扮——垮裤

            //第三种装扮——T恤+垮裤
            // Person person = new Person("小毛");
            //
            // BigTrousers bigTrousers = new BigTrousers();
            // bigTrousers.Decorate(person);
            //
            // TShirts tShirt = new TShirts();
            // tShirt.Decorate(bigTrousers);
            //
            // tShirt.Show(); //如果更换Decorate的顺序会如何

            //另外一种Decorate的顺序
            // tShirt.Decorate(person);
            // bigTrousers.Decorate(tShirt);
            // bigTrousers.Show();
            //另外一种Decorate的顺序

            //第三种装扮结束

            Console.ReadLine();
        }
    }
}