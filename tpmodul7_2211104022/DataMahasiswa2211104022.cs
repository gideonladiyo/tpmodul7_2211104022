using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_2211104022
{
    class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }
    class DataMahasiswa2211104022
    {
        [JsonPropertyName("nama")]
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")]
        public string Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }

        public static void ReadJSON()
        {
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "solution", "tp7_1_2211104022.json");
            Console.WriteLine($"Mencari file {pathFile}");
            if (File.Exists(pathFile))
            {
                string jsonData = File.ReadAllText(pathFile);
                DataMahasiswa2211104022 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa2211104022>(jsonData);

                Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan nim {mahasiswa.Nim} dari fakultas {mahasiswa.Fakultas}");
            }
            else
            {
                Console.WriteLine("File tidak ditemukan");
            }
        }
    }
}
