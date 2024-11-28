using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InspectorLib
{
    public class FunctionInsp
    {
        private string _chiefInspector = "Васильев Василий Иванович";
        private string _departmentName = "Автоинспекция г. Чита";
        private List<string> _employees = new List<string>() { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };

        public string GetInspector() => _chiefInspector;

        public string GetCarInspection() => _departmentName;

        public bool SetInspector(string fullname)
        {
            if (_employees.Contains(fullname))
            {
                _chiefInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(int number, char symbol, int code)
        {
            return $"{char.ToUpper(symbol)}{number}_{code}";
        }

        public List<string> GetWorker() => _employees;

        public bool AddWorker(string fullname)
        {
            if (!_employees.Contains(fullname))
            {
                _employees.Add(fullname);
                return true;
            }
            return false;
        }
    }
}


