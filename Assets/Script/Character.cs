using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] new string name;
    [SerializeField] CharacterType type;
    [SerializeField] int currentHP;
    [SerializeField] int maxHP;
    [SerializeField] int attackPower;
    [SerializeField] TMP_Text overHeadText;
    [SerializeField] Image avatar;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text typeText;
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text hpText;
    [SerializeField] Button button;
    private Vector3 initialPosition;

    public Button Button { get => button; }
    public CharacterType Type { get => type;}
    public int AttackPower { get => attackPower;}
    public int CurrentHP { get => currentHP;}
    public Vector3 InitialPosition { get => initialPosition; }
    public int MaxHP { get => maxHP;}

    private void Start()
    {
        initialPosition = this.transform.position;
        overHeadText.text = name;
        nameText.text = name;
        typeText.text = type.ToString();
        healthBar.fillAmount = (float)currentHP / (float)maxHP;
        hpText.text = currentHP + "/" + maxHP;
        button.interactable = false;
        UpdateHPUI();
    }

    public void ChangeHP(int amount)
    {
        currentHP += amount;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        UpdateHPUI();
    }

    private void UpdateHPUI()
    {
        healthBar.fillAmount = (float)currentHP / (float)maxHP;
        hpText.text = currentHP + "/" + maxHP;
    }

}


