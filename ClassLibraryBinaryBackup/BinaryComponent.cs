using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBinaryBackup
{
    public partial class BinaryComponent : Component
    {
        public void saveData<T>(String path, T[] data)
        {
            if (File.Exists(path + "/backup.rar"))
            {
                File.Delete(path + "/backup.rar");
            }
            var type = data.GetType();
            if (!type.IsSerializable)
            {
                throw new Exception("Класс не сериализуемый");
            }
            try
            {
                var serializer = new BinaryFormatter();
                string tempPath = path + "/temp";
                var tempDir = Directory.CreateDirectory(tempPath);
                string pathBinary = tempPath + "/backup.dat";

                using (var output = new FileStream(pathBinary, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(output, data);
                }

                string archName = path + "/backup.rar";
                ZipFile.CreateFromDirectory(tempPath, archName);
                tempDir.Delete(true);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка сериализации");
            }
        }
    }
}