using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public interface IMessageBoxService
	{
		/// <summary>
		/// Show MessageBox.
		/// </summary>
		/// <param name="text">Message.</param>
		void Show(string text);
	}
}
