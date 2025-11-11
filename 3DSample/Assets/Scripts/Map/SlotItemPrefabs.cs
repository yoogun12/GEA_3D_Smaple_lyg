using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotItemPrefabs : MonoBehaviour
{
    public Image itemImage;
    public TextMeshProUGUI itemText;

    public void ItemSetting(Sprite itemSprite, string txt)
    {
        itemImage.sprite = itemSprite;
        itemText.text = txt;
    }

    public void UpdateInventory(Inventory myInven)
    {
        // 1.기존 슬롯 초기화

        // 2.내 인벤토리 데이터를 전체 탐색
        foreach (var item in myInven.items)
        {
            switch(item.Key)
            {
                case BlockType.Dirt:
                    // Dirt 아이템을 슬롯에 생성
                    // Instantiate 활용

                    break;
                case BlockType.Grass:

                    break;
                case BlockType.Water:

                    break;
            }
        }
    }
}
