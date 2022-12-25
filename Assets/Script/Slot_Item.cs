using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot_Item : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Item ItemTable;
    public Image Ana_icon;
    public GameObject Aciklama_canvas;
    public Text Aciklama;

    HouseSelect houseSelect;

    public List<GameObject> effectPoul;

  
    public void OnPointerEnter(PointerEventData eventData)
    {
       Aciklama_canvas.SetActive(true);

    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
       Aciklama_canvas.SetActive(false);
    }


    public void Item_Use()
    {
        Debug.Log(ItemTable.ItemAdi + " İsimli Item Kullanıldı" + " House"+houseSelect.house);
        if(houseSelect.house == int.Parse(ItemTable.ItemAdi))
        {
            for (int i = 0; i < effectPoul.Count; i++)
            {
                if(!effectPoul[i].activeInHierarchy)
                {
                    effectPoul[i].gameObject.SetActive(true);
                    break;
                }
            }
            Destroy(gameObject);
            // StartCoroutine(deneme());
            // StopAllCoroutines(deneme());
        }
    }
    public void Item_Remove()
    {
        Debug.Log(ItemTable.ItemAdi + " İsimli Item silindi");
        
    }


    void Start()
    {
       Aciklama_canvas.SetActive(false);
       Ana_icon.sprite=ItemTable.Item_image;
       Aciklama.text = ItemTable.Item_aciklama;
    }

    void Update()
    {
       houseSelect = GameObject.Find(ItemTable.ItemAdi).GetComponent<HouseSelect>();
        
    }

    // IEnumerator deneme()
    // {
    //     //Obje Aktifleşti 
    //     yield return new WaitForEndOfFrame();
    //     //Effect oynatıldı
    //     yield return new WaitForSeconds(0.3f);
    // }
}
