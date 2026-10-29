# ProductManagementApi

Práctico Bloque 2: Web API RESTful de gestión de productos en 3 capas (.NET 10).

## Estructura
- **ProductManagementApi** (Presentation): `ProductsController`
- **BusinessLayer** (Business): `IProductService`, `ProductService`, DTOs
- **DataAccessLayer** (Data Access): `Product`, `IProductRepository`, `ProductRepositoryInMemory`

## Nombres en inglés
| Consigna | Proyecto |
|---|---|
| Producto | Product |
| ProductoDto / CreateProductoDto | ProductDto / CreateProductDto |
| IProductoService / ProductoService | IProductService / ProductService |
| IProductoRepository / ProductoRepositoryInMemory | IProductRepository / ProductRepositoryInMemory |
| ProductosController (`/api/productos`) | ProductsController (`/api/products`) |

## Cómo ejecutarlo
Abrir la solución en Visual Studio, correr con F5 y entrar a `https://localhost:7035/swagger`.