
# GITS ID Problem Solving Test

## Kompleksitas Algoritma Balanced Bracket

Berikut adalah algoritma yang saya buat untuk permasalahan balanced bracket: (perhatikan nomor line di sebelah kiri)

![Balanced Bracket](https://res.cloudinary.com/dscbb3cu2/image/upload/v1689869446/Screenshot_2023-07-20_230922_bri3ew.png)

Pada fungsi tersebut terdapat beberapa basic operation, seperti assignment, perulangan, hingga percabangan.

Pada perhitungan kompleksitas algoritma yang akan saya jelaskan berikutnya perlu diperhatikan beberapa hal berikut:
* Cost dari operasi hanya direpresentasikan dengan satuan eksekusi, tidak dengan waktu eksekusi dikarenakan kesulitan untuk menghitung waktu eksekusi per-operasi;
* Operasi dihargai dengan 1
* n dalam kasus ini adalah panjang string

Berikut adalah aturan untuk perhitungan kompleksitas algoritma:
1. Assignment, termasuk return dan inisiasi, bernilai 1
2. Percabangan bernilai 1
3. Perbandingan bernilai 1
4. Operasi terhadap stack bernilai 1
5. Jika ada operasi di dalam looping, maka akan dikali sejumlah looping (n)


#### Perhitungan cost dari setiap operasi
* Pada **line 11** terdapat inisiasi variabel, `cost = 1`;
* Pada **line 14** terdapat inisiasi variabel, `cost = 1`;
* Pada **line 21** terdapat awal looping, di dalamnya ada operasi assignment untuk mengambil satu character dari string input karena masuk dalam looping dikali jumlah looping (n), `cost = 1 * n`;
* Pada **line 23** ada operasi perbandingan, best case nya adalah perbandingan pertama return true, dan worst case nya adalah tidak ada yang menghasilkan true. Maka:
`Best case -> cost = 1 * n` atau
`Worst case -> cost = 3 * n`
* Pada **line 26** terdapat operasi assignment, yakni push ke stack, `cost = 1 * n`
* Pada **line 27** ada operasi perbandingan, best case nya adalah perbandingan pertama return true, dan worst case nya adalah tidak ada yang menghasilkan true. Maka:
`Best case -> cost = 1 * n` atau
`Worst case -> cost = 3 * n`
* Pada **line 29** ada operasi perbandingan, `cost = 1 * n`;
* Pada **line 32** ada operasi return, `cost = 1 * n`;
* Pada **line 35** ada satu operasi perbandingan dan satu operasi pop stack, `cost = 2 * n`;
* Pada **line 38** ada operasi return, `cost = 1 * n`;
* Pada **line 43** ada tiga operasi, yakni satu operasi perbandingan, satu operasi count stack, dan satu operasi return, `cost = 3 * n`;

#### Kesimpulan Perhitungan Kompleksitas Algoritma
#### **Best Case** 
Best case algoritma dengan kasus menghasilkan **"YES"** adalah:
`1 + 1 + (1 * n) + (1 * n) + (1 * n) + (1 * n) + (1 * n) + (1 * n) + (2 * n) + (1 * n) + (3 * n)` = **2 + 12n**

#### **Worst Case** 
Worst case algoritma dengan kasus menghasilkan **"YES"** adalah:
`1 + 1 + (1 * n) + (3 * n) + (1 * n) + (3 * n) + (1 * n) + (1 * n) + (2 * n) + (1 * n) + (3 * n)` = **2 + 16n**


Jika kita hapus semua konstanta dari kompleksitas algoritma tersebut, maka hanya akan tersisa (x)n. Itu dikarenakan hanya terdapat satu kali iterasi dalam kode algoritma di atas. Sehingga kompleksitas algoritma kode Balanced Bracket di atas bisa disebut **O(n) atau Linear**.

### **ScreenShots**
#### Soal 1
<img src="https://github.com/driskimaulana/driskimaulana-GI-test/blob/master/Soal1_Results.png" width="400" height="200" />

#### Soal 2
<img src="https://github.com/driskimaulana/driskimaulana-GI-test/blob/master/Soal2_Results.png" width="400" />

#### Soal 3
<img src="https://github.com/driskimaulana/driskimaulana-GI-test/blob/master/Soal3_Results.png" width="400" height="200" />

#### ALL
<img src="https://github.com/driskimaulana/driskimaulana-GI-test/blob/master/All_Results.png" width="300" height="200" />
