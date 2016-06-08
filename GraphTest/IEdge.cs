using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
	public interface IEdge
	{
		INode FromNode { get; }
		INode ToNode { get; }

		bool IsDirected { get; }
	}
}
