using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AACalculator.Core
{
    public static class TextBoxService
    {

        public static readonly DependencyProperty CantBeEmptyProperty = DependencyProperty.RegisterAttached(
          "CantBeEmpty",
          typeof(bool),
          typeof(TextBoxService),
          new UIPropertyMetadata(false, CantBeEmptyPropertyChanged));

        public static readonly DependencyProperty IsNumericOnlyProperty = DependencyProperty.RegisterAttached(
           "IsNumericOnly",
           typeof(bool),
           typeof(TextBoxService),
           new UIPropertyMetadata(false, OnIsNumericOnlyChanged));

        public static readonly DependencyProperty IsSelectedOnFocusProperty = DependencyProperty.RegisterAttached(
            "IsSelectedOnFocus",
            typeof(bool),
            typeof(TextBoxService),
            new UIPropertyMetadata(false, OnIsSelectedOnFocusChanged));


        private static void CantBeEmptyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var CantBeEmptyProperty = (bool)e.NewValue;
            var textBox = (TextBox)d;

            if (CantBeEmptyProperty)
            {
                textBox.LostFocus += ReplaceEmptyWithOne;
            }
            else
            {
                textBox.LostFocus -= ReplaceEmptyWithOne;
            }
        }

        private static void OnIsSelectedOnFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var isSelectedOnFocus = (bool)e.NewValue;
            var textBox = (TextBox)d;

            if (isSelectedOnFocus)
            {
                textBox.GotFocus += TextBoxOnGotFocus;
            }
            else
            {
                textBox.GotFocus -= TextBoxOnGotFocus;
            }
        }

        private static void TextBoxOnGotFocus(object sender, RoutedEventArgs routedEventArgs)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;
            textBox.SelectAll();
        }

        public static bool GetCantBeEmpty(DependencyObject d)
        {
            return (bool)d.GetValue(CantBeEmptyProperty);
        }

        public static void SetCantBeEmpty(DependencyObject d, bool value)
        {
            d.SetValue(CantBeEmptyProperty, value);
        }

        public static bool GetIsNumericOnly(DependencyObject d)
        {
            return (bool)d.GetValue(IsNumericOnlyProperty);
        }

        public static void SetIsNumericOnly(DependencyObject d, bool value)
        {
            d.SetValue(IsNumericOnlyProperty, value);
        }

        public static bool GetIsSelectedOnFocus(DependencyObject d)
        {
            return (bool)d.GetValue(IsSelectedOnFocusProperty);
        }

        public static void SetIsSelectedOnFocus(DependencyObject d, bool value)
        {
            d.SetValue(IsSelectedOnFocusProperty, value);
        }


        private static void OnIsNumericOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var isNumericOnly = (bool)e.NewValue;
            var textBox = (TextBox)d;

            if (isNumericOnly)
            {
                textBox.PreviewTextInput += BlockNonDigitCharacters;
                textBox.PreviewKeyDown += ReviewKeyDown;
            }
            else
            {
                textBox.PreviewTextInput -= BlockNonDigitCharacters;
                textBox.PreviewKeyDown -= ReviewKeyDown;
            }
        }

        private static void BlockNonDigitCharacters(object sender, TextCompositionEventArgs e)
        {
            foreach (char ch in e.Text)
            {
                if (!(Char.IsDigit(ch) || ch == '.')) { e.Handled = true; }  //Changed to accomodate decimal point
            }
        }

        private static void ReviewKeyDown(object sender, KeyEventArgs e)
        {
            // Disallow the space key, which doesn't raise a PreviewTextInput event.
            if (e.Key == Key.Space) { e.Handled = true; }
        }

        //foreach (char ch in e.Text)
        //   {
        //       if (!Char.IsDigit(ch)) { e.Handled = true; }
        //   }
        private static void ReplaceEmptyWithOne(object sender, RoutedEventArgs routedEventArgs)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Length < 1)
            {
                textBox.Text = "0";
            }
        }

    }
}
