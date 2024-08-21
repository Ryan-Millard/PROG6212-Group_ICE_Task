using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EventManagementSystem
{
	public partial class MainWindow : Window
	{
		public ObservableCollection<Event> Events { get; set; } = new ObservableCollection<Event>();
		private ObservableCollection<Event> _filteredEvents = new ObservableCollection<Event>();

		public MainWindow()
		{
			InitializeComponent();
			LoadEvents();
			lbEvents.ItemsSource = Events;  // Bind the collection to the ListBox
		}

		private void LoadEvents()
		{
			Events = new ObservableCollection<Event>
			{
				new Event { Name = "Science Seminar", Department = "Science", EventType = "Seminar", Date = new DateTime(2024, 9, 1) },
				new Event { Name = "Arts Workshop", Department = "Arts", EventType = "Workshop", Date = new DateTime(2024, 9, 5) },
				new Event { Name = "Engineering Conference", Department = "Engineering", EventType = "Conference", Date = new DateTime(2024, 9, 10) },
				new Event { Name = "Business Social", Department = "Business", EventType = "Social", Date = new DateTime(2024, 9, 15) },
				new Event { Name = "Technology Expo", Department = "Technology", EventType = "Expo", Date = new DateTime(2024, 9, 20) },
				new Event { Name = "Literature Reading", Department = "Arts", EventType = "Reading", Date = new DateTime(2024, 9, 25) },
				new Event { Name = "Mathematics Olympiad", Department = "Science", EventType = "Competition", Date = new DateTime(2024, 9, 30) },
				new Event { Name = "Networking Mixer", Department = "Business", EventType = "Mixer", Date = new DateTime(2024, 10, 2) },
				new Event { Name = "Music Festival", Department = "Arts", EventType = "Festival", Date = new DateTime(2024, 10, 7) },
				new Event { Name = "Innovation Workshop", Department = "Engineering", EventType = "Workshop", Date = new DateTime(2024, 10, 12) },
				new Event { Name = "Health Fair", Department = "Health", EventType = "Fair", Date = new DateTime(2024, 10, 18) },
				new Event { Name = "Career Development Seminar", Department = "Business", EventType = "Seminar", Date = new DateTime(2024, 10, 23) },
				new Event { Name = "Art Exhibition", Department = "Arts", EventType = "Exhibition", Date = new DateTime(2024, 11, 1) },
				new Event { Name = "Entrepreneurship Panel", Department = "Business", EventType = "Panel", Date = new DateTime(2024, 11, 10) }
			};
			_filteredEvents = new ObservableCollection<Event>(Events);
		}

		private void OnSearchClick(object sender, RoutedEventArgs e)
		{
			// Get the contents of the ComboBoxes and the DatePicker
			var selectedDepartment = (cbFilterByDepartment.SelectedItem as ComboBoxItem)?.Content.ToString();
			var selectedEventType = (cbFilterByType.SelectedItem as ComboBoxItem)?.Content.ToString();
			var selectedDate = dpFilterByDate.SelectedDate;

			var filtered = Events.AsEnumerable()
				.Where(e => (selectedDepartment == "All Departments" || e.Department == selectedDepartment) &&
						(selectedEventType == "All Events" || e.EventType == selectedEventType) &&
						(!selectedDate.HasValue || e.Date.Date == selectedDate.Value.Date));

			_filteredEvents = new ObservableCollection<Event>(filtered);
			lbEvents.ItemsSource = _filteredEvents;
		}

		private void OnClearDateClick(object sender, RoutedEventArgs e)
		{
			dpFilterByDate.SelectedDate = null; // Clear the selected date
			OnSearchClick(sender, e); // Reapply the search to update the filtered events
		}


		private void lbEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (lbEvents.SelectedItem is Event selectedEvent)
			{
				tbEventDetails.Text = $"Name: {selectedEvent.Name}\n" +
					$"Department: {selectedEvent.Department}\n" +
					$"Type: {selectedEvent.EventType}\n" +
					$"Date: {selectedEvent.Date:MMMM d, yyyy}";
			}
		}
	}

	public class Event
	{
		public string Name { get; set; } = string.Empty;
		public string Department { get; set; } = string.Empty;
		public string EventType { get; set; } = string.Empty;
		public DateTime Date { get; set; }
	}
}

