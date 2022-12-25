using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="DefaultItem",menuName ="Item/Yeni Item Olustur")]
public class Item : ScriptableObject
{
   public string ItemAdi = "Item Adini Giriniz.";
   public Sprite Item_image;
   public string Item_aciklama;
}
