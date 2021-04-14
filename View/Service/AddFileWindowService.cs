using System.Collections.Generic;
using Microsoft.Win32;
using System.IO;
using Test;

namespace View
{
	/// <summary>
	/// Shows a window for adding files.
	/// </summary>
	public class AddFileWindowService : IAddFileWindowService
	{
		/// <summary>
		/// Returns and sets DialogResult.
		/// </summary>
		public bool DialogResult { get; set; }

		/// <summary>
		/// Returns and sets FileName.
		/// </summary>
		public string[] FileName { get; set; }

		/// <summary>
		/// Opens a window for adding file.
		/// </summary>
		public void OpenFileDialog()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			// TODO: преобразовывать bool? в bool небезопасно (+)
			if ((bool?)openFileDialog.ShowDialog() == true)
			{
				var listNames = new List<string>();
				foreach (var fileName in openFileDialog.FileNames)
				{
					listNames.Add(Path.GetFileName(fileName));
				}

				FileName = listNames.ToArray();
				DialogResult = true;
			}
		}
	}
}
