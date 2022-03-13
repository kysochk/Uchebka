using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchebka
{
    class LoadList
    {
        public List<Product> product;
      
        public LoadList()
        {
            
            product = BaseConnect.BaseModel.Product.ToList(); //заполняем лист продуктом

        }
      
    }
}
