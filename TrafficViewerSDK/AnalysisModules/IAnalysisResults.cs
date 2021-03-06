using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficViewerSDK.AnalysisModules
{
	/// <summary>
	/// Encapsulates information generated by a Analysis Module
	/// </summary>
	public interface IAnalysisResults
	{
		/// <summary>
		/// Gets a text report of the analysis
		/// </summary>
		string ResultText
		{
			get;
		}

		/// <summary>
		/// Gets an string to load in a browse. If not needed should be null.
		/// </summary>
		string ResultBrowserContent
		{
			get;
		}

		/// <summary>
		/// Controls the content type of the browser response. For example .xml would show xml
		/// </summary>
		string ResultBrowserContentExtension
		{
			get;
		}

	}
}
