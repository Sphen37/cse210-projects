namespace Costume;
class Program
{
    static void Main(string[] args)
    {
        List<Costume> myCostumes = new List<Costume>();
        Costume cowboy = new Costume();
        cowboy._headwear = "Cowboy Hat";
        cowboy._upperGarment = "Cowboy Shirt";
        cowboy._lowerGarment = "Cowboy Pants";
        cowboy._footwear = "Boots";
        cowboy._accessories = "Cross";
        Costume detective = new Costume();
        detective._headwear = "Top Hat";
        detective._upperGarment = "Trench Shirt";
        detective._lowerGarment = "Slacks";
        detective._footwear = "Dress Shoes";
        detective._accessories = "Sunglasses";
        myCostumes.Add(cowboy);
        myCostumes.Add(detective);
        for (int i = 0; i < myCostumes.Count; i++)
        {
            myCostumes[i].Display();
        }
    }
}
