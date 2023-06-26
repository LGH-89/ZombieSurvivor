using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] GameObject pickUpItem;
    public GameObject branch;
    public GameObject stone;
    bool pick;

    // 가까이 갔을 때 줍기 활성화 & 설명 활성화
    private void OnTriggerStay(Collider other) 
    {
         switch(other.tag) {
            case "Branch":
            case "Stone":
                other.transform.Find("Info").gameObject.SetActive(true);
                pickUpItem = other.gameObject;
                break;
        }
    }

    // 범위에서 벗어 났을 때 설명 사라짐
    private void OnTriggerExit(Collider other) 
    {
         switch(other.tag) {
            case "Branch":
            case "Stone":
                other.transform.Find("Info").gameObject.SetActive(false);
                pickUpItem = null;
                break;
        }
    }

    private void Update() 
    {
        Pick();
    }
    
    // E를 누르면 줍고 바로 착용 
    void Pick() 
    {
        if (Input.GetKeyDown(KeyCode.E) && pickUpItem != null){
            switch(pickUpItem.tag) {
                case "Branch":
                    if (stone.activeSelf) stone.SetActive(false);
                    branch.SetActive(true);
                    break;
                case "Stone":
                    if (branch.activeSelf) branch.SetActive(false);
                    stone.SetActive(true);
                    break;
            }
            pick = true;
            Destroy(pickUpItem);
        }
    }
}
