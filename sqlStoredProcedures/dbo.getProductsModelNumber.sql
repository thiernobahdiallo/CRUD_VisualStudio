/****** Object:  StoredProcedure [dbo].[getProductsModelNumber]    Script Date: 06/12/2020 22:25:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[getProductsModelNumber]
	@language nvarchar(50),
    @availability nvarchar(50),
	@model nvarchar(50)
AS
BEGIN
	IF(@availability = 'YES')
		SELECT COUNT(DISTINCT Production.ProductModel.Name) 
		FROM Production.ProductModel 
		INNER JOIN Production.ProductModelProductDescriptionCulture 
		ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
		INNER JOIN Production.ProductDescription 
		ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID  
		INNER JOIN Production.Product
		ON Production.ProductModel.ProductModelID = Production.Product.ProductModelID
		WHERE ProductModelProductDescriptionCulture.CultureID = @language 
		AND Production.ProductModel.Name LIKE @model + '%' 
		AND Production.Product.SellEndDate IS NULL
		AND Production.ProductModel.ProductModelID IS NOT NULL
	ELSE
		SELECT COUNT(DISTINCT Production.ProductModel.Name) 
		FROM Production.ProductModel 
		INNER JOIN Production.ProductModelProductDescriptionCulture 
		ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
		INNER JOIN Production.ProductDescription 
		ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID  
		WHERE ProductModelProductDescriptionCulture.CultureID = @language 
		AND Production.ProductModel.Name LIKE @model + '%' 
		AND Production.ProductModel.ProductModelID IS NOT NULL
END