using System;

namespace MyRoguelike
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static int powerupGotten;

       public Enemy(string name)
       {
            this.name=SetName(name);
            health = 100;
            shield = 0;
       }
       public string GetName()
       {
        return name;
       }
       public void TakeDamage (float damage)
       {
        shield -= damage;
        if (shield<0)
        {
            float damageStillToInflict = -shield;
            shield = 0;
            health -= damageStillToInflict;
            if (health < 0) health = 0;
        }
       }
       public float GetHealth()
       {
        return health;
       }
       public float GetShield()
       {
        return shield;
       }
       public string SetName(string Plname)
       {
        string name = Plname;
        int stringLength = name.Length;
        if (stringLength > 8)
        {
            name = name.Substring(0, 8);
        }
        return name;
       }
       internal void PickupPowerUp(PowerUp powerUp, float num)
        {
            if (powerUp == PowerUp.health)
            {
                health += num;
                if (health > 100)
                    health = 100;

            }
            else if (powerUp == PowerUp.shield)
            {
                shield += num;
                if (shield > 100)
                    shield = 100;

            }
            powerupGotten++;
        }
        internal static int GetPowerUpsGotten() => powerupGotten;
    }
}
