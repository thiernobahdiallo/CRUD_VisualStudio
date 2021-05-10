This is an application with UI Winforms to display and modify the data stored in a database.
I used a sample database from Microsoft: https://docs.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver15&tabs=ssms
I used stored procedures to execute the bdd operations.
This is what we can do on the app:

- In the main view we can consult the product catalog on a list of products ( 1 line per product)
- Pagination with 10 | 20 | 50 products per page, to be selected by the user.
- Information for each product in main view:
- ProductModel.Name, Description (in the language selected in | fr).
- Filters (navigation) Category, subcategory, Size, ProductLine, Class, Style, ListPrice
- Search by product name or model name
- A control to show only available products (SellEndDate null) or all products.
- If all products view, we show sellStart and sellEnd dates
- In the main view, if you double click on a line corresponding to a product, it will open the details of the product in a modal window. Information to display:
   All the information available about the product (available sizes, colors, price, ...)
   Control to enable edit mode that enables the possibility of correcting the information of a product / product model. Corresponding control to save an updated product information.
