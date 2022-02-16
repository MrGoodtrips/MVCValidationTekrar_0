using MVCValidationTekrar_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCValidationTekrar_0.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static NorthwindEntities _dbINstance;

        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_dbINstance == null) _dbINstance = new NorthwindEntities();
                return _dbINstance;
            }
        }
    }
}