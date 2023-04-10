using UnityEngine;

public class Animal : MonoBehaviour
{
    private int damageAnim;
    public int DamageAnim { get => damageAnim; set => damageAnim = value; }

    public Animal(int damageAnim)
    {
        this.damageAnim = damageAnim;
    }

    public int Damage(int damage)
    {
        DamageAnim -= damage;
        return DamageAnim;
    }

    public void Jump(float force)
    {
        transform.position = Vector3.up * force * Time.deltaTime;
    }

    public override string ToString()
    {
        return "Damage : " + DamageAnim;
    }
}
