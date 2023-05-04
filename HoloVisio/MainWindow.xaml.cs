using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace HoloVisio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Это для 4х видео
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4;*.avi;*.wmv)|*.mp4;*.avi;*.wmv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string videoPath = openFileDialog.FileName;

                MediaElement1.Source = new Uri(videoPath);
                MediaElement1.Stretch = Stretch.Fill;

                MediaElement2.Source = new Uri(videoPath);
                MediaElement2.Stretch = Stretch.Fill;

                MediaElement3.Source = new Uri(videoPath);
                MediaElement3.Stretch = Stretch.Fill;

                MediaElement4.Source = new Uri(videoPath);
                MediaElement4.Stretch = Stretch.Fill;
            }
        }
        // Это для 1 видео
        private void bt_onevideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4;*.avi;*.wmv)|*.mp4;*.avi;*.wmv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string videoPath = openFileDialog.FileName;

                me_onevideo.Source = new Uri(videoPath);
                me_onevideo.Stretch = Stretch.Fill;
            }
        }
        // Это для выхода
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Это для цикла 4х видео
        private void MediaElement2_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.Zero;
        }
        //Это для цикла 4х видео
        private void MediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.Zero;
        }
        //Это для цикла 4х видео
        private void MediaElement4_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.Zero;
        }
        //Это для цикла 4х видео
        private void MediaElement3_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.Zero;
        }
        //Это для цикла одного видео
        private void me_onevideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.Zero;
        }
    }
}
