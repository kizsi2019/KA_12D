using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Events = new ObservableCollection<CalendarEvent>();
            eventGrid.ItemsSource = Events;
        }
            public ObservableCollection<CalendarEvent> Events { get; set; }


        private void DatePicker_SelectedDateChanged(object sender, EventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                var selectedDate = datePicker.SelectedDate.Value;
                var newEvent = new CalendarEvent { Date = selectedDate, EventName = "New Event" };
                Events.Add(newEvent);
            }
        }

        private void eventGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (eventGrid.SelectedItem != null)
            {
                var selectedEvent = (CalendarEvent)eventGrid.SelectedItem;
                Events.Remove(selectedEvent);
            }
        }
    }
    

    public class CalendarEvent
    {
        public DateTime Date { get; set; }
        public string EventName { get; set; }
    }
}