public class Card
{
    int id;
    string name;

    public Card(int _id,string _name)
    {
        this.id = _id;
        this.name = _name;
    }
}

public class MonsterCard:Card
{
    int atk;
    int hp;
    int hpMax;

    public MonsterCard(int _id, string _name,int _atk,int _hp):base(_id,_name)
    {
        this.atk = _atk;
        this.hpMax = _hp;
        this.hp = hpMax;

    }
}

public class MagicCard:Card
{
    string effect;
    public MagicCard(int _id, string _name,string _effect):base(_id,_name)
    {
        this.effect = _effect;

    }
}

