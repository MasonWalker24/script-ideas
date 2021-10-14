public class Inventory : MonoBehaviour
{
  InvSlot Slots = new InvSlot(null)[23];
  GameObject[] InvSlots;
  public GameObject testItem;
  Iten test;
  void start()
  {
    test = new Item("test item", testItem, 2);
    InvSlots = new GameObject[23];
  }
  void addItemToInv(Item itemToStore)
{
  bool finished = false;
  foreach(InvSlot slot in Slots)
  {
    if(slot.storedItem == null && finished == false)
    {
      slot.storedItem = itemToStore
      finished = true;
      image = Instantiate(itemToStore.objImage, Quaternion.identity);
      image.transform.parent = slot;
      image.transform.position.x = 0;
      image.transform.position.y = 0;
      slot.currentStackSize = 1;
    } else if(slot.storedItem.itemId == itemToStore.itemId && slot.currentStackSize < itemToStore.maxStackSize && finished == false)
    {
      slot.currentStackSize += 1;
    }
  }
}
}
public class InvSlot
{
  public InvSlot(Item storeditem)
  {
    Item storedItem = storeditem;
    int currentStackSize;
  }
}
public class Item
{
    string ItemName;
    GameObject objImage;
    GameObject held;
    int maxStackSize;
    string itemId;
  public Item(string name, GameObject image, GameObject HeldItem, int size, string itemid)
  {
    ItemName = name;
    objImage = image;
    held = HeldItem;
    maxStackSize = size;
    itemId = itemid;
  }
}

public void moveItem()
{
  GameObject
}
