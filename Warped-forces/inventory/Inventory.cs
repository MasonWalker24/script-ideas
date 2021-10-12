public class Inventory : MonoBehaviour
{
  InvSlot[] Slots = new InvSlot[23];
}
public class InvSlot
{
  public InvSlot(Item storedItem)
  {
    Item storedItem = storedItem;
  }
}
public class Item
{
  public Item(string name, GameObject obj)
  {
    String ItemName = name;
    GameObject ShownObj = obj;
  }
}
public GameObject testItem;
private void start()
{
  Item test = new Item("test item", testItem);
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
    }
  }
}
public void awake()
{
  addItemToInv(test);
}
