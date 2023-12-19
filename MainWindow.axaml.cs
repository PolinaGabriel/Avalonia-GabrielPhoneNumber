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
            phoneButton.Click += Phone; //увеличениче числа в текстбоксе на 1 по нажатию кнопки
		}

		void Phone(object? sender, RoutedEventArgs rea1) //увеличениче числа в текстбоксе на 1
		{
			string phoneString = Convert.ToString(Convert.ToInt32(phone.Text) + 1);
			switch (phoneString.Length) //добавление нулей в начало числа для сохранения формата телефонного номера
			{
				case 1:
					phone.Text = "0000000000" + phoneString;
					break;

				case 2:
					phone.Text = "000000000" + phoneString;
					break;

				case 3:
					phone.Text = "00000000" + phoneString;
					break;

				case 4:
					phone.Text = "0000000" + phoneString;
					break;

				case 5:
					phone.Text = "000000" + phoneString;
					break;

				case 6:
					phone.Text = "00000" + phoneString;
					break;

				case 7:
					phone.Text = "0000" + phoneString;
					break;

				case 8:
					phone.Text = "000" + phoneString;
					break;

				case 9:
					phone.Text = "00" + phoneString;
					break;

				case 10:
					phone.Text = "0" + phoneString;
					break;

				case 11:
					phone.Text = phoneString;
					break;
			}
        }
    }
}