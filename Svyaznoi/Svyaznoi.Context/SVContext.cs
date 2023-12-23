using Svyaznoi.Context.Contracts.Models;
using System.Xml.Linq;

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
            Seed();
        }

        public ICollection<Platelshik> Platelshiks => platelshiks;

        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Tovar> Tovars => tovars;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Vedom> Vedoms => vedoms;

      

        void IContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "ilya@mail.ru",
                Name = "Илья",
                Adres = "Санкт-Петербург, ул. Тореза 47",
                Index = 147318,
                Inn = 1234567812,
                RS = 43434234
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "goloand@mail.ru",
                Name = "Голанд",
                Adres = "Санкт-Петербург, ул. Ленина 28",
                Index = 112334,
                Inn = 1235675,
                RS = 4575674
            });
            Platelshiks.Add(new Platelshik
            {
                Id = Guid.NewGuid(),
                Name = "Павел",
                Number = 799102950,
                Adres = "Купчино, ул. Победы 23",
                Index = 8757874,
                Email = "chekpeck@mail.ru"
            });
            Platelshiks.Add(new Platelshik
            {
                Id = Guid.NewGuid(),
                Name = "Андрей",
                Number = 793202950,
                Adres = "Мурино, ул. Коменданского 78",
                Index = 87433874,
                Email = "pol@mail.ru"
            });
            Platelshiks.Add(new Platelshik
            {
                Id = Guid.NewGuid(),
                Name = "Тимур",
                Number = 799454950,
                Adres = "Санкт-Петербург, пр. Тореза 43",
                Index = 813134,
                Email = "kukol@mail.ru"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООО <ПАО>",
                Description = "Накладная № 124234121376 от «18» Ноября 2023г.\r\nПродавец: ООО Павленко, ИНН 12121213124\r\nАдрес продавца: Тореза 40\r\nПокупатель: ИП Логинов, ИНН 12121213124, КПП 342423\r\nАдрес покупателя: Науки"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООН <Генга>",
                Description = "Накладная № 124234123232 от «19» Ноября 2023г.\r\nПродавец: ООО Павленко, ИНН 123313433124\r\nАдрес продавца: Ленина 43\r\nПокупатель: ООО Криуленко, ИНН 123313433124, КПП 342332\r\nАдрес покупателя: Лакшери"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ЛОМ <БОМЖ>",
                Description = "Накладная № 124231233232 от «20» Ноября 2023г.\r\nПродавец: ООО Рукенглаз, ИНН 14434566324\r\nАдрес продавца: Лисичанск 10\r\nПокупатель: ИП РИКОН, ИНН 14434566324, КПП 3423232\r\nАдрес покупателя: Болотная"
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "IPhone X",
                Edizmer = "5",
                Value = 25000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "IPhone 13",
                Edizmer = "87",
                Value = 67000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "IPhone 15",
                Edizmer = "10",
                Value = 131000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Huawei 10 SE",
                Edizmer = "45",
                Value = 23999
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Realme 10 PRO+",
                Edizmer = "35",
                Value = 35000
            });
            Vedoms.Add(new Vedom 
            {
                Id = Guid.NewGuid()
            });
        }
    }
}
