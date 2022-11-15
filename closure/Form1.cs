using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace closure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 11; x++)
            {
                listBox1.Items.Add(x);
                var fn = Outer();
                Action Outer()
                {
                    int X = 1;  
                    void Inner()    
                    {
                        x++;       
                        Console.WriteLine(x);
                    }
                    return Inner;
                }
            }
        }
    }
}

