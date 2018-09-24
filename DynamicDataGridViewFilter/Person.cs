namespace DynamicDataGridViewFilter
{
    public partial class Form1
    {
        class Person
        {

            public Person(int id, string name, string location, string street)
            {
                Id = id;
                Name = name;
                Location = location;
                Street = street;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Street { get; set; }
        }
    }
}
