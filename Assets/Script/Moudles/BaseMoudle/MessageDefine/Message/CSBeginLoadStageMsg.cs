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

  /// <summary>
  /// 客户端虚拟机用
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CSBeginLoadStageMsg : TBase
  {
    private int _stageId;
    private List<long> _heroUniqueIdList;

    public int StageId
    {
      get
      {
        return _stageId;
      }
      set
      {
        __isset.stageId = true;
        this._stageId = value;
      }
    }

    public List<long> HeroUniqueIdList
    {
      get
      {
        return _heroUniqueIdList;
      }
      set
      {
        __isset.heroUniqueIdList = true;
        this._heroUniqueIdList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool stageId;
      public bool heroUniqueIdList;
    }

    public CSBeginLoadStageMsg() {
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
              StageId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.List) {
              {
                HeroUniqueIdList = new List<long>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  long _elem2 = 0;
                  _elem2 = iprot.ReadI64();
                  HeroUniqueIdList.Add(_elem2);
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
      TStruct struc = new TStruct("CSBeginLoadStageMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.stageId) {
        field.Name = "stageId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(StageId);
        oprot.WriteFieldEnd();
      }
      if (HeroUniqueIdList != null && __isset.heroUniqueIdList) {
        field.Name = "heroUniqueIdList";
        field.Type = TType.List;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, HeroUniqueIdList.Count));
          foreach (long _iter3 in HeroUniqueIdList)
          {
            oprot.WriteI64(_iter3);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSBeginLoadStageMsg(");
      sb.Append("StageId: ");
      sb.Append(StageId);
      sb.Append(",HeroUniqueIdList: ");
      sb.Append(HeroUniqueIdList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
