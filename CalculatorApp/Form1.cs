using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection.Emit;
namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();
            
        }
        double Input_First_Number = 0;
        double Input_Last_Number = 0;
        double ConverterInput = 0;
        double ConverterResult = 0;
        double Result = 0;
        String op = "";
        int check = 0;
        int check2 = 0;
        bool calc = true;
        bool DegreeConverter = false;
        bool NotAllowedToChangeColors = false;
        bool CtoF = true;
        

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetValue_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text = "";
            }
            else if(DegreeConverter == true)
            {
                txtConverterInput.Text = "";
                txtConverterResult.Text = "";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                if (!txtEnter.Text.Contains("."))
                {
                    if (txtEnter.Text == "")
                    {
                        txtEnter.Text += "0.";
                    }
                    else
                    {
                        txtEnter.Text += ".";
                    }
                }
            }
            else if (DegreeConverter == true)
            {
                if (!txtConverterInput.Text.Contains("."))
                {
                    if (txtConverterInput.Text == "")
                    {
                        txtConverterInput.Text += "0.";
                    }
                    else
                    {
                        txtConverterInput.Text += ".";
                    }
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "0";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "1";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "2";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "3";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "4";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "5";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "6";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "7";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "8";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calc == true)
            {
                txtEnter.Text += "9";
            }
            else if (DegreeConverter == true)
            {
                txtConverterInput.Text += "9";
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "")
            {

                txtEnter.Text = "0";
                op = "";
            }
            check = 1;
            op = "+";
            String Input = txtEnter.Text;
            Input_First_Number = Convert.ToDouble(Input);
            txtEnter.Text = "";
        }
        

        private void btnMinus_Click(object sender, EventArgs e)
        {   if (txtEnter.Text == "")
            {
                
                txtEnter.Text = "0";
                op = "";
            }
            check = 1;
            op = "-";
            String Input = txtEnter.Text;
            Input_First_Number = Convert.ToDouble(Input);
            txtEnter.Text = "";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "")
            {

                txtEnter.Text = "0";
                op = "";
            }
            check = 1;
            op = "*";
            String Input = txtEnter.Text;
            Input_First_Number = Convert.ToDouble(Input);
            txtEnter.Text = "";
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "")
            {

                txtEnter.Text = "0";
                op = "";
            }
            check = 1;
            op = "/";
            String Input = txtEnter.Text;
            Input_First_Number = Convert.ToDouble(Input);
            txtEnter.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                if (txtEnter.Text != "")
                {
                    String Input = txtEnter.Text;
                    Input_Last_Number = Convert.ToDouble(Input);
                    Result = Input_First_Number + Input_Last_Number;
                }

            }
            else if (op == "-")
            {   
                if (txtEnter.Text != "")
                {
                    String Input = txtEnter.Text;
                    Input_Last_Number = Convert.ToDouble(Input);
                    Result = Input_First_Number - Input_Last_Number;
                }
                
            }
            else if (op == "*")
            {   
                if (txtEnter.Text != "")
                {
                    String Input = txtEnter.Text;
                    Input_Last_Number = Convert.ToDouble(Input);
                    Result = Input_First_Number * Input_Last_Number;
                }
            }
            else if (op == "/")
            {
                if (txtEnter.Text != "")
                {
                    String Input = txtEnter.Text;
                    Input_Last_Number = Convert.ToDouble(Input);
                    Result = Input_First_Number / Input_Last_Number;
                }
            }
            

            txtEnter.Text = Result.ToString();
            check = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            if (txtEnter.Text != "" && check == 0) 
            {
                check2 = 1;
                String Input = txtEnter.Text;
                Input_First_Number = Convert.ToDouble(Input);
                //Input_First_Number = Input_First_Number - Input_First_Number * 2;
                Input_First_Number = -Input_First_Number;
                txtEnter.Text = Input_First_Number.ToString();
                
            }
            else if(txtEnter.Text != "" && check == 1)
            {
                String Input = txtEnter.Text;
                Input_Last_Number = Convert.ToDouble(Input);
                //Input_Last_Number = Input_Last_Number - Input_Last_Number * 2;
                Input_Last_Number = -Input_Last_Number;
                txtEnter.Text = Input_Last_Number.ToString();
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BringToFront();
            if (flowLayoutPanel1.Width == 195)
            {
                btnChangeColors.Visible = false;
                btnDegreeConverter.Visible = false;
                btnCalculator.Visible = false;
                for (int ii = 0; ii < 60; ii++)
                {
                    flowLayoutPanel1.Width -= 10;
                    Thread.Sleep(1);
                    ii++;
                    if (flowLayoutPanel1.Width == 45)
                    {
                        break;
                    }
                }
                
            }
            else
            {
                for (int ii = 0; ii < 60; ii++)
                {
                    flowLayoutPanel1.Width += 10;
                    Thread.Sleep(1);
                    ii++;
                    if (flowLayoutPanel1.Width == 195)
                    {
                        break;
                    }
                }

                if (NotAllowedToChangeColors == false)
                {
                    btnChangeColors.Visible = true;
                }
                
                if (calc == true)
                {
                    btnDegreeConverter.Visible = true;
                }
                else
                {
                    btnCalculator.Visible = true;   
                }
                
            }
            
        }

        private void btnChangeColors_Click(object sender, EventArgs e)
        {
            
            btnChangeColors.Visible = false;
            btnDegreeConverter.Visible = false;
            flowLayoutPanel1.Width = 45;
            flowLayoutPanel2.Visible = true;
            panel2.Visible = true;
            lblColors.Visible = true;
            btnChangeColorDeafult.Visible = true;
            btnChangeColorRed.Visible = true;
            btnColorsBack.Visible = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.BringToFront();
            lblColors.BringToFront();
            panel2.BringToFront();
            
            
           
            btnChangeColorDeafult.BringToFront();
            btnChangeColorRed.BringToFront();
            btnColorsBack.BringToFront();
            


        }

        private void btnChangeColorDeafult_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            panel2.Visible = false;
            btn0.BackColor = Color.DeepSkyBlue;
            btn1.BackColor = Color.DeepSkyBlue;
            btn2.BackColor = Color.DeepSkyBlue;
            btn3.BackColor = Color.DeepSkyBlue;
            btn4.BackColor = Color.DeepSkyBlue;
            btn5.BackColor = Color.DeepSkyBlue;
            btn6.BackColor = Color.DeepSkyBlue;
            btn7.BackColor = Color.DeepSkyBlue;
            btn8.BackColor = Color.DeepSkyBlue;
            btn9.BackColor = Color.DeepSkyBlue;
            btnEqual.BackColor = Color.DeepSkyBlue;
            btnPlus.BackColor = Color.DeepSkyBlue;
            btnMinus.BackColor =Color.DeepSkyBlue;
            btnTimes.BackColor = Color.DeepSkyBlue;
            btnDivided.BackColor = Color.DeepSkyBlue;
            btnConvert.BackColor = Color.DeepSkyBlue;
            btnDot.BackColor = Color.DeepSkyBlue;
            btnReset.BackColor = Color.DeepSkyBlue;
            btnConverterConverter.BackColor = Color.DeepSkyBlue;
            btnConvertDegree.BackColor = Color.DeepSkyBlue;
            btnSwitchConverter.BackColor = Color.DeepSkyBlue;
            flowLayoutPanel1.Width = 45;
            btnChangeColors.Visible = false;
            flowLayoutPanel2.SendToBack();
            panel2.SendToBack();
            lblColors.SendToBack();
            btnChangeColorDeafult.SendToBack();
            btnChangeColorRed.SendToBack();
            btnColorsBack.SendToBack();


        }

        private void btnChangeColorRed_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            panel2.Visible = false;
            btn0.BackColor = Color.IndianRed;
            btn1.BackColor = Color.IndianRed;
            btn2.BackColor = Color.IndianRed;
            btn3.BackColor = Color.IndianRed;
            btn4.BackColor = Color.IndianRed;
            btn5.BackColor = Color.IndianRed;
            btn6.BackColor = Color.IndianRed;
            btn7.BackColor = Color.IndianRed;
            btn8.BackColor = Color.IndianRed;
            btn9.BackColor = Color.IndianRed;
            btnEqual.BackColor = Color.IndianRed;
            btnPlus.BackColor = Color.IndianRed;
            btnMinus.BackColor = Color.IndianRed;
            btnTimes.BackColor = Color.IndianRed;
            btnDivided.BackColor = Color.IndianRed;
            btnConvert.BackColor = Color.IndianRed;
            btnDot.BackColor = Color.IndianRed;
            btnReset.BackColor = Color.IndianRed;
            btnConverterConverter.BackColor = Color.IndianRed;
            btnConvertDegree.BackColor = Color.IndianRed;
            btnSwitchConverter.BackColor = Color.IndianRed;
            flowLayoutPanel1.Width = 45;
            btnChangeColors.Visible = false;
            btnDegreeConverter.Visible = false;
            flowLayoutPanel1.SendToBack();
            panel2.SendToBack();
            lblColors.SendToBack();
            btnChangeColorDeafult.SendToBack();
            btnChangeColorRed.SendToBack();
            btnColorsBack.SendToBack();

        }

        private void btnDegreeConverter_Click(object sender, EventArgs e)
        {
            DegreeConverter = true;
            calc = false;
            NotAllowedToChangeColors = true;
            pnlConverter.Visible = true;
            txtConverterInput.Visible = true;
            lblCtoF.Visible = true;
            txtConverterResult.Visible = true;
            btnConvertDegree.Visible = true;
            btnChangeColors.Visible = false;
            btnDegreeConverter.Visible = false;
            btn0.BringToFront();
            btn1.BringToFront();
            btn2.BringToFront();
            btn3.BringToFront();
            btn4.BringToFront();
            btn5.BringToFront();
            btn6.BringToFront();
            btn7.BringToFront();
            btn8.BringToFront();
            btn9.BringToFront();
            btnDot.BringToFront();
            btnReset.Location = new Point(309, 113);
            btnReset.BringToFront();
            for (int ii = 0; ii < 60; ii++)
            {
                flowLayoutPanel1.Width -= 10;
                Thread.Sleep(1);
                ii++;
                if (flowLayoutPanel1.Width == 45)
                {
                    break;
                }
            }
            
        }


        private void btnColorsBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            panel2.Visible = false;
            lblColors.Visible = false;
            btnChangeColorDeafult.Visible = false;
            flowLayoutPanel1.SendToBack();
            panel2.SendToBack();
            lblColors.SendToBack();
            btnChangeColorDeafult.SendToBack();
            btnChangeColorRed.SendToBack();
            btnColorsBack.SendToBack();

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            calc = true;
            NotAllowedToChangeColors = false;
            DegreeConverter = false;
            pnlConverter.Visible= false;
            btnChangeColors.Visible = false;
            btnCalculator.Visible = false;
            txtConverterInput.Visible = false;
            lblCtoF.Visible = false;
            txtConverterResult.Visible = false;
            btnConvertDegree.Visible = false;
            btn0.SendToBack();
            btn1.SendToBack();
            btn2.SendToBack();
            btn3.SendToBack();
            btn4.SendToBack();
            btn5.SendToBack();
            btn6.SendToBack();
            btn7.SendToBack();
            btn8.SendToBack();
            btn9.SendToBack();
            btnDot.SendToBack();
            btnReset.SendToBack();
            btnReset.Location = new Point(386, 113);
            for (int ii = 0; ii < 60; ii++)
            {
                flowLayoutPanel1.Width -= 10;
                Thread.Sleep(1);
                ii++;
                if (flowLayoutPanel1.Width == 45)
                {
                    break;
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertDegree_Click(object sender, EventArgs e)
        {

            if (txtConverterInput.Text == "")
            {
                txtConverterInput.Text = "0";
                return;
            }

            if (CtoF == true)
            {
                String Input = txtConverterInput.Text;
                ConverterInput = Convert.ToDouble(Input);    
                ConverterResult = ConverterInput * 1.8 + 32;
                txtConverterResult.Text = ConverterResult.ToString();
            }
            else
            {
                String Input = txtConverterInput.Text;
                ConverterInput = Convert.ToDouble(Input);
                ConverterResult = (ConverterInput - 32) * 5/9;
                txtConverterResult.Text = ConverterResult.ToString();
            }
            


        }

        private void txtConverterInput1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSwitchConverter_Click(object sender, EventArgs e)
        {
            txtConverterResult.Text = "";
            if (CtoF == false)
            {
                CtoF = true;
                lblCtoF.Text = "°C to °F";
            }
            else if (CtoF == true)
            {
                CtoF = false;
                lblCtoF.Text = "°F to °C";
            }
            
            
        }

        private void btnConverterConverter_Click(object sender, EventArgs e)
        {
            if (txtConverterInput.Text != "")
            {
                
                String Input = txtConverterInput.Text;
                ConverterInput = Convert.ToDouble(Input);
                
                ConverterInput = -ConverterInput;
                txtConverterInput.Text = ConverterInput.ToString();

            }
            
        }
    }
}
