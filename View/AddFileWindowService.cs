using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace View
{
	public class AddFileWindowService : IAddFileWindowService
	{
		/// <summary>
		/// DialogResult.
		/// </summary>
		public bool DialogResult { get; set; }

		/// <summary>
		/// FileName.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Opens a window for adding file.
		/// </summary>
		public void OpenFileDialog()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if ((bool)openFileDialog.ShowDialog())
			{
				FileName = Path.GetFileName(openFileDialog.FileName);
				DialogResult = true;
			}
			DialogResult = false;
		}
	}
}
