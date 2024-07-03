using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace MediaCollectionApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }
        public Item SelectedItem { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            // Inicjalizacja kolekcji
            Items = new ObservableCollection<Item>();
            Items.Add(new Item { Title = "Film 1", DirectorOrArtist = "Reżyser 1", PublisherOrStudio = "Studio 1", MediaType = MediaType.DVD });
            Items.Add(new Item { Title = "Album 1", DirectorOrArtist = "Artysta 1", PublisherOrStudio = "Wydawca 1", MediaType = MediaType.CD });
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            // Dodawanie nowego elementu
            Item newItem = new Item();
            // Możesz otworzyć nowe okno do dodawania szczegółów nowego elementu tutaj
            Items.Add(newItem);
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedItem != null)
            {
                // Możesz otworzyć nowe okno do edycji szczegółów wybranego elementu tutaj
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedItem != null)
            {
                Items.Remove(SelectedItem);
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            // Logika importowania danych z pliku
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            // Logika eksportowania danych do pliku
        }
    }
}
