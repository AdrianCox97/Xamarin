using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Lab003_M2_L3_SharedProject
{
    class MySharedCode
    {
        public string GetFilePath(string fileName)
        {
#if WINDOWS_UWP
            var FilePath = Path.Combine(
                Windows.Storage.ApplicationData.Current.LocalFolder.Path,
                fileName
                );
#else
#if _ANDROID_
            string LibraryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var FilePath = Path.Combine(LibraryPath, fileName);
#else
#if _WPF_
            var FilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                fileName);
#endif
#endif
#endif
            return FilePath;
        }
    }
}