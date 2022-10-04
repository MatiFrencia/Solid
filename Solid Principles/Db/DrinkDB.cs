using Solid_Principles.Interfaces;
using Solid_Principles.Models;

namespace Solid_Principles.Db
{
    public class DrinkDB
    {
        private IEnumerable<IDrink> drinkRepository = new List<IDrink>() 
        { 
            new Water("Villavicencio",10,0.1m),
            new Water("Manantiales",10,0.1m),
            new Alcohol("Smirnoff",20,0.3m,0.1m),
            new Alcohol("Absolut",20,0.3m,0.1m),
            new Sugary("Aquarius",15,0.5m,0.3m),        
            new Sugary("Levite",15,0.5m,0.3m),        
            new Sugary("Coca-Cola",15,0.5m,0.3m),        
        };
        public IEnumerable<IDrink> All()
        {
            return drinkRepository;
        }
    }
}
