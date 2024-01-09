Chair stool = new Chair("Brown", "Wood", 20.23, true, 3, true);

Console.WriteLine(stool.outdoor);

// Table.color = "AAAAA";

// Console.WriteLine(Table.color);

// Table.ChangeColor("RED");


Chair Chair = new Chair("Black", "Metal", 56.23, false, 4, true);

// Console.WriteLine(Chair.numLegs);

Table outsideTable = new Table("Pink", "Wood", 23.23, true);


Chair.ChangeColor("Red");

// Polymorphism

List<Furniture> AllFurniture = new List<Furniture>();

AllFurniture.Add(Chair);

// Interface

Table newTable = new Table("grey", "plastic", 14.56, true);

newTable.AddItem("Plate set");
newTable.AddItem("flowers");

newTable.ShowItems();



