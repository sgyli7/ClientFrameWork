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
  public partial class SCMonsterDeathMsg : TBase
  {
    private List<NetFramework.Auto.MonsterDeath> _monsterDeathList;

    public List<NetFramework.Auto.MonsterDeath> MonsterDeathList
    {
      get
      {
        return _monsterDeathList;
      }
      set
      {
        __isset.monsterDeathList = true;
        this._monsterDeathList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool monsterDeathList;
    }

    public SCMonsterDeathMsg() {
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
                MonsterDeathList = new List<NetFramework.Auto.MonsterDeath>();
                TList _list12 = iprot.ReadListBegin();
                for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                {
                  NetFramework.Auto.MonsterDeath _elem14 = new NetFramework.Auto.MonsterDeath();
                  _elem14 = new NetFramework.Auto.MonsterDeath();
                  _elem14.Read(iprot);
                  MonsterDeathList.Add(_elem14);
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
      TStruct struc = new TStruct("SCMonsterDeathMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (MonsterDeathList != null && __isset.monsterDeathList) {
        field.Name = "monsterDeathList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, MonsterDeathList.Count));
          foreach (NetFramework.Auto.MonsterDeath _iter15 in MonsterDeathList)
          {
            _iter15.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCMonsterDeathMsg(");
      sb.Append("MonsterDeathList: ");
      sb.Append(MonsterDeathList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
