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
        public List<Material> material;
        public LoadList()
        {
            
            material = BaseConnect.BaseModel.Material.ToList(); //заполняем лист клиентами

        }
      
    }
}
