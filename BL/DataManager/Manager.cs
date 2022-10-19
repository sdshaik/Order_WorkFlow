using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAl.Model;
using IObjects.Repository;

namespace BL.DataManager
{
    public class UserManager:IDataRepository<User>
    {
        readonly Context _UserContext;
        public UserManager(Context userContext)
        {
            _UserContext = userContext;
        }
        public IEnumerable<User> GetAll()
        {
            return (IEnumerable<User>)_UserContext.Users.ToList();
        }
        public User GetById(int id)
        {
            return (User)_UserContext.Users.FirstOrDefault(X => X.User_Id == id);
        }
        public void Add(User entity)
        {
            _UserContext.Users.Add(entity);
            _UserContext.SaveChanges();
        }
        public void Update(User user,User entity)
        {
            user.User_Name=entity.User_Name;
            user.Order_Id=entity.Order_Id;
        }
        public void Delete(User user)
        {
            _UserContext.Users.Remove(user);
            _UserContext.SaveChanges();
        }
    }
    public class ProductManager : IDataRepository<Product>
    {
        readonly Context _ProductContext;
        public ProductManager(Context ProductContext)
        {
            _ProductContext = ProductContext;
        }
        public IEnumerable<Product> GetAll()
        {
            return (IEnumerable<Product>)_ProductContext.Products.ToList();
        }
        public Product GetById(int id)
        {
            return (Product)_ProductContext.Products.FirstOrDefault(X => X.Product_Id == id);
        }
        public void Add(Product entity)
        {
            _ProductContext.Products.Add(entity);
            _ProductContext.SaveChanges();
        }
        public void Update(Product product, Product entity)
        {
            
            product.Product_Price = entity.Product_Price;
            product.Product_stock_qun = entity.Product_stock_qun;
        }
        public void Delete(Product product)
        {
            _ProductContext.Products.Remove(product);
            _ProductContext.SaveChanges();
        }
    }
    public class OrderManager : IDataRepository<Order>
    {
        readonly Context _OrderContext;
        public OrderManager(Context OrderContext)
        {
            _OrderContext = OrderContext;
        }
        public IEnumerable<Order> GetAll()
        {
            return (IEnumerable<Order>)_OrderContext.Orders.ToList();
        }
        public Order GetById(int id)
        {
            return (Order)_OrderContext.Orders.FirstOrDefault(X => X.Order_id == id);
        }
        public void Add(Order entity)
        {
            _OrderContext.Orders.Add(entity);
            _OrderContext.SaveChanges();
        }
        public void Update(Order order, Order entity)
        {

           order.Order_id = entity.Order_id;
            order.Order_date = entity.Order_date;
            order.Order_Status = entity.Order_Status;
            order.Product_Id = entity.Product_Id;
        }
        public void Delete(Order order)
        { _OrderContext.Orders.Remove(order);
          _OrderContext.SaveChanges();
        }
    }
}
