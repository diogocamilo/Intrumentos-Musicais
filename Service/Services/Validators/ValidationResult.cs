using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Validators
{
    public class ValidationResult
    {
        private List<string> reasons;

        public ValidationResult()
        {
            reasons = new List<string>();
        }

        public ValidationResult AddReason(string message)
        {
            reasons.Add(message);
            return this;
        }

        public bool IsValid()
        {
            return reasons.Count == 0;
        }

        public string GetErrors()
        {
            var message = reasons.Select(r => "<br/>" + r).ToList(); 
            var result = String.Join(", ", message.ToArray());

            return result;
        }
    }
}
