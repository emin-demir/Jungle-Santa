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

    private int slotCount ;
    public ParticleSystem particuleEffect;

    public AudioSource audi;

    HouseSelect houseSelect;

    public List<GameObject> effectPoul;
    public Envanter env;

    private Animator anim;

    private GameObject gameOver;


  
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
            
            particuleEffect.Play();
            audi.Play();
            

            Destroy(gameObject);
            Envanter.slotCount --;
            
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
        Debug.Log(Envanter.slotCount);

       if(Envanter.slotCount == 0)
       {
        Envanter.anim.SetBool("Open",true);
       }
    }

    // IEnumerator deneme()
    // {
    //     //Obje Aktifleşti 
    //     yield return new WaitForEndOfFrame();
    //     //Effect oynatıldı
    //     yield return new WaitForSeconds(0.3f);
    // }
}
