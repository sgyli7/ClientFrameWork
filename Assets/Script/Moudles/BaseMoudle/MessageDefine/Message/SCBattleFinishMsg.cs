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
  public partial class SCBattleFinishMsg : TBase
  {
    private NetFramework.Auto.BattleResultType _battleResultType;
    private List<NetFramework.Auto.HeroBattleResultInfo> _heroBattleResultInfoList;

    /// <summary>
    /// 
    /// <seealso cref="NetFramework.Auto.BattleResultType"/>
    /// </summary>
    public NetFramework.Auto.BattleResultType BattleResultType
    {
      get
      {
        return _battleResultType;
      }
      set
      {
        __isset.battleResultType = true;
        this._battleResultType = value;
      }
    }

    public List<NetFramework.Auto.HeroBattleResultInfo> HeroBattleResultInfoList
    {
      get
      {
        return _heroBattleResultInfoList;
      }
      set
      {
        __isset.heroBattleResultInfoList = true;
        this._heroBattleResultInfoList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool battleResultType;
      public bool heroBattleResultInfoList;
    }

    public SCBattleFinishMsg() {
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
              BattleResultType = (NetFramework.Auto.BattleResultType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.List) {
              {
                HeroBattleResultInfoList = new List<NetFramework.Auto.HeroBattleResultInfo>();
                TList _list16 = iprot.ReadListBegin();
                for( int _i17 = 0; _i17 < _list16.Count; ++_i17)
                {
                  NetFramework.Auto.HeroBattleResultInfo _elem18 = new NetFramework.Auto.HeroBattleResultInfo();
                  _elem18 = new NetFramework.Auto.HeroBattleResultInfo();
                  _elem18.Read(iprot);
                  HeroBattleResultInfoList.Add(_elem18);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("SCBattleFinishMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.battleResultType) {
        field.Name = "battleResultType";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)BattleResultType);
        oprot.WriteFieldEnd();
      }
      if (HeroBattleResultInfoList != null && __isset.heroBattleResultInfoList) {
        field.Name = "heroBattleResultInfoList";
        field.Type = TType.List;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, HeroBattleResultInfoList.Count));
          foreach (NetFramework.Auto.HeroBattleResultInfo _iter19 in HeroBattleResultInfoList)
          {
            _iter19.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCBattleFinishMsg(");
      sb.Append("BattleResultType: ");
      sb.Append(BattleResultType);
      sb.Append(",HeroBattleResultInfoList: ");
      sb.Append(HeroBattleResultInfoList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
