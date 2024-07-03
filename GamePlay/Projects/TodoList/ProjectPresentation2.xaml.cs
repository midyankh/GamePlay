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
using System.Windows.Shapes;

namespace gameCenter.Projects.TodoList
{
    /// <summary>
    /// Interaction logic for ProjectPresentation2.xaml
    /// </summary>
    public partial class ProjectPresentation2 : Window
    {
        private Window? currentproject;
        public ProjectPresentation2()
        {
            InitializeComponent();
        }

        public void OnStart(string title, string projectDescription, ImageSource imageSoursce, Window project)
        {
            TitleLabel.Content = title;
            ProjectText.Text = projectDescription;
            ProjectImage.Source = imageSoursce;
            currentproject = project;
        }

        private void ProjectImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
            currentproject!.ShowDialog();
            currentproject!.Close();
        }

        private void ReturnToMain(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Tick(object sender, EventArgs e)
        {
            DateLabel.Content = DateTime.UtcNow.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
    }
}
