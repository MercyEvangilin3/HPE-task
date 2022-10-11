using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertCustomerDetails(CustomerDetails cDetails);

        [OperationContract]
        string UpdateCustomerDetails(CustomerDetails cDetails);
        [OperationContract]
        DataSet GetCustomerDetails(CustomerDetails cDetails);
        [OperationContract]
        bool DeleteCustomerDetails(CustomerDetails cDetails);

    }
    [DataContract]
    public class CustomerDetails
    {
        int? cId;
        string cFirstName = string.Empty;
        string cLastName = string.Empty;
        string cEmail = string.Empty;
        string cContactNumber = string.Empty;
        string cAddress = string.Empty;

        [DataMember]
        public int ?Id
        {
            get { return cId; }
            set { cId = value; }
        }

        [DataMember]
        public string  FName
        {
            get { return cFirstName; }
            set { cFirstName = value; }
        }

        [DataMember]
        public string LName
        {
            get { return cLastName; }
            set { cLastName = value; }
        }

        [DataMember]
        public string Email
        {
            get { return cEmail; }
            set { cEmail= value; }
        }

        [DataMember]
        public string ContactNumber
        {
            get { return cContactNumber; }
            set { cContactNumber = value; }
        }

        [DataMember]
        public string Address
        {
            get { return cAddress; }
            set { cAddress = value; }
        }
    }


    
}
