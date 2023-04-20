using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GenerateImages : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    void Start()
    {
        int sizelist = sprites.Count;
        int size = gameObject.transform.childCount;
        Debug.Log(sizelist);
        // int children = gameObject.transform.childCount;
        for(int i=0;i<size;i++)
        {
            // Debug.Log(gameObject.transform.GetChild(i).transform.GetChild(0).name);
            int r_index = Random.Range(0,sizelist);
            Transform child = gameObject.transform.GetChild(i);
            Transform child_child = gameObject.transform.GetChild(i).transform.GetChild(0);
            Image old_image = child_child.GetComponent<Image>();
            Sprite new_image = sprites[r_index];
            old_image.sprite = new_image;
            if(new_image.name == "1")
            {
                child.tag = "2";
            }else if(new_image.name == "2")
            {
                child.tag = "3";
            }else if(new_image.name == "3")
            {
                child.tag = "4";
            }else if(new_image.name == "4")
            {
                child.tag = "5";
            }else if(new_image.name == "5")
            {
                child.tag = "6";
            }else if(new_image.name == "6")
            {
                child.tag = "7";
            }else if(new_image.name == "7")
            {
                child.tag = "2";
            }else if(new_image.name == "8")
            {
                child.tag = "3";
            }else if(new_image.name == "9")
            {
                child.tag = "4";
            }else if(new_image.name == "10")
            {
                child.tag = "5";
            }else if(new_image.name == "11")
            {
                child.tag = "6";
            }else
            {
                child.tag = "7";
            }
            sprites.Remove(sprites[r_index]);
            sizelist--;
            // Debug.Log(r_index);
            // Debug.Log("todo bien 3");
            // Debug.Log("todo bien 4");
            // Debug.Log(gameObject.transform.GetChild(i).name);
        }
    }
}
