using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public interface IContext
    {
        /// <summary>
        /// покупатель
        /// </summary>
        ICollection<Platelshik> Platelshiks { get; }
        /// <summary>
        /// накладная
        /// </summary>
        ICollection<Nakladnaya> Nakladnayas { get; }
        /// <summary>
        /// товар
        /// </summary>
        ICollection<Tovar> Tovars { get; }
        /// <summary>
        /// поставищик
        /// </summary>
        ICollection<Postavshik> Postavshiks { get; }
        /// <summary>
        /// ведомость
        /// </summary>
        ICollection<Vedom> Vedoms { get; }

        void SaveChanges();
    }
}
