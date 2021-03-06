﻿

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
  public partial class CSQueryMailListMsg : TBase
  {
    private int _lastMailCreateTime;
    private short _size;

    public int LastMailCreateTime
    {
      get
      {
        return _lastMailCreateTime;
      }
      set
      {
        __isset.lastMailCreateTime = true;
        this._lastMailCreateTime = value;
      }
    }

    public short Size
    {
      get
      {
        return _size;
      }
      set
      {
        __isset.size = true;
        this._size = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool lastMailCreateTime;
      public bool size;
    }

    public CSQueryMailListMsg() {
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
              LastMailCreateTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I16) {
              Size = iprot.ReadI16();
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
      TStruct struc = new TStruct("CSQueryMailListMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.lastMailCreateTime) {
        field.Name = "lastMailCreateTime";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LastMailCreateTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.size) {
        field.Name = "size";
        field.Type = TType.I16;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Size);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSQueryMailListMsg(");
      sb.Append("LastMailCreateTime: ");
      sb.Append(LastMailCreateTime);
      sb.Append(",Size: ");
      sb.Append(Size);
      sb.Append(")");
      return sb.ToString();
    }

  }

}