using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String Strok = null;
        private String Van = null;
        private String Two = null;
        private String Znak = null;
        private Double Van_Namber = 0;
        private Double Two_Namber = 0;
        private bool Flag_Nambers=true;
        private bool Flag_Drob = true;
        private bool Flag_Posle_Ravno = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if(button.Content.ToString()=="/" || button.Content.ToString() == "*" || button.Content.ToString() == "-" || button.Content.ToString() == "+")
            {
               
                if (Flag_Nambers)
                {
                    Znak = button.Content.ToString();
                    Stroka_Sostoyniy();
                    Flag_Nambers = false;
                    Flag_Posle_Ravno = false;
                    Two = null;
                    Flag_Drob = true;
                    Two_Namber = 0;
                }
                else
                {
                    Calculation();
                    Znak = null;
                    if (String.IsNullOrEmpty(Znak))
                    {
                        Znak = button.Content.ToString();
                        Stroka_Sostoyniy();
                    }
                    Flag_Posle_Ravno = false;
                    Two = null;
                    Two_Namber = 0;
                    Flag_Drob = true;
                }

            }
            else if(button.Content.ToString() == "CE")
            {
                if(Flag_Nambers)
                {
                    Van = null;
                    Van_Namber = 0;
                    this.Monitor.Text = "0";
                }
                else
                {
                    Two = null;
                    Two_Namber = 0;
                    this.Monitor.Text = "0";
                }
            }
            else if(button.Content.ToString() == "C")
            {
                Flag_Nambers = true;
                Van = null;
                Two = null;
                Van_Namber = 0;
                Two_Namber = 0;
                this.Monitor.Text = "0";
                this.Stroka.Text = null;
                Strok = null;
            }
            else if(button.Content.ToString() == "=")
            {
                if (String.IsNullOrEmpty(Two)) { return; }
                Calculation();
                Flag_Nambers = true;
                Flag_Posle_Ravno = true;
                this.Stroka.Text = null;
                Strok = null;
            }
            else if(button.Name== "Clear_Namber")
            {
                if (Flag_Nambers)
                {
                    if (String.IsNullOrEmpty(Van)) { return; }
                    if ((Van.Length-1)== 0 ) { Van_Namber = 0; this.Monitor.Text = "0"; Van = null; }
                    else
                    {
                        Van = Van.Remove(Van.Length - 1, 1);
                        Van_Namber = Convert.ToDouble(Van);
                        this.Monitor.Text = Van;
                    }
                    
                }
                else
                {
                    if (String.IsNullOrEmpty(Two)) { return; }
                    if ((Two.Length - 1) == 0) { Two_Namber = 0; this.Monitor.Text = "0"; Two = null; }
                    else
                    {
                        Two = Two.Remove(Two.Length - 1, 1);
                        Two_Namber = Convert.ToDouble(Two);
                        this.Monitor.Text = Two;
                    }
                }
            }
            else if(button.Content.ToString() == ",")
            {
                if(Flag_Drob)
                {
                    if (Flag_Nambers)
                    {
                        if(String.IsNullOrEmpty(Van))
                        {
                            Van= "0"+ button.Content.ToString();
                        }
                        else
                        {
                            Van += button.Content.ToString();
                        }
                        this.Monitor.Text = Van; 
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(Two))
                        {
                            Two = "0" + button.Content.ToString();
                        }
                        else
                        {
                            Two += button.Content.ToString();
                        }
                        this.Monitor.Text = Two;
                    }
                    Flag_Drob = false;
                }
            }
            else
            {
                if (Flag_Posle_Ravno)
                {
                    Van = null;
                    Flag_Posle_Ravno = false;
                    Flag_Drob = true;
                }
                if(Flag_Nambers)
                {
                    if (Van == "0") { Van = null; }
                    Van += button.Content.ToString();
                    this.Monitor.Text = Van;
                    Van_Namber = Convert.ToDouble(Van);
                }
                else
                {
                    if (Two == "0") { Two = null; }
                    Two += button.Content.ToString();
                    this.Monitor.Text = Two;
                    Two_Namber = Convert.ToDouble(Two);
                }
            }
        }
        private void Calculation()
        {
            
            if (Znak == "+")
            {
                Van_Namber += Two_Namber;
                Van = Van_Namber.ToString();
                this.Monitor.Text = Van;
            }
            else if(Znak == "-")
            {
                Van_Namber -= Two_Namber;
                Van = Van_Namber.ToString();
                this.Monitor.Text = Van;
            }
            else if (Znak == "*")
            {
                if (String.IsNullOrEmpty(Two)) { return; }
                Van_Namber *= Two_Namber;
                Van = Van_Namber.ToString();
                this.Monitor.Text = Van;
            }
            else if (Znak == "/")
            {
                if (String.IsNullOrEmpty(Two)) { return; }
                if(Two=="0")
                {
                    Flag_Nambers = true;
                    Flag_Posle_Ravno = true;
                    this.Stroka.Text = null;
                    Strok = null;
                    this.Monitor.Text = "Делить на 0 нельзя!";
                    Van = null;
                    Van_Namber = 0;
                    return;
                }
                Van_Namber /= Two_Namber;
                Van = Van_Namber.ToString();
                this.Monitor.Text = Van;
            }
        }
        private void Stroka_Sostoyniy()
        {
            if (Van == "0,") { Van = Van.TrimEnd(",".ToCharArray()); }
            if (Two == "0,") { Two = Two.TrimEnd(",".ToCharArray()); }
            if (Flag_Nambers)
            {
                if (String.IsNullOrEmpty(Van)) { Van = "0"; }
                Strok += Van + Znak;
                this.Stroka.Text = Strok;
            }
            else
            {
                if (String.IsNullOrEmpty(Two)) { Strok = Strok.Trim("+-/*".ToCharArray()); }
                Strok += Two + Znak;
                this.Stroka.Text = Strok;
            }
        }
    }
}
