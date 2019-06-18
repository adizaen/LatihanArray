using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.Nama = "Erik";
            mhs1.Nilai = "75";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.Nama = "Wely";
            mhs2.Nilai = "80";

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "1236";
            mhs3.Nama = "Sony";
            mhs3.Nilai = "95";

            Mahasiswa[] arrMhs = new Mahasiswa[3];
            arrMhs[0] = mhs1;
            arrMhs[1] = mhs2;
            arrMhs[2] = mhs3;

            Console.WriteLine("No.  Nim\tNama\tNilai");
            Console.WriteLine("------------------------------");

            int i = 1;
            foreach(Mahasiswa mhs in arrMhs)
            {
                Console.WriteLine(i + "    " + mhs.Nim + "\t" + mhs.Nama + "\t" + mhs.Nilai);
                i++;
            }
            
            Console.ReadKey();
        }
    }
}
