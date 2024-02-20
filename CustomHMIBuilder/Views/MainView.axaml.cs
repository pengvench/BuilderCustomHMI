using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

using System;



namespace CustomHMIBuilder.Views;

public partial class MainView : UserControl
{

    public MainView()
    {
        InitializeComponent();
    }

    private Button currentButton; // Переменная для хранения текущей кнопки

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // Обработчик события нажатия кнопки
        Button newButton = new() // Создаем новую кнопку с указанными свойствами
        {
            Content = "Новая кнопка",
            Width = 110,
            Height = 30,
            IsEnabled = false,
            
        };

        double x = 200; // Установка начальной позиции X
        double y = 200; // Установка начальной позиции Y

        TxtX.Text = x.ToString(); // Отображаем позицию X
        TxtY.Text = y.ToString(); // Отображаем позицию Y

        MainCanvas.Children.Add(newButton); // Добавляем кнопку на Canvas


        currentButton = newButton; // Сохраняем ссылку на созданную кнопку как текущую
    }

    private void ApplySettings_Click(object? sender, RoutedEventArgs e)
    {
        // Обработчик события нажатия кнопки "Применить настройки"
        if (currentButton != null)
        {
            double x = Convert.ToDouble(TxtX.Text); // Получаем значение позиции X из текстового поля
            double y = Convert.ToDouble(TxtY.Text); // Получаем значение позиции Y из текстового поля
            double scale = SliderScale.Value; // Получаем значение масштаба из слайдера

            TxtW.Text = scale.ToString(); // Отображаем значение масштаба в соответствующем текстовом поле
            TxtH.Text = scale.ToString(); // Отображаем значение масштаба в соответствующем текстовом поле

            Canvas.SetLeft(currentButton, x); // Устанавливаем позицию кнопки по горизонтали
            Canvas.SetTop(currentButton, y); // Устанавливаем позицию кнопки по вертикали
            currentButton.RenderTransform = new ScaleTransform(scale, scale); // Применяем масштаб к кнопке

            if (!string.IsNullOrEmpty(TxtName.Text)) // Проверка наличия имени в текстовом поле
            {
                currentButton.Content = TxtName.Text; // Устанавливаем содержимое кнопки как введенное имя
            }
        }
    }

}
