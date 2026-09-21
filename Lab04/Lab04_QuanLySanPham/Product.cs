using System;

namespace Lab04_QuanLySanPham
{
    // Thực thi IEntity bắt buộc phải có thuộc tính Id
    public class Product : IEntity
    {
        public string Id { get; set; }
        public string TenSP { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new ArgumentException("Lỗi: Đơn giá không được âm!");
                price = value;
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0) throw new ArgumentException("Lỗi: Số lượng không được âm!");
                quantity = value;
            }
        }

        public Product(string id, string tenSP, double price, int quantity)
        {
            Id = id;
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Mã SP: {Id,-6} | Tên SP: {TenSP,-15} | Đơn giá: {Price,-10} | Số lượng: {Quantity,-5}";
        }
    }
}