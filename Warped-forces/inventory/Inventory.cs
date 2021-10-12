public class Inventory : MonoBehaviour
{
  InvSlot[] Slots = new InvSlot[23];
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
  public Item(string name, GameObject obj, int size, string itemId)
  {
    String ItemName = name;
    GameObject ShownObj = obj;
    int maxStackSize = size;
    string itemId = itemId;
  }
}
public GameObject testItem;
private void start()
{
  Item test = new Item("test item", testItem, 2);
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
    } else if(slot.storedItem.itemId == itemToStore.itemId && slot.currentStackSize < itemToStore.maxStackSize)
    {
      slot.currentStackSize += 1;
    }
  }
}
public void awake()
{
  addItemToInv(test);
}
