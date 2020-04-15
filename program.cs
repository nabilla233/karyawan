menggunakan  Sistem ;
menggunakan  Sistem . Koleksi . Generik ;
menggunakan  Sistem . Linq ;
menggunakan  Sistem . Teks ;
menggunakan  Sistem . Threading . Tugas ;

namespace  ResponsiPemrog2810
{
     Program kelas
    {
        static  void  Main ( string [] args )
        {
            Karyawan  k1  =  Karyawan baru  ( " 18112357 " , " Paijo " , 3000000 );
            Tampil ( k1 );
            Karyawan  k2  =  Karyawan baru  ( " 18112234 " , " Jono " , 2000000 );
            Tampil ( k2 );

            Konsol . WriteLine ( " \ n Alhamdulillah gaji naik 10% \ n " );
            Tampil2 ( k1 );
            Tampil2 ( k2 );

            Konsol . ReadKey ();
        }
        static  void  Tampil ( Karyawan  k )
        {
            if ( k . Nama  ==  " Paijo " )
            {
                Konsol . WriteLine ( " Tidak. NIK / Nama Gaji Bulanan " );
                Konsol . WriteLine ( " --------------------------------------- " );
                Konsol . WriteLine ( " 1. {0} / {1} {2} " , k . NIK , k . Nama , k . GajiBulanan );
            }
            lain
            {
                Konsol . WriteLine ( " 2. {0} / {1} {2} " , k . NIK , k . Nama , k . GajiBulanan );
            }
        }
        static  void  Tampil2 ( Karyawan  i )
        {
            int  naik , total ;
            naik  = ( 10  *  i . gajiBulanan ) /  100 ;
            total  =  i . bayarBulanan  +  naik ;
            if ( i . Nama  ==  " Paijo " )
            {
                Konsol . WriteLine ( " Tidak. NIK / Nama Gaji Bulanan " );
                Konsol . WriteLine ( " --------------------------------------- " );
                Konsol . WriteLine ( " 1. {0} / {1} {2} " , i . NIK , i . Nama , total );
            }
            lain
            {
                Konsol . WriteLine ( " 2. {0} / {1} {2} " , i . NIK , i . Nama , total );
            }
        }
    }
}