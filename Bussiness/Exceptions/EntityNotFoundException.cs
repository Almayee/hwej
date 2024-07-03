﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Exceptions
{
	public class EntityNotFoundException : Exception
	{
		public EntityNotFoundException(string? message) : base(message)
		{
		}
	}
}
