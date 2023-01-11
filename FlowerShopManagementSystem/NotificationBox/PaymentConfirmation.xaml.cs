﻿using System.Windows;
using System.Windows.Input;

namespace FlowerShopManagementSystem.NotificationBox
{
    /// <summary>
    /// Interaction logic for PaymentConfirmation.xaml
    /// </summary>
    public partial class PaymentConfirmation : Window
    {
        public static bool isBtnConfirmClicked = false;
        public PaymentConfirmation()
        {
            InitializeComponent();
            isBtnConfirmClicked = true;
        }

        private void btnCancelConfirm_Click(object sender, RoutedEventArgs e)
        {
            isBtnConfirmClicked = false;
            Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void exitConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            isBtnConfirmClicked = false;
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
