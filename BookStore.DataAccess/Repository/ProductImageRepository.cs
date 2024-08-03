using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;

namespace BookStore.DataAccess.Repository
{
	public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
	{
		private ApplicationDbContext _db;
		public ProductImageRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}



		public void Update(ProductImage obj)
		{
			_db.ProductImages.Update(obj);
		}
	}
}