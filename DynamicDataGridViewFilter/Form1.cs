using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DynamicDataGridViewFilter
{
    public partial class Form1 : Form
    {
        BindingList<Person> People { get; set; } = new BindingList<Person>();

        public Form1()
        {

            InitializeComponent();

            FeaturesGridView.DataSource = People;
            People.Add(new Person(1, "Hans", "Somewhere", "Somestreet"));
            People.Add(new Person(2, "Jens", "Somewhere", "Somestreet"));


            FeaturesGridView.DataBindingComplete += FeaturesGridView_DataBindingComplete;
        }

        private void FeaturesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Console.WriteLine("Complete");
            FeaturesGridView.ColumnDisplayIndexChanged += FeaturesGridView_ColumnDisplayIndexChanged1;
        }

        private void FeaturesGridView_ColumnDisplayIndexChanged1(object sender, DataGridViewColumnEventArgs e)
        {
            MessageBox.Show($"{e.Column.Name} changed to index: {e.Column.DisplayIndex}");
        }
    }
}
