internal class Product
{
    public int Id { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int PriceHUF { get; set; }
    public int StockQty { get; set; }
    public float Rating { get; set; }

    public override string ToString() =>
        $"\t[ID:{Id}] {Brand} - {Model}\n" +
        $"\ttermék kategória: {Category}\n" +
        $"\tÁr: {PriceHUF:C0}\n" +
        $"\tKészleten: {StockQty} db\n" +
        $"\tÉrtékelés: {Rating:0.0}/5.0";
}