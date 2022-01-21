using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayiTahmini : MonoBehaviour
{
    private int max;
    private int min;
    private int tahmin; 
    void Start()
    {
        oyunaBasla();
    }
    void oyunaBasla()
    {
        max = 1500;
        min = 1;
        tahmin = 750;
        Debug.Log("Sayi Tahmini Oyunu Başlatılıyıor");
        Debug.Log("Aklından bir sayı tut.");
        Debug.Log("Tuttuğun Sayı" + max + "'ü geçmesin.");
        Debug.Log("Tuttuğun Sayı" + min + "den büyük olsun.");
        Debug.Log("Tuttuğun sayi 750 mi ?");
        Debug.Log("YUKARI TUŞUNA BAS = YÜKSELT, AŞAĞI TUŞUNA BAS = AZALT, ENTER TUŞUNA BAS = DOĞRU ");
        max+=1;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = tahmin;
            sonrakiTahmin();
            Debug.Log("yukarı basıldı"+tahmin);

        }
      else  if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = tahmin;
            sonrakiTahmin();
            Debug.Log("aşağı basıldı"+tahmin);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tahmin bulundu...");
            oyunaBasla();
        }
    }
    void sonrakiTahmin()
    {
        tahmin = (min + max) / 2;
    }
}
