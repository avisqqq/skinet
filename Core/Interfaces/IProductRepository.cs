using System.Reflection.Metadata;
using Core.Entities;

namespace Core.Interface;


public interface IProductRepository
{
	Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort);
	Task<Product?> GetProductByIdAsync(int id);
	void AddProduct(Product product);

	Task<IReadOnlyList<string>> GetBrandsAsync();
	Task<IReadOnlyList<string>> GetTypesAsync();
	void UpdateProduct(Product product);
	void DeleteProduct(Product product);
	bool ProductExists(int id);
	Task<bool> SaveChangesAsync();
}