//! Interface are used when we have something that is common across many classes that we would include it in the parent class 

interface IDecorate
{
    // Add a fields
    int numberOfItems { get; set; }
    List<string> AllItems { get; set; }
    // Add a method
    void AddItem(string Item);
    void ShowItems();

}