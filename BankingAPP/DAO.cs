using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP
{
    public interface DAO<T>
    {
   		T Get(string code);
    	IList<T> GetAll {get;}
   		bool Add(T t);
    	bool Update(T t);
	    bool Delete(T t);
    }
}
