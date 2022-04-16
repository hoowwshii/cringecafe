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

# button2_click(sistem dikon)
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

terimakasih, aku mau tidur dlu
