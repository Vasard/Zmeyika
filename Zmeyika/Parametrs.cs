using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zmeyika
{
    class Parametrs
    {

        private string ResourcesFolder;

        public Parametrs()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                    .ToString(); // путь до указанной в индкесе папки

            ResourcesFolder = binFolder + "Resources\\";
        }

        public string GetResourceFolder()
        {
            return ResourcesFolder;
        }


    }
}
