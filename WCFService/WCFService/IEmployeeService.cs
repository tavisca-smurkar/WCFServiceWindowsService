using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        Employee GetEmployee(string id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
