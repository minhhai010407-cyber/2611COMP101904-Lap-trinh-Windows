using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04_QuanLySanPham
{
    // Generic class với constraint đúng yêu cầu đề bài
    public class Repository<T> where T : IEntity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T FindById(string id)
        {
            return items.FirstOrDefault(i => i.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // Sử dụng Func<T, bool> để lọc và tìm kiếm
        public List<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}