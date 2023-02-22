using v21;

Kalkulator hitung = new Kalkulator();

//hitung.tambah();
//hitung.kurang();

Console.Write("Masukkan panjang : ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Masukkan lebar : ");
int l = Convert.ToInt32(Console.ReadLine());

Rumus rumuspersegi = new Rumus();
 
rumuspersegi.lingkaran();

Console.WriteLine($"luas persegi panjang dengan L ={p} dan L = {l} adalah"+ rumuspersegi.PersegiPanjang(p, l));