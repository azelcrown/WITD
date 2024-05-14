using UnityEngine;
using System.Collections.Generic;

public class Recoger : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

public class Inventory : MonoBehaviour
{
    public int space = 10; // Espacio máximo del inventario
    public List<Item> items = new List<Item>(); // Lista de ítems en el inventario

    // Método para agregar un ítem al inventario
    public void Add(Item item)
    {
        if (items.Count < space)
        {
            items.Add(item);
            Debug.Log(Sphere + " fue agregado al inventario.");
        }
        else
        {
            Debug.Log("Inventario lleno - no se puede agregar " + item.name);
        }
    }

    // Método para eliminar un ítem del inventario
    public void Remove(Item item)
    {
        items.Remove(item);
        Debug.Log(Sphere + " fue eliminado del inventario.");
    }
}

public class Item : MonoBehaviour
{
    public string name = "Sphere"; // Nombre del ítem
    public Sprite icon = null; // Icono del ítem
    public bool isDefaultItem = false; // Si es un ítem predeterminado al inicio del juego

    // Método para usar el ítem
    public virtual void Use()
    {
        // Usar el ítem
        // Ejemplo: Debug.Log("Usando " + name);
    }

}
