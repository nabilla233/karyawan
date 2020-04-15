menggunakan  Sistem ;
menggunakan  Sistem . Koleksi . Generik ;
menggunakan  Sistem . Linq ;
menggunakan  Sistem . Teks ;
menggunakan  Sistem . Threading . Tugas ;

namespace  ResponsiPemrog2810
{
    kelas  Karyawan
    {
        public  string  NIK { get ; mengatur ; }
        public  string  Nama { get ; mengatur ; }
        public  int  gajiBulanan { mendapatkan ; mengatur ; }

        publik  Karyawan ( tali  nik , String  nama di , int  gajibulanan )
        {
            ini . NIK  =  nik ;
            ini . Nama  =  nama ;
            if ( gajibulanan  <  0 )
            {
                ini . gajiBulanan  =  0 ;
            }
            lain
            {
                ini . gajiBulanan  =  gajibulanan ;
            }
        }


    }
}