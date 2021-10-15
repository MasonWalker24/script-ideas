using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public InvSlot[] Slots = new InvSlot[23];
    foreach(InvSlot slot in Slots)
    {
        slot.storedItem = null;
    }
    public GameObject[] InvSlots;
    public GameObject testItem;
    public Item test;
    public void Start()
    {
        test = new Item("test item", testItem, testItem, 2, "test item");
        addItemToInv(test);

    }
    void addItemToInv(Item itemToStore)
    {
        GameObject image;
        bool finished = false;
        int i = 0;
        foreach (InvSlot slot in Slots)
        {
            if (slot.storedItem == null && finished == false)
            {
                slot.storedItem = itemToStore;
                finished = true;
                image = Instantiate(itemToStore.objImage, new Vector3(0, 0, 0), Quaternion.identity);
                image.transform.parent = InvSlots[0].transform;
                image.transform.position = new Vector3(0, 0, 0);
                slot.currentStackSize = 1;
            }
            else if (slot.storedItem.itemId == itemToStore.itemId && slot.currentStackSize < itemToStore.maxStackSize && finished == false)
            {
                slot.currentStackSize += 1;
            }
            i++;
        }
    }
}
public class InvSlot
{
    public int currentStackSize;
    public Item storedItem;
    public InvSlot(Item storeditem)
    {
        storedItem = storeditem;
    }
}
public class Item
{
    public string ItemName;
    public GameObject objImage;
    public GameObject held;
    public int maxStackSize;
    public string itemId;
    public Item(string name, GameObject image, GameObject HeldItem, int size, string itemid)
    {
        ItemName = name;
        objImage = image;
        held = HeldItem;
        maxStackSize = size;
        itemId = itemid;
    }
}
