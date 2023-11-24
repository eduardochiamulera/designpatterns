using Core.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Creational.AbstractFactory.Implementations
{
	public abstract class Chair : IChair
	{
		public abstract string Print();
		
	}
}
