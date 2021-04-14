﻿namespace Test
{
    // TODO: Сделать добавление множества файлов, а не по одному (+)
	/// <summary>
	/// Сlass responsible for showing window.
	/// </summary>
	public interface IAddFileWindowService
	{
		/// <summary>
		/// DialogResult.
		/// </summary>
		bool DialogResult { get; set; }

		/// <summary>
		/// FileName.
		/// </summary>
		string[] FileName { get; set; }

		/// <summary>
		/// Opens a window for adding file.
		/// </summary>
		void OpenFileDialog();
	}
}
