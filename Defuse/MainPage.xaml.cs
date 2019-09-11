using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Defuse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        static string bomb = new Random().Next(1, 7).ToString();
        static int score = 0;


        public MainPage()
        {
            
            InitializeComponent();
            
            myMainPage.BackgroundColor = Color.FromRgb(77, 166, 255);
            Label scoreLabel = (Label) myMainPage.FindByName("labelScore");
            scoreLabel.Text = score.ToString();
        }
            async void ButtonClicked(object sender, EventArgs e )
            {

                

                Button button = sender as Button;
                //Game over
                if (button.Text == bomb)
                {
                    myMainPage.BackgroundColor=Color.FromRgb(255, 26, 26);
                    await DisplayAlert("Bomb Exploded", "Final Score "+score, "Retry");
                    bomb = new Random().Next(1, 7).ToString();
                    score = 0;
                    myMainPage.BackgroundColor = Color.FromRgb(77, 166, 255);
                    Label scoreLabel = (Label)myMainPage.FindByName("labelScore");
                    scoreLabel.Text = score.ToString();
            }
                else
                {
                    score++;
                    Label scoreLabel = (Label)myMainPage.FindByName("labelScore");
                    scoreLabel.Text = score.ToString();
                    bomb = new Random().Next(1, 7).ToString();
                    
                 }
            }
        }
    }

