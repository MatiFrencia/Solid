namespace Solid_Principles
{
    public class Solide_I
    {
        public class SaleService : IBasicActions<Sale>
        {
            public void Add(Sale entity)
            {
                Console.WriteLine("Creamos la venta");
            }

            public Sale Get(int id)
            {
                Console.WriteLine("Obtenemos el usuario");
                return new Sale();
            }

            public List<Sale> GetList()
            {
                return new List<Sale>();
            }
        }
        public class UserService : IBasicActions<User>, IAdvanceActions<User>
        {
            public void Add(User entity)
            {
               Console.WriteLine(entity);
            }

            public void Delete(User entity)
            {
                Console.WriteLine("Eliminamos el usuario");
            }

            public User Get(int id)
            {
                Console.WriteLine("Obtenemos el usuario");
                return new User();
            }

            public List<User> GetList()
            {
                return new List<User>();
            }

            public void Update(User entity)
            {
                Console.WriteLine("Editamos el usuario");
            }
        }
        public interface IBasicActions<T>
        {
            public T Get(int id);
            public List<T> GetList();
            public void Add(T entity);
        }
        public interface IAdvanceActions<T>
        {
            public void Update(T entity);
            public void Delete(T entity);
        }
        
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public class Sale
        {
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
        }
        }
}
