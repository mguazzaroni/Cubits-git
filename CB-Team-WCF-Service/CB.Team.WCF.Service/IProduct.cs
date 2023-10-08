using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CB.Team.WCF.Service
{
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        List<Products> GetProducts();
    }

    [DataContract]
    public class Products
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int Stock { get; set; }
    }
}
