public class Inventory : MonoBehaviour
{
  InvSlot[] Slots;
  GameObject[] InvSlots;
  public GameObject testItem;
  private void start()
  {
    Slots = new InvSlot[23];
    Item test = new Item("test item", testItem, 2);
    InvSlots = new GameObject[23];
  }
}
public class InvSlot
{
  public InvSlot(Item storedItem)
  {
    Item storedItem = storedItem;
    int currentStackSize;
  }
}
public class Item
{
  public Item(string name, GameObject image, GameObject HeldItem, int size, string itemId)
  {
    string ItemName = name;
    GameObject objImage = image;
    GameObject held = HeldItem;
    int maxStackSize = size;
    string itemId = itemId;
  }
}
void addItemToInv(Item itemToStore)
{
  bool finished = false;
  for(slot of Slots)
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
public void awake()
{
  addItemToInv(test);
}
