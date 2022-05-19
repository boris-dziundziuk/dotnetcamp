DateTime today = new DateTime(2022, 05, 12);

Product kartoshka = new Product("Картошка", 12.5, 5);
Meat myasko = new Meat("Мясо", 150, 1, Category.High, Type.Pork);
Dairy moloko = new Dairy("Молоко", 30, 1, today);
Storage sklad = new Storage(kartoshka, myasko, moloko);
Buy buy = new Buy(kartoshka);

myasko.ChangePrice(5);
moloko.ChangePrice(1);

buy.AddProduct(myasko);
buy.AddProduct(moloko);

buy.ShowAllProducts();

Console.WriteLine(sklad[1]);

sklad.AddProduct();
sklad.ShowAllProducts();