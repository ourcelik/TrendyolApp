using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entities
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
