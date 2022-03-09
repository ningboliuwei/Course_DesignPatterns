#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using 动物运动会_接口;

#endregion

namespace 动物运动会 {
    public partial class Form9 : Form {
        public Form9() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            var mcat = new MachineCat("小叮当");
            var wukong = new StoneMonkey("孙悟空");
            var sman = new SuperMan();

            var fliers = new IFly[4];
            fliers[0] = mcat;
            fliers[1] = wukong;
            fliers[2] = sman;

            //for (int i = 0; i < 3; i++)
            //{
            //	fliers[i].Fly();
            //}
            var arrayListAnimal = new ArrayList();
            arrayListAnimal.Add(mcat);
            arrayListAnimal.Add(wukong);
            arrayListAnimal.Add(sman);
            //arrayListAnimal.Add(123);
            //arrayListAnimal.Add("Hello world");

            //for (int i = 0; i < arrayListAnimal.Count; i++)
            //{
            //	MessageBox.Show(((IFly)arrayListAnimal[i]).Fly());
            //}

            var flyList = new List<IFly>();
            flyList.Add(new MachineCat());
            flyList.Add(new StoneMonkey());
            flyList.Add(new SuperMan());

            //for (int i = 0; i < flyList.Count; i++)
            //{
            //	MessageBox.Show(flyList[i].Fly());
            //}

            //foreach (IFly fly in flyList)
            //{
            //	fly.Fly();
            //}

            //int a = 123;
            //object o = (object) a;

            //int b = (int) o;
        }
    }
}