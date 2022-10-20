using Microsoft.AspNetCore.Mvc;
using DAl.Model;
using IObjects.Repository;

namespace Order_WorkFlow.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IDataRepository<User> _userRepository;
        public UserController(IDataRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        //get all User
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            return Ok(users);
        }
        [HttpGet("id")]
        // get users by id
        public IActionResult Getbyid(int id)
        {
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound("User Not Found");
            }
            return Ok(user);
        }
        [HttpPost]
        //Add new User
        public IActionResult Post(User user)
        {
            _userRepository.Add(user);
            return Ok();
        }
        [HttpPut("id")]
        //Update User
        public IActionResult put(int id, User user)
        {
            User usertoupdate = _userRepository.GetById(id);
            _userRepository.Update(usertoupdate, user);
            return NoContent();
        }
        [HttpDelete("id")]
        //Delete User
        public IActionResult Delete(int id)
        {
            User user = _userRepository.GetById(id);
            _userRepository.Delete(user);
            return NoContent();
        }
    }
    [ApiController]
    [Route("order")]
    public class orderController : ControllerBase
    {
        private readonly IDataRepository<Order> _OrderRepository;
        public orderController(IDataRepository<Order> OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
        [HttpGet]
        //get all order
        public IActionResult Get()
        {
            IEnumerable<Order> orders = _OrderRepository.GetAll();
            return Ok(orders);
        }
        [HttpGet("id")]
        //get orders by id
        public IActionResult Getbyid(int id)
        {
            Order order = _OrderRepository.GetById(id);
            if (order == null)
            {
                return NotFound("order Not Found");
            }
            return Ok(order);
        }
        [HttpPost]
        //Add new order
        public IActionResult Post(Order order)
        {
            _OrderRepository.Add(order);
            return Ok();
        }
        [HttpPut("id")]
        //Update order
        public IActionResult put(int id, Order order)
        {
            Order ordertoupdate = _OrderRepository.GetById(id);
            _OrderRepository.Update(ordertoupdate, order);
            return NoContent();
        }
        [HttpDelete("id")]
        //Delete order
        public IActionResult Delete(int id)
        {
            Order order = _OrderRepository.GetById(id);
            _OrderRepository.Delete(order);
            return NoContent();
        }
    }
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private readonly IDataRepository<Product> _ProductRepository;
        public ProductController(IDataRepository<Product> ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        //get all product
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Product> products = _ProductRepository.GetAll();
            return Ok(products);
        }
        [HttpGet("id")]
        // get product by id
        public IActionResult Getbyid(int id)
        {
            Product product = _ProductRepository.GetById(id);
            if (product == null)
            {
                return NotFound("Product Not Found");
            }
            return Ok(product);

        }
        [HttpPost]
        //Add new product
        public IActionResult Post(Product product)
        {
            _ProductRepository.Add(product);
            return Ok();
        }
        [HttpPut("id")]
        //Update order
        public IActionResult put(int id, Product product)
        {
            Product producttoupdate = _ProductRepository.GetById(id);
            _ProductRepository.Update(producttoupdate, product);
            return NoContent();
        }
        [HttpDelete("id")]
        //Delete order
        public IActionResult Delete(int id)
        {
            Product product = _ProductRepository.GetById(id);
            _ProductRepository.Delete(product);
            return NoContent();
        }
    }
    [ApiController]
    [Route("Payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IDataRepository<Payment> _PaymentRepository;
        public PaymentController(IDataRepository<Payment> PaymentRepository)
        {
            _PaymentRepository = PaymentRepository;
        }
        //get all from payment
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Payment> payments = _PaymentRepository.GetAll();
            return Ok(payments);
        }
        [HttpGet("id")]
        // get payment by id
        public IActionResult Getbyid(int id)
        {
            Payment payment = _PaymentRepository.GetById(id);
            if (payment == null)
            {
                return NotFound("payment details Not Found");
            }
            return Ok(payment);

        }
        [HttpPost]
        //Add new Payment
        public IActionResult Post(Payment payment)
        {
            _PaymentRepository.Add(payment);
            return Ok();
        }
        [HttpPut("id")]
        //Update Payment
        public IActionResult put(int id, Payment payment)
        {
            Payment Paymenttoupdate = _PaymentRepository.GetById(id);
            _PaymentRepository.Update(Paymenttoupdate, payment);
            return NoContent();
        }
        [HttpDelete("id")]
        //Delete Payment
        public IActionResult Delete(int id)
        {
            Payment payment = _PaymentRepository.GetById(id);
            _PaymentRepository.Delete(payment);
            return NoContent();
        }
    }

}
