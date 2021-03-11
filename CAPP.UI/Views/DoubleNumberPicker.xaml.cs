using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CAPP.UI.Views
{
    public partial class DoubleNumberPicker : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(DoubleNumberPicker), 
                new PropertyMetadata(0.0, new PropertyChangedCallback(OnValuePropertyChanged)));

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(DoubleNumberPicker), new PropertyMetadata(double.MaxValue));

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(DoubleNumberPicker), new PropertyMetadata(double.MinValue));

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register("Step", typeof(double), typeof(DoubleNumberPicker), new PropertyMetadata(0.1));

        private static readonly RoutedEvent ValueChangedEvent =
           EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DoubleNumberPicker));

        private readonly Regex _doubleNumberRegex;

        public event RoutedEventHandler ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set 
            {
                inputTextBox.Text = value.ToString();
                SetValue(ValueProperty, value); 
            }
        }

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public double Step
        {
            get { return (double)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        public DoubleNumberPicker()
        {
            _doubleNumberRegex = new Regex(@"^[-+]?[0-9]{0,}(\.?[0-9]{0,})$");

            InitializeComponent();
        }

        private static void OnValuePropertyChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            DoubleNumberPicker numberPicker = target as DoubleNumberPicker;
            numberPicker.inputTextBox.Text = string.Format("{0:f5}", e.NewValue);
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value < Maximum)
                Value += Step;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > Minimum)
                Value -= Step;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var tb = (TextBox)sender;
            var text = tb.Text.Insert(tb.CaretIndex, e.Text);

            e.Handled = !_doubleNumberRegex.IsMatch(text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;

            if (!_doubleNumberRegex.IsMatch(tb.Text)) 
                ResetText(tb);

            Value = Math.Round(Convert.ToDouble(tb.Text), 5);

            if (Value < Minimum) 
                Value = Minimum;

            if (Value > Maximum) 
                Value = Maximum;

            RaiseEvent(new RoutedEventArgs(ValueChangedEvent));
        }

        private void ResetText(TextBox tb)
        {
            tb.Text = "0.0";
            tb.SelectAll(); ;
        }
    }
}
