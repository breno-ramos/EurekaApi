using Eureka.SharedKernel.Events;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Eureka.SharedKernel.Validation
{
    public static class AssertionConcern
    {
        public static bool IsValid(params DomainNotification[] validations)
        {
            var notificationsNotNull = validations.Where(validation => validation != null);
            NotifyAll(notificationsNotNull);

            return notificationsNotNull.Count().Equals(0);
        }

        public static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications.ToList().ForEach(validation =>
            {
                DomainEvent.Raise<DomainNotification>(validation);
            });
        }

        public static DomainNotification AssertArgumentEquals(object object1, object object2, string message)
        {
            return (!object1.Equals(object2))
                ? new DomainNotification("AssertArgumentEquals", message) : null;
        }

        public static DomainNotification AssertArgumentFalse(bool boolValue, string message)
        {
            return (boolValue)
                ? new DomainNotification("AssertArgumentFalse", message) : null;
        }

        public static DomainNotification AssertArgumentLength(string stringValue, int minimum, int maximum, string message)
        {
            int length = stringValue.Trim().Length;
            return (length < minimum || length > maximum)
                ? new DomainNotification("AssertArgumentLength", message) : null;
        }

        public static DomainNotification AssertArgumentMatches(string pattern, string stringValue, string message)
        {
            Regex regex = new Regex(pattern);

            return (!regex.IsMatch(stringValue))
                ? new DomainNotification("AssertArgumentMatches", message) : null;
        }

        public static DomainNotification AssertArgumentNotEmpty(string stringValue, string message)
        {
            return (stringValue == null || stringValue.Trim().Length == 0)
                ? new DomainNotification("AssertArgumentNotEmpty", message) : null;
        }

        public static DomainNotification AssertArgumentNotEquals(object object1, object object2, string message)
        {
            return (object1.Equals(object2))
                ? new DomainNotification("AssertArgumentNotEquals", message) : null;
        }

        public static DomainNotification AssertArgumentNotNull(object object1, string message)
        {
            return (object1 == null)
                ? new DomainNotification("AssertArgumentNotNull", message) : null;
        }

        public static DomainNotification AssertArgumentRange(int value, int minimum, int maximum, string message)
        {
            return (value < minimum || value > maximum)
                ? new DomainNotification("AssertArgumentRange", message) : null;
        }

        public static DomainNotification AssertArgumentRange(double value, double minimum, double maximum, string message)
        {
            return (value < minimum || value > maximum)
                ? new DomainNotification("AssertArgumentRange", message) : null;
        }

        public static DomainNotification AssertArgumentRange(float value, float minimum, float maximum, string message)
        {
            return (value < minimum || value > maximum)
                ? new DomainNotification("AssertArgumentRange", message) : null;
        }

        public static DomainNotification AssertArgumentRange(long value, long minimum, long maximum, string message)
        {
            return (value < minimum || value > maximum)
                ? new DomainNotification("AssertArgumentRange", message) : null;
        }

        public static DomainNotification AssertArgumentTrue(bool boolValue, string message)
        {
            return (!boolValue)
                ? new DomainNotification("AssertArgumentTrue", message) : null;
        }

        public static DomainNotification AssertStateFalse(bool boolValue, string message)
        {
            return (boolValue)
                ? new DomainNotification("AssertStateFalse", message) : null;
        }

        public static DomainNotification AssertStateTrue(bool boolValue, string message)
        {
            return (!boolValue)
                ? new DomainNotification("AssertStateTrue", message) : null;
        }

        public static DomainNotification AssertIsCnpj(string cnpj, string message)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;

            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14) return new DomainNotification("AssertIsCnpj", message);

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++) soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2) resto = 0; else resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++) soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2) resto = 0; else resto = 11 - resto;

            digito = digito + resto.ToString();
            bool isCnpf = cnpj.EndsWith(digito);

            return (!isCnpf) ? new DomainNotification("AssertIsCnpj", message) : null;
        }

        public static DomainNotification AssertIsCpf(string cpf, string message)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11) return new DomainNotification("AssertIsCpf", message);

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2) resto = 0; else resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2) resto = 0; else resto = 11 - resto;

            digito = digito + resto.ToString();
            bool isCpf = cpf.EndsWith(digito);

            return (!isCpf) ? new DomainNotification("AssertIsCpf", message) : null;
        }
    }
}
