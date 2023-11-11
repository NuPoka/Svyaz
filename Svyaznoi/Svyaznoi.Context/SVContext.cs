using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Platelshik> platelshiks;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;
        private ICollection<Vedom> vedoms;


        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            platelshiks = new HashSet<Platelshik>();
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            vedoms = new HashSet<Vedom>();
        }

        public ICollection<Platelshik> Platelshiks => throw new NotImplementedException();

        public ICollection<Nakladnaya> Nakladnayas => throw new NotImplementedException();

        public ICollection<Tovar> Tovars => throw new NotImplementedException();

        public ICollection<Postavshik> Postavshiks => throw new NotImplementedException();

        public ICollection<Vedom> Vedoms => throw new NotImplementedException();
    }
}
