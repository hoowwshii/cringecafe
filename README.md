# cringecafe
this is cringe

# button1_click(total button)
hanya akan kalkulasi semua harga makanan dan minuman, jika checkbox.checked = true 
![image](https://user-images.githubusercontent.com/68774737/163663290-e12b8c5b-daf3-4906-8c3f-e065729abe56.png)
``` total.text = ""```
berfungsi untuk mereset, kalau tidak ada, maka jumlahnya akan ditambah terus setiap kali diklik, walaupun tidak menambahkan porsi sama sekali
end

# textbox_textchanged(jumlah porsi)
![image](https://user-images.githubusercontent.com/68774737/163663346-8fbbd092-9d2e-4ff8-87fc-5c8b1e99ea02.png)
akan mengubah textbox4.text / textbox yang sejajar / textbox yang sseharusnya / yang diinginkan dengan jumlah porsi(val(textbox1.text) * harga makanan yang diinginkan

![image](https://user-images.githubusercontent.com/68774737/163663404-dcca75fb-2caa-408e-9bf6-7e364eff7157.png)
dari kiri ke kanan. checkbox1, textbox1 dan textbox4

# button2_click(sistem diskon)
![image](https://user-images.githubusercontent.com/68774737/163663486-8f411293-4bf1-44d2-a045-fee5883e3551.png)
untuk lebih mudah, aku pakai select case. jika textbox14(lol) nilainya kurang dari 20ribu, maka tidak ada diskon. jika 20ribu sampai dengan 50ribu, maka akan ada diskon sebesar 0.05(5%). begitu juga dengan 50ribu sampai 120ribu dan belanja yang lebih dari 120000

untuk menghitung persen, kita tidak bisa menggunakan 
``` 100 * 10%```
Melainkan kita harus menggunakan
```100 * 0.1```

Lalu total diskon akan ditaruh ke dalam kotak diskon(textbox16.text)
di dalam textbox16(total bayar/uang yang harus kita bayar), kita harus kurangkan total harga makanan dan diskon(diskon saja).

# button3_click(pembayaran)
![image](https://user-images.githubusercontent.com/68774737/163663617-a5cdba0c-1543-44ce-a2f9-7836f6d7a4d8.png)
jika textbox17(uang yang kita bayar) lebih besar dari total bayar(textbox16), maka uang kita akan dikurang dengan total bayar, lalu akan ditaruh ke bagian kembalian(textbox18)
jika uang kita kurang/ lebih kecil dari total bayar, maka tidak akan ada aksi yang dilakukan
![image](https://user-images.githubusercontent.com/68774737/163663663-640c5a7c-4220-4e8d-b151-539cd3ed485b.png)
 
 # textbox17_textchanged(alternatif pembayaran)
 
 ![image](https://user-images.githubusercontent.com/68774737/163774074-a660d6a1-1d56-4ce0-b48e-1a03f511dae7.png)

hampir sama, cuma untuk messagebox.show pada saat total bayar > uang kita harus diganti/disesuaikan dengan yang kamu mau. tergantung mau pakai yang mana, pilih sesuai kepercayaanmu
# login

![image](https://user-images.githubusercontent.com/68774737/163765966-90530ad6-61d3-492a-92d0-2fba2ba2544d.png)

kotak/textbox untuk nama = textbox1, password = textbox2
![image](https://user-images.githubusercontent.com/68774737/163766173-02a50cdc-418d-4884-84a5-97ab466d3026.png)

Jika textbox1.text sama dengan username DAN texttbox2.text = pw, maka form1 baru akan dimunculkan, jika tidak sama, maka akan keluar messagebox seperti diatas

# cara yang "lebih" cepat untuk reset textbox

![image](https://user-images.githubusercontent.com/68774737/164729699-252079bc-d7ac-451a-9f6c-54cd33962c38.png)

![image](https://user-images.githubusercontent.com/68774737/164729813-f3f5a0aa-738b-45e1-8e84-de94a087cc9d.png)

untuk semua textbox(nama boleh sesuai keinginan sendiri, tapi untuk mempermudah, pakai saja textbox), di dalam Groupbox1 的 control dan type nya adalah textbox. maka akan di clear(textbox.clear(); berjalan sesuai nama yang anda tentukan pada awal, jika for each lol, maka akan gunakan lol.clear() dan seterusnya). cuma akan clear textbox yang ada di groupbox yang terdapat pada gambar pertama.
cara ini memang lebih efisien, tetapi akan membawa masalah untuk txtporsi yang menggunakan .textchanged 的 event.

![image](https://user-images.githubusercontent.com/68774737/164730556-6df175db-cbb5-4968-89cd-85489fc94903.png)

masalah ini hanya akan terjadi jika anda ingin menghapus porsi dan porsi tersebut tidak ada value/ ""

# cara yang lebih cepat untuk menambahkan semua menu makanan(tidak disarankan)

![image](https://user-images.githubusercontent.com/68774737/164731219-1abb47c6-890c-4103-b59a-c331b8d1d526.png)

seperti yang diatas, akan menambahkan "semua" textbox yang ada didalam panel(intinya adalah tool untuk grouping, tidak terlihat oleh user jadi dapat terlihat lebih rapi.

mengapa tidak disarankan?? karena cara ini akan menambahkan semua value dari textbox yang dipilih(txtharga makanan/minuman), tanpa kecuali, jadi jika terdapat 1 textbox saja yang isi nya kosong, maka akan crash.

penyebab crash nya adalah karena adanya percobaan untuk menambahkan textbox yang tanpa value

```textboxtotal.text = val(textbox1.text) + val(textbox2.text) + val(textbox3.text)
akan terlihat seperti ini jika textbox3 adalah tanpa value. anggap saja textbox1 dan textbox2 terdapat value
textboxtotal.text = 5 + 2 + ""(nuill)
```

masalah ini dapat diatasi jika kita memberi value awal

![image](https://user-images.githubusercontent.com/68774737/164732390-e8f080d2-845a-42d0-b2b2-bd7d0a5dfa31.png)

masalah terakhir dari penggunaan ini adalah, misalnya kita sudah uncheck checkbox1, maka textboxharga akan tetap ditambahkan jika button total di klik. jadi yang seharusnya sudah tak jadi dipesan, akan tetap dihitung dalam txttotal


# txtporsi.textchanged crash karena Conversion from string "" to type double is not valid

hampir sama dengan yang tadi, untuk fix nya adalah.
jangan execute code nya ketika txtporsi.text = ""

![image](https://user-images.githubusercontent.com/68774737/164733799-2926f1c0-1490-4e58-9bad-2628784b94a8.png)

kira kira seperti ini. menambah kode dan tidak efisien
bolah dicoba aja untuk .textchanged, tetapi dikasus ku, dia yg jadi biang masalah dicode ku

# Clone ?
gitclone aja di visual studio, kalau untuk 2019

![image](https://user-images.githubusercontent.com/68774737/163663837-3f227e1f-adf4-4af7-9c1c-ba9ca1f4045d.png)

tekan, lalu masukkan link github ini

https://github.com/hoowwshii/cringecafe

Setelah itu, buka solution explorer(kalau tidak tahu, bs cari di gugel), lalu cari file yang belakangnya .sln, lalu buka form1.vb. Selamat anda sudah clone 1 project/solution.

gitclone untuk versi 2017 saya kurang tau, harusnya ada, mungkin bisa cari di google saja.

eksplor code nya agar makin paham dan ingat, jangan hafal tapi pahami. kalau ga paham panggil pengawas ja pas ujiannya
