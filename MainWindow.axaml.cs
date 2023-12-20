using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Linq;

namespace GabrielPhoneNumber
{
    public partial class MainWindow : Window
    {
		public MainWindow()
		{
			InitializeComponent();
            phoneButtonPlus.Click += PhonePlus;
			phoneButtonMinus.Click += PhoneMinus;
		}

		/// <summary>
		/// Увеличение числа в текстблоке на 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="rea1"></param>
		void PhonePlus(object? sender, RoutedEventArgs rea1)
		{
			long phoneInt = Convert.ToInt32(phone.Text.Substring(1, 1) + phone.Text.Substring(4, 3) + phone.Text.Substring(9, 2) + phone.Text.Substring(12, 2) + phone.Text.Substring(15)) + 1;
			if (phoneInt > 99999999999)
			{
				phoneInt = 99999999999;
			}
			string phoneString = Convert.ToString(phoneInt);
			switch (phoneString.Length)
			{
				case 1:
					phone.Text = "+0 (000) 00-00-00" + phoneString;
					break;

				case 2:
					phone.Text = "+0 (000) 00-00-0" + phoneString;
					break;

				case 3:
					phone.Text = "+0 (000) 00-00-" + phoneString;
					break;

				case 4:
					phone.Text = "+0 (000) 00-0" + phoneString.Substring(0, 1) + "-" + phoneString.Substring(1);
					break;

				case 5:
					phone.Text = "+0 (000) 00-" + phoneString.Substring(0, 2) + "-" + phoneString.Substring(2);
					break;

				case 6:
					phone.Text = "+0 (000) 0" + phoneString.Substring(0, 1) + "-" + phoneString.Substring(1, 2) + "-" + phoneString.Substring(3);
					break;

				case 7:
					phone.Text = "+0 (000) " + phoneString.Substring(0, 2) + "-" + phoneString.Substring(2, 2) + "-" + phoneString.Substring(4);
					break;

				case 8:
					phone.Text = "+0 (00" + phoneString.Substring(0, 1) + ") " + phoneString.Substring(1, 2) + "-" + phoneString.Substring(3, 2) + "-" + phoneString.Substring(5);
					break;

				case 9:
					phone.Text = "+0 (0" + phoneString.Substring(0, 2) + ") " + phoneString.Substring(2, 2) + "-" + phoneString.Substring(4, 2) + "-" + phoneString.Substring(6);
					break;

				case 10:
					phone.Text = "+0 (" + phoneString.Substring(0, 3) + ") " + phoneString.Substring(3, 2) + "-" + phoneString.Substring(5, 2) + "-" + phoneString.Substring(7);
					break;

				case 11:
					phone.Text = "+" + phoneString.Substring(0, 1) + " (" + phoneString.Substring(1, 3) + ") " + phoneString.Substring(4, 2) + "-" + phoneString.Substring(5, 2) + "-" + phoneString.Substring(7);
					break;
			}
        }

		/// <summary>
		/// Уменьшение числа в текстблоке на 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="rea1"></param>
		void PhoneMinus(object? sender, RoutedEventArgs rea1)
        {
			long phoneInt = Convert.ToInt32(phone.Text.Substring(1, 1) + phone.Text.Substring(4, 3) + phone.Text.Substring(9, 2) + phone.Text.Substring(12, 2) + phone.Text.Substring(15)) - 1;
			if (phoneInt < 0)
            {
                phoneInt = 0;
            }
            string phoneString = Convert.ToString(phoneInt);
            switch (phoneString.Length)
            {
				case 1:
					phone.Text = "+0 (000) 00-00-00" + phoneString;
					break;

				case 2:
					phone.Text = "+0 (000) 00-00-0" + phoneString;
					break;

				case 3:
					phone.Text = "+0 (000) 00-00-" + phoneString;
					break;

				case 4:
					phone.Text = "+0 (000) 00-0" + phoneString.Substring(0, 1) + "-" + phoneString.Substring(1);
					break;

				case 5:
					phone.Text = "+0 (000) 00-" + phoneString.Substring(0, 2) + "-" + phoneString.Substring(2);
					break;

				case 6:
					phone.Text = "+0 (000) 0" + phoneString.Substring(0, 1) + "-" + phoneString.Substring(1, 2) + "-" + phoneString.Substring(3);
					break;

				case 7:
					phone.Text = "+0 (000) " + phoneString.Substring(0, 2) + "-" + phoneString.Substring(2, 2) + "-" + phoneString.Substring(4);
					break;

				case 8:
					phone.Text = "+0 (00" + phoneString.Substring(0, 1) + ") " + phoneString.Substring(1, 2) + "-" + phoneString.Substring(3, 2) + "-" + phoneString.Substring(5);
					break;

				case 9:
					phone.Text = "+0 (0" + phoneString.Substring(0, 2) + ") " + phoneString.Substring(2, 2) + "-" + phoneString.Substring(4, 2) + "-" + phoneString.Substring(6);
					break;

				case 10:
					phone.Text = "+0 (" + phoneString.Substring(0, 3) + ") " + phoneString.Substring(3, 2) + "-" + phoneString.Substring(5, 2) + "-" + phoneString.Substring(7);
					break;

				case 11:
					phone.Text = "+" + phoneString.Substring(0, 1) + " (" + phoneString.Substring(1, 3) + ") " + phoneString.Substring(4, 2) + "-" + phoneString.Substring(5, 2) + "-" + phoneString.Substring(7);
					break;
			}
        }
    }
}
