using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Test;

namespace View
{
	public class MessageBoxService : IMessageBoxService
	{
        /// <summary>
        /// Show MessageBox.
        /// </summary>
        /// <param name="text">Message.</param>
        public void Show(string text)
        {
            MessageBox.Show(text);
        }
    }
}
