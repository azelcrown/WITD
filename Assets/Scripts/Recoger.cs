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
            if (this.gameObject.name == "carta")
            {
                GameManager.Instance.tengo_carta=true;
            }

            if (this.gameObject.name == "anillo")
            {
                GameManager.Instance.tengo_anillo=true;
            }

            if (this.gameObject.name == "guardapelo")
            {
                GameManager.Instance.tengo_guardapelo=true;
            }

            if (this.gameObject.name == "huevos")
            {
                GameManager.Instance.tengo_huevos=true;
            }

            if (this.gameObject.name == "nido")
            {
                GameManager.Instance.tengo_nido=true;
            }

            if (this.gameObject.name == "abrecartas")
            {
                GameManager.Instance.tengo_abrecartas=true;
            }
            
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

           /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
           Debug.Log(Sphere + " fue agregado al inventario.");  
           */
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
        
        /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        Debug.Log(Sphere + " fue eliminado del inventario.");
        */
    }
}

public class Item : MonoBehaviour
{
    // Esto da error:      public string name = "Sphere"; // Nombre del ítem
    public Sprite icon = null; // Icono del ítem
    public bool isDefaultItem = false; // Si es un ítem predeterminado al inicio del juego

    // Método para usar el ítem
    public virtual void Use()
    {
        // Usar el ítem
        // Ejemplo: Debug.Log("Usando " + name);
    }

}
