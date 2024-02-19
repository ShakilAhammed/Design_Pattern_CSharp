using Specification;

Product p = new Product("Green Tea", 120, "Tea is a drink", Color.Green);
Product p1 = new Product("Apple", 110, "Apple is a fruit", Color.Green);
Product p2 = new Product("Beer", 90, "Banana is a drink", Color.Red);
Product p3 = new Product("Grape", 80, "Grape is a fruit", Color.Blue);

List<Product> products = new List<Product>();
products.Add(p);
products.Add(p1);
products.Add(p2);
products.Add(p3);

// specify color
ColorSpecification ColorSpecification = new ColorSpecification(Color.Green);

//specify price

PriceGreaterThanSpecification PriceGreaterThanSpecification = new PriceGreaterThanSpecification(80);


AndSpecification<Product> andSpecification = new AndSpecification<Product>(ColorSpecification, PriceGreaterThanSpecification);

List<Product>filteredProducts = products.FindAll(p =>andSpecification.IsSatisfiedBy(p));

filteredProducts.ForEach(p => { Console.WriteLine(p.Name); });
    
