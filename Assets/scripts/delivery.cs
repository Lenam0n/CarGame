using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    public TextMeshProUGUI score_val;
    public TextMeshProUGUI package_val;
    int score = 0;
    int package = 0;
    //statt zahlen welche farbe des packages
    //Change color arcording to the package color

    SpriteRenderer sr;

    

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score_val.text = score.ToString();
        package_val.text = package.ToString();
    }
    private void Update()
    {
        score_val.text = score.ToString();
        package_val.text = package.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            
            
            Debug.Log("Picked up the package");
            hasPackage = true;
            sr.color = hasPackageColor;
            Destroy(collision.gameObject, 0.5f);
        }
        else if(collision.tag == "Customer")
        {
            if(hasPackage) { 
                Debug.Log("delivered the package");
                sr.color = noPackageColor;
                hasPackage = false;
                package++;
                score += 10;
                Destroy(collision.gameObject, 0.5f); }
            else { Debug.Log("You dont have the package");}
            
            
        }

    }
}
