using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;

namespace EntitiesWebSvcGrid.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EmployeeWebService
    {
        [OperationContract]
        public List<Employee> GetEmployees() 
        { 
            AdventureWorks_DataEntities ds = new AdventureWorks.DataEntities(); 
            return ds.Employee.Where(emp => emp.SalariedFlag == true).ToList(); }
        // Add more operations here and mark them with [OperationContract]
    }
}
