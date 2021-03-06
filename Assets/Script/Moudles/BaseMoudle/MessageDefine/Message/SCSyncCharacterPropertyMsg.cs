/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NetFramework.Auto
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SCSyncCharacterPropertyMsg : TBase
  {
    private int _ib;
    private int _gold;
    private short _level;
    private int _exp;
    private short _power;
    private int _lastRecoverPowerTime;
    private short _energy;
    private List<sbyte> _bit4CounterList;
    private List<sbyte> _bit8CounterList;
    private List<int> _bit32CounterList;
    private List<List<int>> _cycleCounterList;
    private List<bool> _flagList;
    private short _skillPoint;
    private int _lastRecoverSkillPointTime;

    public int Ib
    {
      get
      {
        return _ib;
      }
      set
      {
        __isset.ib = true;
        this._ib = value;
      }
    }

    public int Gold
    {
      get
      {
        return _gold;
      }
      set
      {
        __isset.gold = true;
        this._gold = value;
      }
    }

    public short Level
    {
      get
      {
        return _level;
      }
      set
      {
        __isset.level = true;
        this._level = value;
      }
    }

    public int Exp
    {
      get
      {
        return _exp;
      }
      set
      {
        __isset.exp = true;
        this._exp = value;
      }
    }

    public short Power
    {
      get
      {
        return _power;
      }
      set
      {
        __isset.power = true;
        this._power = value;
      }
    }

    public int LastRecoverPowerTime
    {
      get
      {
        return _lastRecoverPowerTime;
      }
      set
      {
        __isset.lastRecoverPowerTime = true;
        this._lastRecoverPowerTime = value;
      }
    }

    public short Energy
    {
      get
      {
        return _energy;
      }
      set
      {
        __isset.energy = true;
        this._energy = value;
      }
    }

    public List<sbyte> Bit4CounterList
    {
      get
      {
        return _bit4CounterList;
      }
      set
      {
        __isset.bit4CounterList = true;
        this._bit4CounterList = value;
      }
    }

    public List<sbyte> Bit8CounterList
    {
      get
      {
        return _bit8CounterList;
      }
      set
      {
        __isset.bit8CounterList = true;
        this._bit8CounterList = value;
      }
    }

    public List<int> Bit32CounterList
    {
      get
      {
        return _bit32CounterList;
      }
      set
      {
        __isset.bit32CounterList = true;
        this._bit32CounterList = value;
      }
    }

    public List<List<int>> CycleCounterList
    {
      get
      {
        return _cycleCounterList;
      }
      set
      {
        __isset.cycleCounterList = true;
        this._cycleCounterList = value;
      }
    }

    public List<bool> FlagList
    {
      get
      {
        return _flagList;
      }
      set
      {
        __isset.flagList = true;
        this._flagList = value;
      }
    }

    public short SkillPoint
    {
      get
      {
        return _skillPoint;
      }
      set
      {
        __isset.skillPoint = true;
        this._skillPoint = value;
      }
    }

    /// <summary>
    /// 技能点最后恢复的时间戳,精确到秒
    /// </summary>
    public int LastRecoverSkillPointTime
    {
      get
      {
        return _lastRecoverSkillPointTime;
      }
      set
      {
        __isset.lastRecoverSkillPointTime = true;
        this._lastRecoverSkillPointTime = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ib;
      public bool gold;
      public bool level;
      public bool exp;
      public bool power;
      public bool lastRecoverPowerTime;
      public bool energy;
      public bool bit4CounterList;
      public bool bit8CounterList;
      public bool bit32CounterList;
      public bool cycleCounterList;
      public bool flagList;
      public bool skillPoint;
      public bool lastRecoverSkillPointTime;
    }

    public SCSyncCharacterPropertyMsg() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 10:
            if (field.Type == TType.I32) {
              Ib = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              Gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I16) {
              Level = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I32) {
              Exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.I16) {
              Power = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 51:
            if (field.Type == TType.I32) {
              LastRecoverPowerTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.I16) {
              Energy = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.List) {
              {
                Bit4CounterList = new List<sbyte>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  sbyte _elem2 = 0;
                  _elem2 = iprot.ReadByte();
                  Bit4CounterList.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 80:
            if (field.Type == TType.List) {
              {
                Bit8CounterList = new List<sbyte>();
                TList _list3 = iprot.ReadListBegin();
                for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                {
                  sbyte _elem5 = 0;
                  _elem5 = iprot.ReadByte();
                  Bit8CounterList.Add(_elem5);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 90:
            if (field.Type == TType.List) {
              {
                Bit32CounterList = new List<int>();
                TList _list6 = iprot.ReadListBegin();
                for( int _i7 = 0; _i7 < _list6.Count; ++_i7)
                {
                  int _elem8 = 0;
                  _elem8 = iprot.ReadI32();
                  Bit32CounterList.Add(_elem8);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 100:
            if (field.Type == TType.List) {
              {
                CycleCounterList = new List<List<int>>();
                TList _list9 = iprot.ReadListBegin();
                for( int _i10 = 0; _i10 < _list9.Count; ++_i10)
                {
                  List<int> _elem11 = new List<int>();
                  {
                    _elem11 = new List<int>();
                    TList _list12 = iprot.ReadListBegin();
                    for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                    {
                      int _elem14 = 0;
                      _elem14 = iprot.ReadI32();
                      _elem11.Add(_elem14);
                    }
                    iprot.ReadListEnd();
                  }
                  CycleCounterList.Add(_elem11);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 110:
            if (field.Type == TType.List) {
              {
                FlagList = new List<bool>();
                TList _list15 = iprot.ReadListBegin();
                for( int _i16 = 0; _i16 < _list15.Count; ++_i16)
                {
                  bool _elem17 = false;
                  _elem17 = iprot.ReadBool();
                  FlagList.Add(_elem17);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 120:
            if (field.Type == TType.I16) {
              SkillPoint = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 130:
            if (field.Type == TType.I32) {
              LastRecoverSkillPointTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SCSyncCharacterPropertyMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ib) {
        field.Name = "ib";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ib);
        oprot.WriteFieldEnd();
      }
      if (__isset.gold) {
        field.Name = "gold";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Gold);
        oprot.WriteFieldEnd();
      }
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I16;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.exp) {
        field.Name = "exp";
        field.Type = TType.I32;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.power) {
        field.Name = "power";
        field.Type = TType.I16;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Power);
        oprot.WriteFieldEnd();
      }
      if (__isset.lastRecoverPowerTime) {
        field.Name = "lastRecoverPowerTime";
        field.Type = TType.I32;
        field.ID = 51;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LastRecoverPowerTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.energy) {
        field.Name = "energy";
        field.Type = TType.I16;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Energy);
        oprot.WriteFieldEnd();
      }
      if (Bit4CounterList != null && __isset.bit4CounterList) {
        field.Name = "bit4CounterList";
        field.Type = TType.List;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Byte, Bit4CounterList.Count));
          foreach (sbyte _iter18 in Bit4CounterList)
          {
            oprot.WriteByte(_iter18);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Bit8CounterList != null && __isset.bit8CounterList) {
        field.Name = "bit8CounterList";
        field.Type = TType.List;
        field.ID = 80;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Byte, Bit8CounterList.Count));
          foreach (sbyte _iter19 in Bit8CounterList)
          {
            oprot.WriteByte(_iter19);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Bit32CounterList != null && __isset.bit32CounterList) {
        field.Name = "bit32CounterList";
        field.Type = TType.List;
        field.ID = 90;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, Bit32CounterList.Count));
          foreach (int _iter20 in Bit32CounterList)
          {
            oprot.WriteI32(_iter20);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (CycleCounterList != null && __isset.cycleCounterList) {
        field.Name = "cycleCounterList";
        field.Type = TType.List;
        field.ID = 100;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.List, CycleCounterList.Count));
          foreach (List<int> _iter21 in CycleCounterList)
          {
            {
              oprot.WriteListBegin(new TList(TType.I32, _iter21.Count));
              foreach (int _iter22 in _iter21)
              {
                oprot.WriteI32(_iter22);
              }
              oprot.WriteListEnd();
            }
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (FlagList != null && __isset.flagList) {
        field.Name = "flagList";
        field.Type = TType.List;
        field.ID = 110;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Bool, FlagList.Count));
          foreach (bool _iter23 in FlagList)
          {
            oprot.WriteBool(_iter23);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.skillPoint) {
        field.Name = "skillPoint";
        field.Type = TType.I16;
        field.ID = 120;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(SkillPoint);
        oprot.WriteFieldEnd();
      }
      if (__isset.lastRecoverSkillPointTime) {
        field.Name = "lastRecoverSkillPointTime";
        field.Type = TType.I32;
        field.ID = 130;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LastRecoverSkillPointTime);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCSyncCharacterPropertyMsg(");
      sb.Append("Ib: ");
      sb.Append(Ib);
      sb.Append(",Gold: ");
      sb.Append(Gold);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Exp: ");
      sb.Append(Exp);
      sb.Append(",Power: ");
      sb.Append(Power);
      sb.Append(",LastRecoverPowerTime: ");
      sb.Append(LastRecoverPowerTime);
      sb.Append(",Energy: ");
      sb.Append(Energy);
      sb.Append(",Bit4CounterList: ");
      sb.Append(Bit4CounterList);
      sb.Append(",Bit8CounterList: ");
      sb.Append(Bit8CounterList);
      sb.Append(",Bit32CounterList: ");
      sb.Append(Bit32CounterList);
      sb.Append(",CycleCounterList: ");
      sb.Append(CycleCounterList);
      sb.Append(",FlagList: ");
      sb.Append(FlagList);
      sb.Append(",SkillPoint: ");
      sb.Append(SkillPoint);
      sb.Append(",LastRecoverSkillPointTime: ");
      sb.Append(LastRecoverSkillPointTime);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
