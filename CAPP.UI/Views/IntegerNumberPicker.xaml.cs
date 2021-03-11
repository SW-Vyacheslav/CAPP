using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CAPP.UI.Views
{
    public partial class IntegerNumberPicker : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(IntegerNumberPicker), 
                new PropertyMetadata(0, new PropertyChangedCallback(OnValuePropertyChanged)));

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(int), typeof(IntegerNumberPicker), new PropertyMetadata(int.MaxValue));

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(int), typeof(IntegerNumberPicker), new PropertyMetadata(int.MinValue));

        private static readonly RoutedEvent ValueChangedEvent =
           EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(IntegerNumberPicker));

        private readonly Regex _integerNumberRegex;

        public event RoutedEventHandler ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set 
            {
                inputTextBox.Text = value.ToString();
                SetValue(ValueProperty, value); 
            }
        }

        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public IntegerNumberPicker()
        {
            _integerNumberRegex = new Regex(@"^(\+|-)?\d+$");

            InitializeComponent();
        }

        private static void OnValuePropertyChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            IntegerNumberPicker numberPicker = target as IntegerNumberPicker;
            numberPicker.inputTextBox.Text = e.NewValue.ToString();
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value < Maximum)
                Value++;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > Minimum)
                Value--;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var tb = (TextBox)sender;
            var text = tb.Text.Insert(tb.CaretIndex, e.Text);

            e.Handled = !_integerNumberRegex.IsMatch(text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;

            if (!_integerNumberRegex.IsMatch(tb.Text)) 
                ResetText(tb);

            Value = Convert.ToInt32(tb.Text);

            if (Value < Minimum) 
                Value = Minimum;

            if (Value > Maximum) 
                Value = Maximum;

            RaiseEvent(new RoutedEventArgs(ValueChangedEvent));
        }

        private void ResetText(TextBox tb)
        {
            tb.Text = "0";
            tb.SelectAll(); ;
        }
    }
}
