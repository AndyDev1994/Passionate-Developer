using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Mission", 
    menuName = "Menu Itens/Mission")]
public class Mission : ScriptableObject {
    public string title;
    public string description;
    public bool isComplete;
    public int count;
    public Sprite icon;
}
