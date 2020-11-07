DAL [Data Access Layer]
> All code that is specific to the underlying data source such as creating a connection to the database, issuing SELECT, INSERT, UPDATE, and DELETE commands, and so on should be located in the DAL.
> Data Access Layers typically contain methods for accessing the underlying database data.
> In our DAL we will have methods like:
⦁	GetCategories()
> which will return information about all of the categories
⦁	GetProducts()
> which will return information about all of the products
⦁	GetProductsByCategoryID(categoryID)
 > which will return all products that belong to a specified category
⦁	GetProductByProductID(productID)
> which will return information about a particular product

BLL [Business Logic Layer]
> All condition before issuing SELECT, INSERT, UPDATE, and DELETE commands, and so on should be located in the BLL.


PATTERN
  > Presentation Layer (Web pages)
  > BLL Business Logic Layer (condition before accessing to database)
	> DAL Data Access Layer (sending request to database and return response to BLL to Web pages)
