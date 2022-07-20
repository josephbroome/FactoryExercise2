using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class NotSupported : IDataAccess

    {
        public void LoadData()
        {
            Console.WriteLine("The data type is not supported yet, feature is coming");
        }

        public void SaveData()
        {
            Console.WriteLine("Unable to save data type");
        }
    }
}
