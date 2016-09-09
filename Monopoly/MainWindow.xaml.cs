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

namespace Monopoly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        Case[] CaseNames<c>(int lentgh) where Case : new()
        {
            Case[] array = new Case[10];
            for (int i = 0; i < 10; ++i)
            {
                array[i] = new Case();
            }

            return array;
        }
        
        class Players
        {
            

            public Players(string name , double cash)
            {
                this.name= name;
                this.cash= cash;
            }
            public string name;
            public double cash;
            


        }//end of class

        
        Players p1= new Players("Khaled",200.0);
        Players p2 = new Players("Omar", 300.00);
        
        
      


        class Case
        {
            string Name { get; set; }
            double Value { get; set;}
        }//end on case


        private int diceRoll()
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            return result;
        }


        

        



        
        


    }//end of partiel class
}
