using System;
using System.Diagnostics;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Globalization;
using Windows.Win32.System;
using Windows.Win32.System.Com;

namespace CsWin32GetJMorphResultTest
{
    class Program
    {
        [STAThread]
        static unsafe void Main(string[] args)
        {
            PInvoke.CoInitialize();

            string testData = "漢字";
            Console.WriteLine("OriginalText: " + testData);
            Console.WriteLine("--------");

            GenaratedCodeTest(testData);
            FixedCodeTest(testData);

            PInvoke.CoUninitialize();
        }
        static unsafe void GenaratedCodeTest(string testData)
        {
            PInvoke.CLSIDFromString("MSIME.Japan", out var clsid);
            PInvoke.CoCreateInstance<IFELanguage>(clsid, null, CLSCTX.CLSCTX_INPROC_SERVER | CLSCTX.CLSCTX_LOCAL_SERVER, out var language);

            language.Open();

            MORRSLT* result;
            fixed (char* pstr = testData)
            {
                language.GetJMorphResult(
                            Constants.FELANG_REQ_REV,
                            Constants.FELANG_CMODE_HIRAGANAOUT | Constants.FELANG_CMODE_HALFWIDTHOUT,
                            testData.Length,
                            pstr,
                            null,
                            &result);
            }

            Console.WriteLine("GenaratedCode: "+result->pwchOutput.ToString());

            PInvoke.CoTaskMemFree(result);
            language.Close();

        }
        static unsafe void FixedCodeTest(string testData)
        {
            PInvoke.CLSIDFromString("MSIME.Japan", out var clsid);
            PInvoke.CoCreateInstance<Fixed.Globalization.IFELanguage>(clsid, null, CLSCTX.CLSCTX_INPROC_SERVER | CLSCTX.CLSCTX_LOCAL_SERVER, out var language);

            language.Open();

            Fixed.Globalization.MORRSLT* result;
            fixed (char* pstr = testData)
            {
                language.GetJMorphResult(
                            Constants.FELANG_REQ_REV,
                            Constants.FELANG_CMODE_HIRAGANAOUT | Constants.FELANG_CMODE_HALFWIDTHOUT,
                            testData.Length,
                            pstr,
                            null,
                            &result);
            }

            Console.WriteLine("FixedCode: "+result->pwchOutput.ToString());

            PInvoke.CoTaskMemFree(result);
            language.Close();

        }
    }
}
