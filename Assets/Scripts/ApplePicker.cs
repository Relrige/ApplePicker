using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets =3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    public int count=0;
    void Start()
    {
        if (ButtonUI.ButtonPressed==true) {
            CreateBaskets();
            ButtonUI.ButtonPressed = false;
        }
        }
    public void CreateBaskets()
    {
        
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (i * basketSpacingY);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }
    
    public void AppleDesctroyed()
    {
        print(numBaskets);
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        Destroy(tBasketGO);
        basketList.RemoveAt(basketIndex);
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
