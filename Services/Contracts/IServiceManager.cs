﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IServiceManager
	{
		ICustomerService CustomerService { get; }
		ICategoryService CategoryService { get; }
		IProductService ProductService { get; }
		IOrderedProductService OrderedProductService { get; }
	}
}
