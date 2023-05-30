using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Android;

public class PlayerData // ���̺� ������
{
    public CharacterID ID { get; private set; }
    public int CurrentHP { get; private set; }
    public int MaxHP { get; private set; }
    public int MaxMP { get; private set; }
    public int RestoreMP { get; private set; } //MPȸ����


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
            case CharacterID.�ﷹ��:
                return new �ﷹ��CardOnBattleData(id);
            case CharacterID.�ƿ��:
                return new �ƿ��CardOnBattleData(id);
            case CharacterID.�����׸�:
                return new �����׸�CardOnBattleData(id);
            case CharacterID.����:
                return new ����CardOnBattleData(id);
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
