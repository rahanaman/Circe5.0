using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Android;

public class PlayerData // 세이브 데이터
{
    public CharacterID ID { get; private set; }
    public int CurrentHP { get; private set; }
    public int MaxHP { get; private set; }
    public int MaxMP { get; private set; }
    public int RestoreMP { get; private set; } //MP회복량


    public List<CardID> Cards { get; private set; }

    public List<CardOnBattleData> GetCards()
    {
        List<CardOnBattleData> list = new List<CardOnBattleData>();
        foreach (CardID id in Cards)
        {
            CardOnBattleData card = GetCard(id);
            if(card != null)
            {
                list.Add(card);
            }
        }
        return list;
    }

    private CardOnBattleData GetCard(CardID id)
    {
        switch (ID)
        {
            case CharacterID.헬레네:
                return new 헬레네CardOnBattleData(id);
            case CharacterID.아우라:
                return new 아우라CardOnBattleData(id);
            case CharacterID.쥬피테르:
                return new 쥬피테르CardOnBattleData(id);
            case CharacterID.레아:
                return new 레아CardOnBattleData(id);
            default: return null;
        }
    }

    public PlayerData()
    {

    }

    public PlayerData(CharacterID id)
    {
        ID = id;
    }

}
