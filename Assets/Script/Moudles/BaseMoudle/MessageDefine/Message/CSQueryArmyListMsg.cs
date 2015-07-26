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
  /// 查询军团列表
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CSQueryArmyListMsg : TBase
  {
    private NetFramework.Auto.ArmyListOrderType _orderType;
    private int _start;
    private int _limit;

    /// <summary>
    /// 
    /// <seealso cref="NetFramework.Auto.ArmyListOrderType"/>
    /// </summary>
    public NetFramework.Auto.ArmyListOrderType OrderType
    {
      get
      {
        return _orderType;
      }
      set
      {
        __isset.orderType = true;
        this._orderType = value;
      }
    }

    public int Start
    {
      get
      {
        return _start;
      }
      set
      {
        __isset.start = true;
        this._start = value;
      }
    }

    public int Limit
    {
      get
      {
        return _limit;
      }
      set
      {
        __isset.limit = true;
        this._limit = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool orderType;
      public bool start;
      public bool limit;
    }

    public CSQueryArmyListMsg() {
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
              OrderType = (NetFramework.Auto.ArmyListOrderType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              Start = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              Limit = iprot.ReadI32();
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
      TStruct struc = new TStruct("CSQueryArmyListMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.orderType) {
        field.Name = "orderType";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)OrderType);
        oprot.WriteFieldEnd();
      }
      if (__isset.start) {
        field.Name = "start";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Start);
        oprot.WriteFieldEnd();
      }
      if (__isset.limit) {
        field.Name = "limit";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Limit);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSQueryArmyListMsg(");
      sb.Append("OrderType: ");
      sb.Append(OrderType);
      sb.Append(",Start: ");
      sb.Append(Start);
      sb.Append(",Limit: ");
      sb.Append(Limit);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
