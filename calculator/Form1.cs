using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace calculator
{
    enum op
        {
        add ='+',
        minus = '-',
        multipy = '*',
        remove = '/',
    }
    public partial class Form1 : Form
    {
        
      bool equal = false;
        bool caculate = false ;
        int num1 = 0 ;
        double result = 0;
        double ResultNum = 0;
        bool add = false;
        bool minus = false;

        public Form1()
        {
            InitializeComponent();
        }


        #region HMI
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        
        }

       
        


        #endregion

        //等於
        private void btn_equals_Click(object sender,op op, ElapsedEventArgs e)
        {

            
            

                Button btn = (Button)sender;
                caculate = false;
                equal = true;
            if(equal == true)
            {
                double num_two = Convert.ToDouble(textBox1.Text);
                switch(op)
                {
                    case op.add:
                        ResultNum = result + num_two;
                        textBox1.Text = Convert.ToString(ResultNum);
                        //result = 0;
                        
                        add = false;
                        break;

                     case op.minus:
                        ResultNum = result - num_two;
                        textBox1.Text = Convert.ToString(ResultNum);
                        break;

                    case op.multipy:
                        ResultNum = result * num_two;
                        textBox1.Text = Convert.ToString(ResultNum);
                        break;

                    case op.remove:
                        ResultNum = result / num_two;
                        textBox1.Text = Convert.ToString(ResultNum);
                        break;
                }
                equal = false;
            }
                //else if(minus)
                //    {
                //    ResultNum = result - num_two;
                //    textBox1.Text = Convert.ToString(ResultNum);
                //    //result = 0;
                //    equal = false;
                //    minus= false;
                }
               
            
            

                
        


        private void btn_num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = "";
            textBox1.Text += btn.Text;

            if (equal == true)
            {
                textBox1.Text += btn.Text;
                result = 0;
                //textBox1.Text += btn.Text;
                equal = false;
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            
            
            if (caculate ==true)
            {
                double num_two = Convert.ToDouble(textBox1.Text);
                
                ResultNum = result + num_two;
                
                    result= ResultNum;
                textBox1.Text =result.ToString();
                add= true;
                minus= false;
            }
           else
            {
                double num_one = Convert.ToDouble(textBox1.Text);
                
                caculate = true;

                result = num_one;
                add = false;
                minus = false;
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (caculate == true)
            {
                double num_two = Convert.ToDouble(textBox1.Text);

                ResultNum = result - num_two;

                result = ResultNum;
                textBox1.Text = result.ToString();
                add= false;
                minus= true;
            }
            else
            {
                double num_one = Convert.ToDouble(textBox1.Text);

                caculate = true;

                result = num_one;
                minus= false;
            }
        }

        private void btn_times_Click(object sender, EventArgs e)
        {

        }

        private void btn_dividedby_Click(object sender, EventArgs e)
        {

        }


        #region Process

        private void Ctrl_Calculate_Add(object sender, EventArgs e)
        {

        }
        #endregion
    }
}


