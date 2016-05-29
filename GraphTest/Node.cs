using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
	public class Node<T>
	{
		T Item { get; set; }

		public Node(T item)
		{
			Item = item;
		}
	}
}
