# There is my implementation on a few issues

## Write a C# library

Write a C# library for delivery to external clients that can calculate the area of a circle from its radius and a triangle from three sides.

### Opptional

1) Unit tests;

2) Ease of adding other figures;

3) Calculating the area of a figure without knowing the type of figure in compile-time;

4) Checking if the triangle is right-angled.

## Write an SQL query

MS SQL Server database has products and categories. One product can have many categories, and one category can have many products. Write an SQL query to select all pairs of "Product Name - Category Name". If a product has no categories, then its name should still be displayed.

```sql
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
```
