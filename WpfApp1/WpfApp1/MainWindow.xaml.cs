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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public bool HardMode;
		public MainWindow()
		{
			InitializeComponent();
		}
		MAIN window = new MAIN();
		private void Start_Click(object sender, RoutedEventArgs e)
		{
			
			if (Easy.IsChecked == true)
			{
				HardMode = false;
				window.Topmost = true;
				window.Title = "Easy";
				window.Show();
			}
			else if(hard.IsChecked == true)
			{
				HardMode = true;
				window.Topmost = true;
				window.Title = "Hard";
				window.Show();
			}
		}
	}
}
