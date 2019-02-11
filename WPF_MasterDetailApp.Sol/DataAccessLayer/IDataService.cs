using WPF_MasterDetailApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.DataAccessLayer
{
    public interface IDataService
    {
        List<Product> ReadAll();
        void WriteAll(List<Product> characters);
    }
}
