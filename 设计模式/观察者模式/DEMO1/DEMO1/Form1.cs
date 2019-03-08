using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEMO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void DoMethod();


        private void MethodA()
        {
            MessageBox.Show("MethodA");
        }

        private void MethodB()
        {
            MessageBox.Show("MethodB");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DoMethod d = MethodB;
            d += MethodA;
            d.Invoke();

        }

        private void ownClick(object sender, EventArgs e)
        {
            MessageBox.Show("own");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += ownClick;
            button1.Click += button1_Click;
        }
    }
}
