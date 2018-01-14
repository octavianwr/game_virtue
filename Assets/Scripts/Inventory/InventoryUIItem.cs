﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour {
    public Item item;

    public Text itemText;
    public Image itemImage;

    public void SetItem(Item item)
    {
        this.item = item;
        SetupItemValues();
    }

    void SetupItemValues()
    {
        itemText.text = item.ItemName;
        itemImage.sprite = Resources.Load<Sprite>("UI/Icons/Items/" + item.ObjectSlug);
		this.transform.Find("Item_Name").GetComponent<Text>().text = item.ItemName;
    }

    public void OnSelectItemButton()
    {
        InventoryController.Instance.SetItemDetails(item, GetComponent<Button>());
    }

}
