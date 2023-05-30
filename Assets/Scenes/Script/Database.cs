using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterID
{
    헬레네,
    아우라,
    쥬피테르,
    레아
}

public enum CardID
{

}

public enum EffectID //특성에 대한 계산도 여기에 따로 두면 좋을 듯함.
{

}

public enum DataID //영향을 주는 데이터 종류. 공격, 방어도 등.
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

public class 헬레네CardOnBattleData : CardOnBattleData // 전투 중에 적용될 수 있는 데이터
{
    private int _파도;
    public int 파도
    {
        get { return _파도; }
        set { _파도 = value; }
    }

    public 헬레네CardOnBattleData(CardID id) : base(id)
    {
        _파도 = 0;
    }
}

public class 아우라CardOnBattleData : CardOnBattleData // 전투 중에 적용될 수 있는 데이터
{
    private int _파도;
    public int 파도
    {
        get { return _파도; }
        set { _파도 = value; }
    }

    public 아우라CardOnBattleData(CardID id) : base(id)
    {
        _파도 = 0;
    }
}
public class 쥬피테르CardOnBattleData : CardOnBattleData // 전투 중에 적용될 수 있는 데이터
{
    private int _파도;
    public int 파도
    {
        get { return _파도; }
        set { _파도 = value; }
    }

    public 쥬피테르CardOnBattleData(CardID id) : base(id)
    {
        _파도 = 0;
    }
}

public class 레아CardOnBattleData : CardOnBattleData // 전투 중에 적용될 수 있는 데이터
{
    private int _파도;
    public int 파도
    {
        get { return _파도; }
        set { _파도 = value; }
    }

    public 레아CardOnBattleData(CardID id) : base(id)
    {
        _파도 = 0;
    }
}

public class DataCalc
{
    private float _final배수;
    private int _final증가량;
    private List<float> _배수;
    private List<int> _증가량;
    
    private void Calc배수()
    {
        _final배수 = 1;
        foreach(int i in _배수)
        {

        }

    }
    public void Add배수()
    {

    }
    public int Calc(int data)
    {
        int calcData = data;
        calcData = Mathf.FloorToInt(data*_final배수+_final증가량);
        return calcData;


    }

}
