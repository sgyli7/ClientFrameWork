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
  public partial class SCSyncBattleLifeInfoMsg : TBase
  {
    private List<NetFramework.Auto.BattleLifeInfo> _battleLifeInfoList;

    public List<NetFramework.Auto.BattleLifeInfo> BattleLifeInfoList
    {
      get
      {
        return _battleLifeInfoList;
      }
      set
      {
        __isset.battleLifeInfoList = true;
        this._battleLifeInfoList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool battleLifeInfoList;
    }

    public SCSyncBattleLifeInfoMsg() {
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
            if (field.Type == TType.List) {
              {
                BattleLifeInfoList = new List<NetFramework.Auto.BattleLifeInfo>();
                TList _list44 = iprot.ReadListBegin();
                for( int _i45 = 0; _i45 < _list44.Count; ++_i45)
                {
                  NetFramework.Auto.BattleLifeInfo _elem46 = new NetFramework.Auto.BattleLifeInfo();
                  _elem46 = new NetFramework.Auto.BattleLifeInfo();
                  _elem46.Read(iprot);
                  BattleLifeInfoList.Add(_elem46);
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
      TStruct struc = new TStruct("SCSyncBattleLifeInfoMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BattleLifeInfoList != null && __isset.battleLifeInfoList) {
        field.Name = "battleLifeInfoList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, BattleLifeInfoList.Count));
          foreach (NetFramework.Auto.BattleLifeInfo _iter47 in BattleLifeInfoList)
          {
            _iter47.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCSyncBattleLifeInfoMsg(");
      sb.Append("BattleLifeInfoList: ");
      sb.Append(BattleLifeInfoList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
