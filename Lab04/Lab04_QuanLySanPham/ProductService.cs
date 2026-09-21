using System;
using System.Collections.Generic;

namespace Lab04_QuanLySanPham
{
    public class ProductService
    {
        private Repository<Product> repo = new Repository<Product>();

        // Action event để thông báo khi thêm/xóa thành công
        public event Action<Product> OnProductAdded;
        public event Action<string> OnProductRemoved;

        public void AddProduct(Product p)
        {
            if (repo.FindById(p.Id) != null)
            {
                throw new DuplicateProductException($"Mã sản phẩm '{p.Id}' đã tồn tại!");
            }

            repo.Add(p);
            OnProductAdded?.Invoke(p); // Phát event
        }

        public void RemoveProduct(string id)
        {
            var p = repo.FindById(id);
            if (p == null)
            {
                throw new ProductNotFoundException($"Không tìm thấy sản phẩm mã '{id}' để xóa!");
            }

            repo.Remove(p);
            OnProductRemoved?.Invoke(id); // Phát event
        }

        public List<Product> Search(string keyword)
        {
            return repo.Find(p => p.TenSP.ToLower().Contains(keyword.ToLower()));
        }

        public List<Product> Filter(double minPrice, double maxPrice)
        {
            return repo.Find(p => p.Price >= minPrice && p.Price <= maxPrice);
        }

        public List<Product> GetAll()
        {
            return repo.GetAll();
        }

        public Product FindById(string id)
        {
            return repo.FindById(id);
        }
    }
}