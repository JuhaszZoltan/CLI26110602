#nullable disable

const string FilePath = "..\\..\\..\\data\\arukeszlet.csv";

List<Product> products = [];

using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    var t = sr.ReadLine().Split(',');

    products.Add(new()
    {
        Id = int.Parse(t[0]),
        Category = t[1],
        Brand = t[2],
        Model = t[3],
        PriceHUF = int.Parse(t[4]),
        StockQty = int.Parse(t[5]),
        Rating = float.Parse(t[6].Replace('.', ','))
    });
}

#region read file

//TEST
//products.ForEach(x => Console.WriteLine($"{x}\n\t------------------"));


//IMPERATÍV (HOGYAN?)
//int c = 0;
//for (int i = 0; i < products.Count; i++)
//{
//    if (products[i].Brand == "Nova")
//    {
//        c++;
//    }
//}
//Console.WriteLine(c);

//DEKLARATÍV (MIT?)

//SELECT COUNT(*)
//FROM products
//WHERE Brand LIKE 'nova';

#endregion

var count = products.Count(p => p.Brand == "Nova");

var sum = products.Sum(p => p.StockQty);

var avg = products.Average(p => p.Rating);

var maxby = products.MaxBy(p => p.PriceHUF);

//max/min -> CSAK az értéket adja vissza
//maxby/minby -> az értékhez tartozó ELEMET adja vissza

var any = products.Any(p => p.Rating < 2);
var all = products.All(p => p.StockQty > 0);

// kiválasztás + lineáris keresés

int i = 0;
while (i < products.Count && !products[i].Model.Contains("Screen")) i++;
if (i == products.Count) Console.WriteLine("nincs screen");
else Console.WriteLine(products[i]);

// ------