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
            // TODO: преобразовывать bool? в bool небезопасно (+)
			if ((bool?)openFileDialog.ShowDialog() == true)
			{
				FileName = Path.GetFileName(openFileDialog.FileName);
				DialogResult = true;
			}
		}
	}
}
