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
using System.Windows.Threading;
using gameCenter.Projects.CurrencyConverter;
using gameCenter.Projects.Project1;
using gameCenter.Projects.TodoList;

namespace GamePlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateLabel.Content = DateTime.UtcNow.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            // DispatcherTimer is the regular timer. It fires its Tick event on the UI thread,
            // you can do anything you want with the UI. System. Timers. Timer is an asynchronous timer;
            // its Elapsed event runs on a thread pool thread

            DispatcherTimer clock = new()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            clock.Tick += Tick!;
            clock.Start();
        }

        // DateTime event is used to built-in class its used to store dates and parse them to and from strings
        private void Tick(object sender, EventArgs e)
        {
            DateLabel.Content = DateTime.UtcNow.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        // MouseEnter event is when you point the mouse at an image it fuctions , it has many other events 
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (sender as Image)!;
            image.Opacity = 0.7;
            GameText.Content = (image.Name) switch
            {
                "Image1" => "a User Management System",
                "Image2" => "To Do List",
                "Image3" => "Currency Convertor",
                "Image4" => "Trivia",
                "Image5" => "Calculator",
                "Image6" => "Task Manegement Software",
                _ => "please pick an app"
            };
        }

        // image_MouseLeave is an event that includes many other events where you can run these events to use them in MainWindow.xaml.
        // and its main function is when the mouse is entering and leaving the image 
        // using Mouse events ,Mouse = up ,down , rightbuttomup, rightbuttomdown, leftbuttomup , leftbuttomdown

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image)!.Opacity = 1;
            GameText.Content = "please pick a game";
        }

        private void Image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Project1 project1 = new();
            ProjectPresentation2 presentetion = new();
            presentetion.OnStart(
                "User Managment", "User management is a system to handle activities related to individuals' access to devices, software," +
                " and services. It focuses on managing permissions for access and actions as well as monitoring usage. " +
                "Functions of user management include: Providing users with authenticated access.",
                Image1.Source,
                project1
            );
            presentetion.ShowDialog();
        }


        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TodoList todoList = new();
            ProjectPresentation2 presentation = new();

            presentation.OnStart("To-Do List", " A project management to-do list is a collection of tasks that outlines the work a project" +
                " manager or team plans to complete during a project." +
                " This list helps project managers understand the various " +
                "tasks of a project so they can assign work to team members and fulfill their own duties.", Image2.Source, todoList);
            Hide();
            presentation.ShowDialog();
            Show();
            

        }

        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CurrencyConvertorView currencyconventer = new();
            ProjectPresentation2 presentetion = new();
            presentetion.OnStart(
                "Currency Convertor", "Currency conversion is the process of changing one currency into the currency of another country." +
                " For example, changing Australian dollars (AUD) into US Dollars (USD). Currencies are converted using an exchange rate. " +
                "This rate is the relative price of two currencies. " +
                "",
                Image3.Source, currencyconventer
            );
            presentetion.ShowDialog();
        }



        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }



    }
}
