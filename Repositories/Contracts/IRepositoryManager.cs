using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	//Manager üzerinden birçok repoya erişim veriyoruz ve repoları yönetebiliyoruz(UnitOfWork design pattern)
	public interface IRepositoryManager
	{
		ICustomerRepository Customer { get; }
		void Save();
	}
}
