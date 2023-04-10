
[System.Serializable]
public class Dog : Animal
{
    public Dog(int damage):base(damage)
    {
    }

    public void Jump()
    {
        base.Jump(10f);
    }

    public void DamageDog()
    {
        if (Damage(3) == 0)
        {
            ToString();
        }
    }

    public override string ToString()
    {
        return base.DamageAnim + "";
    }
}
