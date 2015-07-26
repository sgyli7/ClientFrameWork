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
  public partial class SCBeatBackMsg : TBase
  {
    private long _userUniqueId;
    private Common.Auto.ThriftVector3 _dir;
    private List<long> _affectTargetList;
    private short _range;
    private int _time;

    /// <summary>
    /// 击退触发者，可能没有
    /// </summary>
    public long UserUniqueId
    {
      get
      {
        return _userUniqueId;
      }
      set
      {
        __isset.userUniqueId = true;
        this._userUniqueId = value;
      }
    }

    /// <summary>
    /// 击退者的朝向
    /// </summary>
    public Common.Auto.ThriftVector3 Dir
    {
      get
      {
        return _dir;
      }
      set
      {
        __isset.dir = true;
        this._dir = value;
      }
    }

    /// <summary>
    /// 被击退的列表
    /// </summary>
    public List<long> AffectTargetList
    {
      get
      {
        return _affectTargetList;
      }
      set
      {
        __isset.affectTargetList = true;
        this._affectTargetList = value;
      }
    }

    /// <summary>
    /// 击退距离，单位厘米
    /// </summary>
    public short Range
    {
      get
      {
        return _range;
      }
      set
      {
        __isset.range = true;
        this._range = value;
      }
    }

    /// <summary>
    /// 击退时间，单位毫秒
    /// </summary>
    public int Time
    {
      get
      {
        return _time;
      }
      set
      {
        __isset.time = true;
        this._time = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool userUniqueId;
      public bool dir;
      public bool affectTargetList;
      public bool range;
      public bool time;
    }

    public SCBeatBackMsg() {
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
            if (field.Type == TType.I64) {
              UserUniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Struct) {
              Dir = new Common.Auto.ThriftVector3();
              Dir.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.List) {
              {
                AffectTargetList = new List<long>();
                TList _list72 = iprot.ReadListBegin();
                for( int _i73 = 0; _i73 < _list72.Count; ++_i73)
                {
                  long _elem74 = 0;
                  _elem74 = iprot.ReadI64();
                  AffectTargetList.Add(_elem74);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I16) {
              Range = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.I32) {
              Time = iprot.ReadI32();
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
      TStruct struc = new TStruct("SCBeatBackMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.userUniqueId) {
        field.Name = "userUniqueId";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(UserUniqueId);
        oprot.WriteFieldEnd();
      }
      if (Dir != null && __isset.dir) {
        field.Name = "dir";
        field.Type = TType.Struct;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        Dir.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (AffectTargetList != null && __isset.affectTargetList) {
        field.Name = "affectTargetList";
        field.Type = TType.List;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, AffectTargetList.Count));
          foreach (long _iter75 in AffectTargetList)
          {
            oprot.WriteI64(_iter75);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.range) {
        field.Name = "range";
        field.Type = TType.I16;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Range);
        oprot.WriteFieldEnd();
      }
      if (__isset.time) {
        field.Name = "time";
        field.Type = TType.I32;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Time);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCBeatBackMsg(");
      sb.Append("UserUniqueId: ");
      sb.Append(UserUniqueId);
      sb.Append(",Dir: ");
      sb.Append(Dir== null ? "<null>" : Dir.ToString());
      sb.Append(",AffectTargetList: ");
      sb.Append(AffectTargetList);
      sb.Append(",Range: ");
      sb.Append(Range);
      sb.Append(",Time: ");
      sb.Append(Time);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
