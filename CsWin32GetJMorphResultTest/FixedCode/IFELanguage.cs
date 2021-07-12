﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591, CS1573, CS0465, CS0649, CS8019, CS1570, CS1584, CS1658
namespace Fixed
{
	using global::System;
	using global::System.Diagnostics;
	using global::System.Runtime.CompilerServices;
	using global::System.Runtime.InteropServices;
	using global::System.Runtime.Versioning;
	using win32 = global::Windows.Win32;

	namespace Globalization
	{
		[Guid("019F7152-E6DB-11D0-83C3-00C04FDDB82E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), ComImport()]
		internal interface IFELanguage
		{
			/// <summary>Initializes the IFELanguage object.</summary>
			/// <returns><b>S_OK</b> if successful, otherwise <b>E_FAIL</b>.</returns>
			/// <remarks>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-open">Learn more about this API from docs.microsoft.com.</see></para>
			/// </remarks>
			void Open();
			/// <summary>Terminates the IFELanguage object.</summary>
			/// <returns><b>S_OK</b> if successful, otherwise <b>E_FAIL</b>.</returns>
			/// <remarks>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-close">Learn more about this API from docs.microsoft.com.</see></para>
			/// </remarks>
			void Close();
			/// <summary>Gets morphological analysis results.</summary>
			/// <param name="dwRequest"></param>
			/// <param name="dwCMode">
			/// <para>Specifies the conversion output characters and conversion options. This value is a combination of one or more of the following flags: </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getjmorphresult#parameters">Read more on docs.microsoft.com</see>.</para>
			/// </param>
			/// <param name="cwchInput">The number of characters in <i>pwchInput</i>.</param>
			/// <param name="pwchInput">
			/// <para>Input characters to be converted by the morphology engine. This must be a UNICODE string. Set this parameter to <b>NULL</b> to get the next entry for the previously input string, with the next rank. The order in which next entries are returned is defined by the implementation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getjmorphresult#parameters">Read more on docs.microsoft.com</see>.</para>
			/// </param>
			/// <param name="pfCInfo">
			/// <para>The information for each column, where  each <i>pfCInfo[x]</i> corresponds to <i>pwchInput[x]</i>. Each  <b>DWORD</b> can be a combination of the flags below: <a id="FELANG_CLMN_WBREAK"></a> <a id="felang_clmn_wbreak"></a></para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getjmorphresult#parameters">Read more on docs.microsoft.com</see>.</para>
			/// </param>
			/// <param name="ppResult">
			/// <para>The address of a MORRSLT structure that receives the morphology result data. <b>GetJMorphResult</b> allocates memory using the OLE task allocator for the returned data, and sets the <i>pResult</i> to point to the memory. The application must free the memory pointed to by <i>pResult</i>, by using the <a href="https://docs.microsoft.com/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemfree">CoTaskMemFree</a>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getjmorphresult#parameters">Read more on docs.microsoft.com</see>.</para>
			/// </param>
			/// <returns>
			/// <para>This method can return one of these values. </para>
			/// <para>This doc was truncated.</para>
			/// </returns>
			/// <remarks>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getjmorphresult">Learn more about this API from docs.microsoft.com.</see></para>
			/// </remarks>
			unsafe void GetJMorphResult(uint dwRequest, uint dwCMode, int cwchInput, win32.Foundation.PCWSTR pwchInput, uint* pfCInfo, Fixed.Globalization.MORRSLT** ppResult);
			/// <summary>Gets the conversion mode capability of the IFELanguage object.</summary>
			/// <param name="pdwCaps">
			/// <para>The capabilities, represented as a combination of one or more of the following flags: </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getconversionmodecaps#parameters">Read more on docs.microsoft.com</see>.</para>
			/// </param>
			/// <returns><b>S_OK</b> if successful, otherwise <b>E_FAIL</b>.</returns>
			/// <remarks>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getconversionmodecaps">Learn more about this API from docs.microsoft.com.</see></para>
			/// </remarks>
			unsafe void GetConversionModeCaps(uint* pdwCaps);
			unsafe void GetPhonetic(win32.Foundation.BSTR @string, int start, int length, win32.Foundation.BSTR* phonetic);
			/// <summary>Converts the input string (which usually contains the Hiragana character) to converted strings.</summary>
			/// <param name="start">The starting character from which <a href="https://docs.microsoft.com/windows/desktop/api/msime/nn-msime-ifelanguage">IFELanguage</a> begins conversion. The first character of <i>string</i> is represented by 1 (not 0).</param>
			/// <param name="length">The number of characters to convert. If this value is -1, all of the remaining characters from <i>start</i>  are converted.</param>
			/// <param name="result">The converted string. This string is allocated by <a href="https://docs.microsoft.com/previous-versions/windows/desktop/api/oleauto/nf-oleauto-sysallocstringlen">SysAllocStringLen</a> and must be freed by the client.</param>
			/// <returns><b>S_OK</b> if successful, otherwise <b>E_FAIL</b>.</returns>
			/// <remarks>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//msime/nf-msime-ifelanguage-getconversion">Learn more about this API from docs.microsoft.com.</see></para>
			/// </remarks>
			unsafe void GetConversion(win32.Foundation.BSTR @string, int start, int length, win32.Foundation.BSTR* result);
		}
	}
}