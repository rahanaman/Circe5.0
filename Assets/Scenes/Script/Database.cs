using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterID
{
    �ﷹ��,
    �ƿ��,
    �����׸�,
    ����
}

public enum CardID
{

}

public enum EffectID //Ư���� ���� ��굵 ���⿡ ���� �θ� ���� ����.
{

}

public enum DataID //������ �ִ� ������ ����. ����, �� ��.
{

}
public class Database
{

}


public abstract class CardOnBattleData{
    public CardID Id { get; protected set; }

    public CardOnBattleData(CardID id)
    {
        Id = id;
    }
}

public class �ﷹ��CardOnBattleData : CardOnBattleData // ���� �߿� ����� �� �ִ� ������
{
    private int _�ĵ�;
    public int �ĵ�
    {
        get { return _�ĵ�; }
        set { _�ĵ� = value; }
    }

    public �ﷹ��CardOnBattleData(CardID id) : base(id)
    {
        _�ĵ� = 0;
    }
}

public class �ƿ��CardOnBattleData : CardOnBattleData // ���� �߿� ����� �� �ִ� ������
{
    private int _�ĵ�;
    public int �ĵ�
    {
        get { return _�ĵ�; }
        set { _�ĵ� = value; }
    }

    public �ƿ��CardOnBattleData(CardID id) : base(id)
    {
        _�ĵ� = 0;
    }
}
public class �����׸�CardOnBattleData : CardOnBattleData // ���� �߿� ����� �� �ִ� ������
{
    private int _�ĵ�;
    public int �ĵ�
    {
        get { return _�ĵ�; }
        set { _�ĵ� = value; }
    }

    public �����׸�CardOnBattleData(CardID id) : base(id)
    {
        _�ĵ� = 0;
    }
}

public class ����CardOnBattleData : CardOnBattleData // ���� �߿� ����� �� �ִ� ������
{
    private int _�ĵ�;
    public int �ĵ�
    {
        get { return _�ĵ�; }
        set { _�ĵ� = value; }
    }

    public ����CardOnBattleData(CardID id) : base(id)
    {
        _�ĵ� = 0;
    }
}

public class DataCalc
{
    private float _final���;
    private int _final������;
    private List<float> _���;
    private List<int> _������;
    
    private void Calc���()
    {
        _final��� = 1;
        foreach(int i in _���)
        {

        }

    }
    public void Add���()
    {

    }
    public int Calc(int data)
    {
        int calcData = data;
        calcData = Mathf.FloorToInt(data*_final���+_final������);
        return calcData;


    }

}
