using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WindowsFormsComponentLibrary
{
    public partial class RestoreFromBinary : Component
    {
        public RestoreFromBinary()
        {
            InitializeComponent();
        }

        public RestoreFromBinary(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public T Deserialize<T>(string archive, string filename)
        {
            if (typeof(T).IsSerializable)
            {
                return GetObject<T>(Decompress(archive, filename));
            }
            else
            {
                throw new SerializationException($"Тип {typeof(T)} не поддерживает сериализацию");
            }
        }

        private string Decompress(string source, string filename)
        {
            if (File.Exists(source))
            {
                foreach (var file in ZipFile.OpenRead(source).Entries)
                {
                    if (file.Name == filename)
                    {
                        string dest = Path.Combine(Path.GetDirectoryName(source), file.Name);
                        file.ExtractToFile(dest, true);
                        return dest;
                    }
                }
                throw new FileNotFoundException($"Файл {filename} не найден в архиве");
            }
            else
            {
                throw new FileNotFoundException($"Архив по пути {source} не найден");
            }
        }

        public T GetObject<T>(string source)
        {
            if (File.Exists(source))
            {
                using (FileStream fs = new FileStream(source, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        T deserialized = (T)formatter.Deserialize(fs);
                        MessageBox.Show("Объект успешно десериализован", "Уведомление",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return deserialized;
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return default;
                }
            }
            else
            {
                throw new FileNotFoundException($"Файл {source} не найден");
            }
        }
    }
}
