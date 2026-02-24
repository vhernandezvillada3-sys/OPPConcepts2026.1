
namespace OPPConcepts.Backend
{
    public class SalaryEmployee : Employee
    {
        public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate) :
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
        }

        public override decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
