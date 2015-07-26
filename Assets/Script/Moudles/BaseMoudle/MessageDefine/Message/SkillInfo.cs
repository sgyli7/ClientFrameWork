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
  public partial class SkillInfo : TBase
  {
    private short _level;
    private sbyte _quality;

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

    public sbyte Quality
    {
      get
      {
        return _quality;
      }
      set
      {
        __isset.quality = true;
        this._quality = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool level;
      public bool quality;
    }

    public SkillInfo() {
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
            if (field.Type == TType.I16) {
              Level = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Byte) {
              Quality = iprot.ReadByte();
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
      TStruct struc = new TStruct("SkillInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I16;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.quality) {
        field.Name = "quality";
        field.Type = TType.Byte;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Quality);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SkillInfo(");
      sb.Append("Level: ");
      sb.Append(Level);
      sb.Append(",Quality: ");
      sb.Append(Quality);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
