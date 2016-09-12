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


        int turnCount;
        string nameOne;
        string nameTwo;

        class Player
        {
            public string Name { get; set; }
            public double Cash {get; set;}
            public int Position { get; set; }

           public Player(string name,double cash, int position)
            {
                this.name = name;
                this.cash = cash;
                this.position = position;
            }

            string name;
            double  cash;
            int position;
                
        }//End of class player


        private void button_Click(object sender, RoutedEventArgs e)
        {
            turnCount = 0;
            nameOne = tbName1.Text;
            nameTwo = tbName2.Text;

            if ((nameOne.Length<2) || (nameTwo.Length<2))
            {
                MessageBox.Show("Add a player, cant player alone ");
                return;
            }
            MessageBox.Show("Ok, Lets Start");
               tbName1.IsEnabled = false;
               tbName2.IsEnabled = false;
            Player playerOne = new Player(nameOne, 1000.00, 1);
            
            
        }//end of button_Click

        Player playerTwo = new Player(nameTwo, 1000.00, 1);


        private void btRollDice_Click(object sender, RoutedEventArgs e)
        {
            int result;
            int position = 2;
            Random rnd = new Random();
            result = rnd.Next(1, 7);
            int result1 = rnd.Next(1, 7);
            int sumDice = result + result1;

            MessageBox.Show("Player move "+sumDice+" squares");
           // MessageBox.Show("Player move "+ position+"squares");
            

            if (turnCount % 2 == 0)
            {
              
                position = +sumDice;
                playerTwo.Position = position;
                MessageBox.Show(""+position);

            }
            
           
                position=+sumDice;
                playerTwo.Position = position;
                MessageBox.Show("New Position of playerTwo is" + playerTwo.Position);

            

            turnCount++;
        }//end of roll dice

        private void btNext_Click(object sender, RoutedEventArgs e)
        {


            if (turnCount % 2 == 0)
            {
                MessageBox.Show("Roll The Dice", playerOne.name);
            }
            else {
                MessageBox.Show("Roll The Dice", playerTwo.name);
            }





        }//end of end button




    }//end of main window
}
