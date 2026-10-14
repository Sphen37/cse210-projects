namespace Costume;
class Costume
{
    public string _headwear = "";
    public string _upperGarment = "";
    public string _lowerGarment = "";
    public string _footwear = "";
    public string _accessories = "";

    public void Display()
    {
        Console.WriteLine($"Costume specifitcation:\nHead: {_headwear}\nTop: {_upperGarment}\nBottom: {_lowerGarment}\nShoes: {_footwear}\nBling: {_accessories}");
    }
}