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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MAIN.xaml
	/// </summary>
	public partial class MAIN : Window
	{
		public MAIN()
		{
			InitializeComponent();
		}
		Image img = new Image();

		DispatcherTimer timer = new DispatcherTimer();
		Random rnd = new Random();
        MediaPlayer player = new MediaPlayer();
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (this.Title == "Easy")
            {

                BOX.Visibility = Visibility.Hidden;
                if (rnd.Next(1, 3) > 1)
                {
                    Uri uri = new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/vasin.jpg", UriKind.Absolute);
                    img.Source = new BitmapImage(uri);
                    img.Height = 20; img.Width = 20;
                    Canvas.SetTop(img, 20); Canvas.SetLeft(img, 50);
                    myCanvas.Children.Add(img);
                    timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
                    timer.IsEnabled = true;
                    timer.Tick += ClockFunc;
                    text.Text = "ВЫ ВЫБИЛИ ВЕКТОРА ВАСИНА";
                }
				else
				{
                    Uri uri = new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/нигер.jpg", UriKind.Absolute);
                    img.Source = new BitmapImage(uri);
                    img.Height = 200; img.Width = 200;
                    Canvas.SetTop(img, 20); Canvas.SetLeft(img, 50);
                    myCanvas.Children.Add(img);
                    player.Open(new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/Aron Wright - In The Woods.mp3", UriKind.Absolute));
                    player.Position = new TimeSpan(0, 0, 0, 0, 1);
                    player.Volume = 1;
                    player.Play();
                    text.Text = "ПОПРОБУЙТЕ ЕЩЕ РАЗ, ПЕРЕЗАПУСТИВ ПРОГРАММУ";
                }
            }
            if (this.Title == "Hard")
            {
                BOX.Visibility = Visibility.Hidden;
                if (rnd.Next(1, 1000) < 10)
                {
                    Uri uri = new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/vasin.jpg", UriKind.Absolute);
                    img.Source = new BitmapImage(uri);
                    img.Height = 20; img.Width = 20;
                    Canvas.SetTop(img, 20); Canvas.SetLeft(img, 50);
                    myCanvas.Children.Add(img);
                    timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
                    timer.IsEnabled = true;
                    timer.Tick += ClockFunc;
                    text.Text = "ВЫ ВЫБИЛИ ВЕКТОРА ВАСИНА";
                }
                else
                {
                    Uri uri = new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/нигер.jpg", UriKind.Absolute);
                    img.Source = new BitmapImage(uri);
                    img.Height = 200; img.Width = 200;
                    Canvas.SetTop(img, 20); Canvas.SetLeft(img, 50);
                    myCanvas.Children.Add(img);
                    player.Open(new Uri("C:/Users/Dmitriy/Desktop/С# 9 класс/WpfApp1/WpfApp1/Aron Wright - In The Woods.mp3", UriKind.Absolute));
                    player.Position = new TimeSpan(0, 0, 0, 0, 1);
                    player.Volume = 1;
                    player.Play();
                    text.Text = "ПОПРОБУЙТЕ ЕЩЕ РАЗ, ПЕРЕЗАПУСТИВ ПРОГРАММУ";
                }
            }
        }
        void ClockFunc(object sender, EventArgs e)
        {
            img.Height += 1;
            img.Width += 1;
            if (img.Height > 200)
            {
                img.Height = 200;
                img.Width = 200;
            }
        }

		private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
		{
            if(BOX.Visibility==Visibility.Visible)BOX.Visibility = Visibility.Hidden;
		}

		private void Grid_KeyUp(object sender, KeyEventArgs e)
		{
            text.Text = "Пробуйте на другие клавиши, если еще не нашли..";
		}

		private void Grid_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.Key.ToString() == "R")
            {
                text.Text = "Вы нашли пасхалку";
            }
        }
	}
}
