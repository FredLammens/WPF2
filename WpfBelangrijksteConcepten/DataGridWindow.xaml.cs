using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBelangrijksteConcepten
{
    /// <summary>
    /// Interaction logic for DataGridWindow.xaml
    /// </summary>
    public partial class DataGridWindow : Window
    {
        public DataGridWindow()
        {
            InitializeComponent();

            List<UserD> UserDs = new List<UserD>();
            UserDs.Add(new UserD() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            UserDs.Add(new UserD() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            UserDs.Add(new UserD() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = UserDs;
        }
    }
    public class UserD
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
