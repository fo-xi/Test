﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class NotifyDataError : NotifyPropertyChanged, INotifyDataErrorInfo
	{

        /// <summary>
        /// Contains a dictionary of errors.
        /// </summary>
        protected readonly Dictionary<string, List<string>> _errorsByPropertyName
            = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets all error messages.
        /// </summary>
        /// <param name="propertyName">Property Name.</param>
        /// <returns></returns>
        public IEnumerable GetErrors(string propertyName)
        {
	        if (propertyName == null)
	        {
		        return null;
	        }

	        return _errorsByPropertyName.ContainsKey(propertyName) ?
                _errorsByPropertyName[propertyName] : null;
        }

        /// <summary>
        ///  Property indicates whether there are any validation errors.
        /// </summary>
        public virtual bool HasErrors
        {
            get
            {
                return _errorsByPropertyName.Any();
            }
        }

        /// <summary>
        /// Event must occur when the validation errors have changed
        /// for a property or for the entity.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        /// <summary>
        /// Event triggering.
        /// </summary>
        /// <param name="propertyName">Property Name.</param>
        public void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds an error message to the error dictionary.
        /// </summary>
        /// <param name="propertyName">Property Name.</param>
        /// <param name="error">Error message.</param>
        protected void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
                _errorsByPropertyName[propertyName] = new List<string>();

            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Removes all errors by key.
        /// </summary>
        /// <param name="propertyName">Property Name.</param>
        protected void ClearErrors(string propertyName)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Validation of string.
        /// </summary>
        /// <param name="value">File Name.</param>
        /// <param name="propertyName">Property Name.</param>
        public void Validate(string fileName, string propertyName)
        {
            ClearErrors(propertyName);
            if (!fileName.Contains(".exe") && !fileName.Contains(".dll"))
            {
                AddError(propertyName, "File is not a *.exe or *.dll file");
            }
        }
	}
}
