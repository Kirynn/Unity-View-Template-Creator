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

namespace TemplateMaker {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		public MainWindow() {

			InitializeComponent();
		}

		public void InsertHeader(object sender, EventArgs e) {

			StackPanel stack = new StackPanel {
				Children = {
					new TextBlock {
						Text = "test",
						Margin = new Thickness(0, 0, 4, 0)
					},
					new TextBox {
						MinWidth = 350
					}
				},
				Orientation = Orientation.Horizontal,
				Margin = new Thickness(0, 5, 0, 5)
			};
			insert.Children.Add(stack);
		}
	}
}
