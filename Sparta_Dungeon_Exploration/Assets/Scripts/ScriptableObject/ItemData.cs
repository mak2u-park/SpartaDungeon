using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable,
    Throwable
}

public enum ConsumableType
{
    Health,
    Stamina,
    Speed,
    Jump
}

[System.Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
    
}


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
    
    [Header("Equip")]
    public GameObject equipPrefab;
    
    [Header("Throwable")]
    public GameObject throwablePrefab;
    
    
}
