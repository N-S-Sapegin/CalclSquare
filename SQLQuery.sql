SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductAndCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;