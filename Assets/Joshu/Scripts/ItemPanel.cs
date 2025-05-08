using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemPanel : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IDropHandler
{
    public Inventory inventory;
    private Mouse mouse;
    public ItemSlotInfo itemSlot;
    public Image itemImage;


    private bool click;

    public void OnPointerEnter(PointerEventData eventData)
    {
        eventData.pointerPress = this.gameObject;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        click = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (click)
        {
            OnClick();
            click = false;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        OnClick();
        click = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (click)
        {
            OnClick();
            click = false;
        }
    }

    public void PickupItem()
    {
        mouse.itemSlot = itemSlot;
        mouse.sourceItemPanel = this;
        if (Input.GetKey(KeyCode.LeftShift) && itemSlot.stacks > 1) mouse.splitSize = itemSlot.stacks / 2;
        else mouse.splitSize = itemSlot.stacks;
        mouse.SetUI();
    }
    public void FadeOut()
    {
        itemImage.CrossFadeAlpha(0.3f, 0.05f, true);
    }
    public void DropItem()
    {
        itemSlot.item = mouse.itemSlot.item;
        if (mouse.splitSize < mouse.itemSlot.stacks)
        {
            itemSlot.stacks = mouse.splitSize;
            mouse.itemSlot.stacks -= mouse.splitSize;
            mouse.EmptySlot();
        }
        else
        {
            itemSlot.stacks = mouse.itemSlot.stacks;
            inventory.ClearSlot(mouse.itemSlot);
        }
    }
 

    public void OnClick()
    {
        if (inventory != null)
        {
            mouse = inventory.mouse;

            //Grab item if mouse slot is empty
            if (mouse.itemSlot.item == null)
            {
                if (itemSlot.item != null)
                {
                    PickupItem();
                    FadeOut();
                }
            }

        }
    }
}