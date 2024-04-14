namespace Prototype
{

    // Клас Virus як прототип
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        // Метод для додавання дитини вірусу
        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        // Метод для клонування
        public object Clone()
        {
            Virus clone = new Virus(Weight, Age, Name, Type);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight}");
            foreach (var child in Children)
            {
                child.DisplayInfo();
            }
        }
    }
}
