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
  public partial class CSBattleEndMsg : TBase
  {
    private int _currCharHp;
    private int _useTime;
    private NetFramework.Auto.NormalStageResult _normalStageResult;
    private NetFramework.Auto.TowerDefenseStageResult _tdStageResult;
    private NetFramework.Auto.EscortStageResult _escortStageResult;

    public int CurrCharHp
    {
      get
      {
        return _currCharHp;
      }
      set
      {
        __isset.currCharHp = true;
        this._currCharHp = value;
      }
    }

    /// <summary>
    /// 打副本用了多少秒
    /// </summary>
    public int UseTime
    {
      get
      {
        return _useTime;
      }
      set
      {
        __isset.useTime = true;
        this._useTime = value;
      }
    }

    public NetFramework.Auto.NormalStageResult NormalStageResult
    {
      get
      {
        return _normalStageResult;
      }
      set
      {
        __isset.normalStageResult = true;
        this._normalStageResult = value;
      }
    }

    public NetFramework.Auto.TowerDefenseStageResult TdStageResult
    {
      get
      {
        return _tdStageResult;
      }
      set
      {
        __isset.tdStageResult = true;
        this._tdStageResult = value;
      }
    }

    public NetFramework.Auto.EscortStageResult EscortStageResult
    {
      get
      {
        return _escortStageResult;
      }
      set
      {
        __isset.escortStageResult = true;
        this._escortStageResult = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool currCharHp;
      public bool useTime;
      public bool normalStageResult;
      public bool tdStageResult;
      public bool escortStageResult;
    }

    public CSBattleEndMsg() {
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
              CurrCharHp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              UseTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Struct) {
              NormalStageResult = new NetFramework.Auto.NormalStageResult();
              NormalStageResult.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.Struct) {
              TdStageResult = new NetFramework.Auto.TowerDefenseStageResult();
              TdStageResult.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.Struct) {
              EscortStageResult = new NetFramework.Auto.EscortStageResult();
              EscortStageResult.Read(iprot);
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
      TStruct struc = new TStruct("CSBattleEndMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.currCharHp) {
        field.Name = "currCharHp";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CurrCharHp);
        oprot.WriteFieldEnd();
      }
      if (__isset.useTime) {
        field.Name = "useTime";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UseTime);
        oprot.WriteFieldEnd();
      }
      if (NormalStageResult != null && __isset.normalStageResult) {
        field.Name = "normalStageResult";
        field.Type = TType.Struct;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        NormalStageResult.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (TdStageResult != null && __isset.tdStageResult) {
        field.Name = "tdStageResult";
        field.Type = TType.Struct;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        TdStageResult.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (EscortStageResult != null && __isset.escortStageResult) {
        field.Name = "escortStageResult";
        field.Type = TType.Struct;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        EscortStageResult.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSBattleEndMsg(");
      sb.Append("CurrCharHp: ");
      sb.Append(CurrCharHp);
      sb.Append(",UseTime: ");
      sb.Append(UseTime);
      sb.Append(",NormalStageResult: ");
      sb.Append(NormalStageResult== null ? "<null>" : NormalStageResult.ToString());
      sb.Append(",TdStageResult: ");
      sb.Append(TdStageResult== null ? "<null>" : TdStageResult.ToString());
      sb.Append(",EscortStageResult: ");
      sb.Append(EscortStageResult== null ? "<null>" : EscortStageResult.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
