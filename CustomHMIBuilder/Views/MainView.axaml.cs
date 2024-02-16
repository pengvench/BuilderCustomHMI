using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Animation;
using System.Diagnostics;
using Avalonia.Animation.Easings;
using Avalonia.Markup.Xaml;
using System;
using System.Windows;
using System.Collections.Generic;


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

        txtX.Text = x.ToString(); // Отображаем позицию X
        txtY.Text = y.ToString(); // Отображаем позицию Y

        MainCanvas.Children.Add(newButton); // Добавляем кнопку на Canvas


        currentButton = newButton; // Сохраняем ссылку на созданную кнопку как текущую
    }

    private void ApplySettings_Click(object? sender, RoutedEventArgs e)
    {
        // Обработчик события нажатия кнопки "Применить настройки"
        if (currentButton != null)
        {
            double x = Convert.ToDouble(txtX.Text); // Получаем значение позиции X из текстового поля
            double y = Convert.ToDouble(txtY.Text); // Получаем значение позиции Y из текстового поля
            double scale = sliderScale.Value; // Получаем значение масштаба из слайдера

            txtW.Text = scale.ToString(); // Отображаем значение масштаба в соответствующем текстовом поле
            txtH.Text = scale.ToString(); // Отображаем значение масштаба в соответствующем текстовом поле

            Canvas.SetLeft(currentButton, x); // Устанавливаем позицию кнопки по горизонтали
            Canvas.SetTop(currentButton, y); // Устанавливаем позицию кнопки по вертикали
            currentButton.RenderTransform = new ScaleTransform(scale, scale); // Применяем масштаб к кнопке

            if (!string.IsNullOrEmpty(txtName.Text)) // Проверка наличия имени в текстовом поле
            {
                currentButton.Content = txtName.Text; // Устанавливаем содержимое кнопки как введенное имя
            }
        }
    }

}
